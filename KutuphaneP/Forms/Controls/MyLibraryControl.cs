using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneP.DataAccess;
using KutuphaneP.Models;
using KutuphaneP.Session;
using KutuphaneP.DataAccess;
using KutuphaneP.Models;
using KutuphaneP.Session;
using LibraryManagementSystem.DataAccess;
using MySql.Data.MySqlClient;

namespace KutuphaneP.Forms.Controls
{
    public partial class MyLibraryControl : UserControl
    {
        public MyLibraryControl()
        {
            InitializeComponent();
            LoadCategories();
            LoadUserBooks();
        }

        private void LoadUserBooks()
        {
            List<int> selectedCategories = new List<int>();
            foreach (var item in checkedListBoxCategories.CheckedItems)
            {
                selectedCategories.Add(((KeyValuePair<int, string>)item).Key);
            }

            flowLayoutPanelMyBooks.Controls.Clear();

            List<Book> ownedBooks = BookManager.GetBooksOwnedByUserByCategories(UserSession.UserID, selectedCategories);

            foreach (Book book in ownedBooks)
            {
                Panel bookPanel = BookManager.CreateBookCard(book, true);
                flowLayoutPanelMyBooks.Controls.Add(bookPanel);
            }
        }


        private void flowLayoutPanelMyBooks_Paint(object sender, PaintEventArgs e)
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

        private void checkedListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserBooks();

        }

        private void MyLibraryControl_Load(object sender, EventArgs e)
        {

        }
    }
}
