using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LibraryManagementSystem.DataAccess;
using MySql.Data.MySqlClient;
using PdfiumViewer;

namespace KutuphaneP.Forms
{
    public partial class AdminUploadForm : Form
    {
        private string selectedPdfPath = "";
        private string selectedCoverPath = "";

        public AdminUploadForm()
        {
            InitializeComponent();
        }

        private void AdminUploadForm_Load(object sender, EventArgs e)
        {
            // Clear inputs
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPdfPath.Text = "";
            txtCoverPath.Text = "";
            picCoverPreview.Image = null;

            // Load categories into CheckedListBox
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT CategoryID, Name FROM categories";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var categoryList = new List<KeyValuePair<int, string>>();
                    while (reader.Read())
                    {
                        categoryList.Add(new KeyValuePair<int, string>(
                            Convert.ToInt32(reader["CategoryID"]),
                            reader["Name"].ToString()));
                    }

                    checkedListBoxCategories.Items.Clear();
                    foreach (var cat in categoryList)
                        checkedListBoxCategories.Items.Add(cat);

                    checkedListBoxCategories.DisplayMember = "Value";
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF files (*.pdf)|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedPdfPath = ofd.FileName;
                txtPdfPath.Text = selectedPdfPath;
            }
        }

        private void btnBrowseCover_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedCoverPath = ofd.FileName;
                txtCoverPath.Text = selectedCoverPath;
                picCoverPreview.ImageLocation = selectedCoverPath;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(selectedPdfPath))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz ve PDF dosyası seçiniz.");
                return;
            }

            string booksFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Books");
            string coversFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Covers");

            Directory.CreateDirectory(booksFolder);
            Directory.CreateDirectory(coversFolder);

            string newPdfName = Guid.NewGuid().ToString() + ".pdf";
            string newPdfPath = Path.Combine(booksFolder, newPdfName);
            string newCoverPath = null;

            try
            {
                File.Copy(selectedPdfPath, newPdfPath, overwrite: true);

                if (!string.IsNullOrEmpty(selectedCoverPath))
                {
                    string newCoverName = Guid.NewGuid().ToString() + Path.GetExtension(selectedCoverPath);
                    newCoverPath = Path.Combine(coversFolder, newCoverName);
                    File.Copy(selectedCoverPath, newCoverPath, overwrite: true);
                }

                int totalPages = GetPdfPageCount(newPdfPath);
                if (totalPages == 0)
                {
                    MessageBox.Show("PDF sayfa sayısı alınamadı.");
                    return;
                }

                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO Books (Title, Author, PDFPath, CoverPath, TotalPages)
                                     VALUES (@Title, @Author, @PDFPath, @CoverPath, @TotalPages)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@PDFPath", newPdfPath);
                    cmd.Parameters.AddWithValue("@CoverPath", newCoverPath ?? "");
                    cmd.Parameters.AddWithValue("@TotalPages", totalPages);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        long newBookId = cmd.LastInsertedId;

                        foreach (var item in checkedListBoxCategories.CheckedItems)
                        {
                            if (item is KeyValuePair<int, string> selectedCategory)
                            {
                                string insertCategory = "INSERT INTO book_categories (BookID, CategoryID) VALUES (@BookID, @CategoryID)";
                                using (var catCmd = new MySqlCommand(insertCategory, conn))
                                {
                                    catCmd.Parameters.AddWithValue("@BookID", newBookId);
                                    catCmd.Parameters.AddWithValue("@CategoryID", selectedCategory.Key);
                                    catCmd.ExecuteNonQuery();
                                }
                            }
                        }

                        MessageBox.Show("Kitap ve kategorileri başarıyla yüklendi!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kitap yüklenirken hata oluştu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private int GetPdfPageCount(string pdfPath)
        {
            try
            {
                using (var doc = PdfDocument.Load(pdfPath))
                {
                    return doc.PageCount;
                }
            }
            catch
            {
                return 0;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not used anymore
        }

        private void checkedListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
