using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KutuphaneP.DataAccess;
using KutuphaneP.Models;
using KutuphaneP.Session;

namespace KutuphaneP.Forms.Controls
{
    public partial class FavoritesControl : UserControl
    {
        public FavoritesControl()
        {
            InitializeComponent();
            LoadFavorites();
        }

        private void LoadFavorites()
        {
            flowLayoutPanelFavorites.Controls.Clear();

            List<Book> favorites = BookManager.GetFavoriteBooks(UserSession.UserID);

            foreach (Book book in favorites)
            {
                var panel = BookManager.CreateBookCard(book, true, LoadFavorites);
                flowLayoutPanelFavorites.Controls.Add(panel);
            }
        }
    }
}
