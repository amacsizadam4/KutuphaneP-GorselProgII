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

namespace KutuphaneP.Forms.Controls
{
    public partial class MyLibraryControl : UserControl
    {
        public MyLibraryControl()
        {
            InitializeComponent();
            LoadUserBooks();
        }

        private void LoadUserBooks()
        {
            flowLayoutPanelMyBooks.Controls.Clear();

            List<Book> ownedBooks = BookManager.GetBooksOwnedByUser(UserSession.UserID);

            foreach (Book book in ownedBooks)
            {
                // We pass 'true' since these are already owned
                Panel bookPanel = BookManager.CreateBookCard(book, true);
                flowLayoutPanelMyBooks.Controls.Add(bookPanel);
            }
        }


    }
}
