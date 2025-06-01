using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneP.DataAccess;
using KutuphaneP.Models;
using KutuphaneP.Session;
using LibraryManagementSystem.DataAccess;
using MySql.Data.MySqlClient;


namespace KutuphaneP.Forms.Controls
{
    public partial class AllBooksControl : UserControl
    {
        public AllBooksControl()
        {
           // MessageBox.Show("Current user ID: " + UserSession.UserID);

            InitializeComponent();
            LoadAllBooks();
            LoadCategories();
        }

        private void LoadAllBooks()
        {
            flowLayoutPanelBooks.Controls.Clear();

            List<int> selectedCategoryIds = new List<int>();
            foreach (var item in checkedListBoxCategories.CheckedItems)
            {
                selectedCategoryIds.Add(((KeyValuePair<int, string>)item).Key);
            }

            List<Book> allBooks = BookManager.GetBooksByCategories(selectedCategoryIds);

            foreach (Book book in allBooks)
            {
                bool owned = BookManager.UserOwnsBook(book.BookID);
                var panel = BookManager.CreateBookCard(book, owned, LoadAllBooks);
                flowLayoutPanelBooks.Controls.Add(panel);
            }
        }



        private void flowLayoutPanelBooks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadCategories()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT CategoryID, Name FROM categories";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        checkedListBoxCategories.Items.Add(
                            new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["CategoryID"]),
                                reader["Name"].ToString()));
                    }
                }
            }

            checkedListBoxCategories.DisplayMember = "Value";
            checkedListBoxCategories.ValueMember = "Key";
        }

        private void AllBooksControl_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllBooks();
        }
    }
}
