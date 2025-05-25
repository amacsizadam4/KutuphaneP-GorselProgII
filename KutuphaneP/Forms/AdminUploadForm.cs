using System;
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
            // Optional: clear fields on load
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPdfPath.Text = "";
            txtCoverPath.Text = "";
            picCoverPreview.Image = null;
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

        private void btnBrowseCover_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Kitap başarıyla yüklendi!");
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
    }
}
