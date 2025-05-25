using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneP.DataAccess;
using KutuphaneP.Models;
using KutuphaneP.Session;


namespace KutuphaneP.Forms.Controls
{
    public partial class AllBooksControl : UserControl
    {
        public AllBooksControl()
        {
           // MessageBox.Show("Current user ID: " + UserSession.UserID);

            InitializeComponent();
            LoadAllBooks();
        }

        private void LoadAllBooks()
        {
            flowLayoutPanelBooks.Controls.Clear();

            List<Book> allBooks = BookManager.GetAllBooks();

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
    }
}
