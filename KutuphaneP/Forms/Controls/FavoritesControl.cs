using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KutuphaneP.DataAccess;
using KutuphaneP.Models;
using KutuphaneP.Session;
using LibraryManagementSystem.DataAccess;
using MySql.Data.MySqlClient;

namespace KutuphaneP.Forms.Controls
{
    public partial class FavoritesControl : UserControl
    {
        public FavoritesControl()
        {
            InitializeComponent();
            LoadCategories();
            LoadFavorites();
        }

        private void LoadFavorites()
        {
            List<int> selectedCategories = new List<int>();
            foreach (var item in checkedListBoxCategories.CheckedItems)
            {
                selectedCategories.Add(((KeyValuePair<int, string>)item).Key);
            }

            flowLayoutPanelFavorites.Controls.Clear();

            List<Book> favorites = BookManager.GetFavoriteBooksByCategories(UserSession.UserID, selectedCategories);

            foreach (Book book in favorites)
            {
                var panel = BookManager.CreateBookCard(book, true, LoadFavorites);
                flowLayoutPanelFavorites.Controls.Add(panel);
            }
        }


        private void checkedListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFavorites();
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

        private void flowLayoutPanelFavorites_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FavoritesControl_Load(object sender, EventArgs e)
        {

        }
    }
}
