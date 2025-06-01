using LibraryManagementSystem.DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneP.Forms
{
    public partial class AdminDeleteCategory: Form
    {
        private List<KeyValuePair<int, string>> categories = new List<KeyValuePair<int, string>>();

        public AdminDeleteCategory()
        {
            InitializeComponent();
            LoadCategories();
        }
        private void AdminDeleteCategory_Load(object sender, EventArgs e)
        {
            listBoxCategories.SelectionMode = SelectionMode.MultiExtended;
            LoadCategories();
        }

        private void LoadCategories()
        {
            categories.Clear();
            listBoxCategories.Items.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT CategoryID, Name FROM categories";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["CategoryID"]);
                        string name = reader["Name"].ToString();
                        categories.Add(new KeyValuePair<int, string>(id, name));
                        listBoxCategories.Items.Add(name);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için kategori seçin.");
                return;
            }

            var confirm = MessageBox.Show("Seçilen kategorileri silmek istediğinize emin misiniz?\nİlgili kitap-kategori bağlantıları da silinecek.",
                                          "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (var conn = DatabaseHelper.GetConnection())
            {
                foreach (int index in listBoxCategories.SelectedIndices)
                {
                    int categoryId = categories[index].Key;

                    string deleteLinks = "DELETE FROM book_categories WHERE CategoryID = @CategoryID";
                    string deleteCategory = "DELETE FROM categories WHERE CategoryID = @CategoryID";

                    using (var cmd1 = new MySqlCommand(deleteLinks, conn))
                    using (var cmd2 = new MySqlCommand(deleteCategory, conn))
                    {
                        cmd1.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd2.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                    }
                }
            }

            LoadCategories();
            MessageBox.Show("Seçilen kategori(ler) silindi.");
        }
    

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
