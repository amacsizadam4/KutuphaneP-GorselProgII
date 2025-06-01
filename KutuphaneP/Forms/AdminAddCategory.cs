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

namespace KutuphaneP.Forms.Controls
{
    public partial class AdminAddCategory: Form
    {
        public AdminAddCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminAddCategory_Load(object sender, EventArgs e)
        {

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Lütfen bir kategori adı girin.");
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM categories WHERE Name = @Name";
                using (var checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Name", name);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Bu isimde bir kategori zaten var.");
                        return;
                    }
                }

                string insertQuery = "INSERT INTO categories (Name) VALUES (@Name)";
                using (var insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Name", name);
                    insertCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Kategori başarıyla eklendi.");
            txtCategoryName.Clear();
        }
    
}
}
