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
    public partial class AdminDeleteBook: Form
    {
        private List<KeyValuePair<int, string>> books = new List<KeyValuePair<int, string>>();

        public AdminDeleteBook()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void AdminDeleteBook_Load(object sender, EventArgs e)
        {
            listBoxBooks.SelectionMode = SelectionMode.MultiExtended;
            LoadBooks();
        }

        private void LoadBooks()
        {
            books.Clear();
            listBoxBooks.Items.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT BookID, Title, Author FROM Books";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["BookID"]);
                        string display = $"{reader["Title"]} by {reader["Author"]}";
                        books.Add(new KeyValuePair<int, string>(id, display));
                        listBoxBooks.Items.Add(display);
                    }
                }
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için kitap seçin.");
                return;
            }

            var confirm = MessageBox.Show("Seçilen kitapları silmek istediğinize emin misiniz?",
                                          "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (var conn = DatabaseHelper.GetConnection())
            {
                foreach (int index in listBoxBooks.SelectedIndices)
                {
                    int bookId = books[index].Key;

                    string deleteCategories = "DELETE FROM book_categories WHERE BookID = @BookID";
                    string deleteUserLibrary = "DELETE FROM UserLibrary WHERE BookID = @BookID";
                    string deleteBook = "DELETE FROM Books WHERE BookID = @BookID";

                    using (var cmd1 = new MySqlCommand(deleteCategories, conn))
                    using (var cmd2 = new MySqlCommand(deleteUserLibrary, conn))
                    using (var cmd3 = new MySqlCommand(deleteBook, conn))
                    {
                        cmd1.Parameters.AddWithValue("@BookID", bookId);
                        cmd2.Parameters.AddWithValue("@BookID", bookId);
                        cmd3.Parameters.AddWithValue("@BookID", bookId);

                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                    }
                }
            }

            LoadBooks();
            MessageBox.Show("Seçilen kitap(lar) silindi.");
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDeleteBook_Load_1(object sender, EventArgs e)
        {

        }
    }
}
