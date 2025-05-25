using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KutuphaneP.Forms;
using KutuphaneP.Models;
using KutuphaneP.Session;
using LibraryManagementSystem.DataAccess;
using MySql.Data.MySqlClient;

namespace KutuphaneP.DataAccess
{
    public class BookManager
    {
        public static List<Book> GetAllBooks()
        {
            var books = new List<Book>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Books";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            BookID = Convert.ToInt32(reader["BookID"]),
                            Title = reader["Title"].ToString(),
                            Author = reader["Author"].ToString(),
                            PDFPath = reader["PDFPath"].ToString(),
                            CoverPath = reader["CoverPath"].ToString(),
                            TotalPages = Convert.ToInt32(reader["TotalPages"])
                        });
                    }
                }
            }

            return books;
        }

        public static List<Book> GetBooksOwnedByUser(int userID)
        {
            var books = new List<Book>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT b.BookID, b.Title, b.Author, b.PDFPath, b.CoverPath, b.TotalPages
                                 FROM Books b
                                 INNER JOIN UserLibrary ul ON b.BookID = ul.BookID
                                 WHERE ul.UserID = @UserID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                BookID = Convert.ToInt32(reader["BookID"]),
                                Title = reader["Title"].ToString(),
                                Author = reader["Author"].ToString(),
                                PDFPath = reader["PDFPath"].ToString(),
                                CoverPath = reader["CoverPath"].ToString(),
                                TotalPages = Convert.ToInt32(reader["TotalPages"])
                            });
                        }
                    }
                }
            }

            return books;
        }

        public static List<Book> GetFavoriteBooks(int userID)
        {
            var books = new List<Book>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT b.BookID, b.Title, b.Author, b.PDFPath, b.CoverPath, b.TotalPages
                                 FROM Books b
                                 INNER JOIN UserLibrary ul ON b.BookID = ul.BookID
                                 WHERE ul.UserID = @UserID AND ul.IsFavorite = 1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                BookID = Convert.ToInt32(reader["BookID"]),
                                Title = reader["Title"].ToString(),
                                Author = reader["Author"].ToString(),
                                PDFPath = reader["PDFPath"].ToString(),
                                CoverPath = reader["CoverPath"].ToString(),
                                TotalPages = Convert.ToInt32(reader["TotalPages"])
                            });
                        }
                    }
                }
            }

            return books;
        }

        public static bool UserOwnsBook(int bookID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM UserLibrary WHERE UserID = @UserID AND BookID = @BookID";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static bool AddBookToUserLibrary(int bookID, int totalPages)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO UserLibrary (UserID, BookID, LastPage, TotalPages, Completion)
                                 VALUES (@UserID, @BookID, 0, @TotalPages, 0)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@TotalPages", totalPages);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static (int lastPage, int totalPages, double completion) GetReadingProgress(int bookID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT LastPage, TotalPages, Completion 
                         FROM UserLibrary 
                         WHERE UserID = @UserID 
                           AND BookID = @BookID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);
                    cmd.Parameters.AddWithValue("@BookID", bookID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int lastPage = Convert.ToInt32(reader["LastPage"]);
                            int totalPages = Convert.ToInt32(reader["TotalPages"]);
                            double completion = Convert.ToDouble(reader["Completion"]);
                            return (lastPage, totalPages, completion);
                        }
                    }
                }
            }

            // Fallback if no entry exists
            return (0, 1, 0);
        }


        public static int GetBookTotalPages(int bookID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT TotalPages FROM Books WHERE BookID = @BookID";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static bool ToggleFavorite(int bookID, bool isFav)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE UserLibrary SET IsFavorite = @IsFav WHERE UserID = @UserID AND BookID = @BookID";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IsFav", isFav);
                cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool IsBookFavorite(int bookID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT IsFavorite FROM UserLibrary WHERE UserID = @UserID AND BookID = @BookID";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                var result = cmd.ExecuteScalar();
                return result != null && Convert.ToBoolean(result);
            }
        }

        public static Panel CreateBookCard(Book book, bool owned, Action refreshCallback = null)
        {
            var bookPanel = new Panel
            {
                Width = 160,
                Height = 420,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            var cover = new PictureBox
            {
                Width = 140,
                Height = 180,
                Top = 10,
                Left = 10,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = (!string.IsNullOrEmpty(book.CoverPath) && File.Exists(book.CoverPath))
                    ? Image.FromFile(book.CoverPath)
                    : Properties.Resources.sampleCover
            };

            var lblTitle = new Label
            {
                Text = book.Title,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Width = 140,
                Top = cover.Bottom + 5,
                Left = 10,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblAuthor = new Label
            {
                Text = book.Author,
                Font = new Font("Arial", 8),
                Width = 140,
                Top = lblTitle.Bottom + 2,
                Left = 10,
                TextAlign = ContentAlignment.MiddleCenter
            };

            bookPanel.Controls.AddRange(new Control[] { cover, lblTitle, lblAuthor });

            int nextY = lblAuthor.Bottom + 5;

            if (owned)
            {
                var (lastPage, totalPages, completion) = GetReadingProgress(book.BookID);

                var lblOwned = new Label
                {
                    Text = "Sahip Olunan",
                    Font = new Font("Arial", 8, FontStyle.Italic),
                    ForeColor = Color.Green,
                    Width = 140,
                    Top = nextY,
                    Left = 10,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                bookPanel.Controls.Add(lblOwned);
                nextY = lblOwned.Bottom + 5;

                var lblProgress = new Label
                {
                    Text = $"İlerleme: Sayfa {lastPage + 1} / {totalPages}",
                    Font = new Font("Arial", 8),
                    Width = 140,
                    Top = nextY,
                    Left = 10,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                bookPanel.Controls.Add(lblProgress);

                var lblPercent = new Label
                {
                    Text = $"({completion * 100:F1}%) tamamlandı",
                    Font = new Font("Arial", 7, FontStyle.Italic),
                    Width = 140,
                    Top = lblProgress.Bottom + 2,
                    Left = 10,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                bookPanel.Controls.Add(lblPercent);
                nextY = lblPercent.Bottom + 5;

                var favCheckbox = new CheckBox
                {
                    Appearance = Appearance.Button,
                    Text = "⭐ Favorile",
                    Checked = IsBookFavorite(book.BookID),
                    Width = 140,
                    Top = nextY,
                    Left = 10,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                favCheckbox.CheckedChanged += (s, e) =>
                {
                    ToggleFavorite(book.BookID, favCheckbox.Checked);
                    refreshCallback?.Invoke();
                };
                bookPanel.Controls.Add(favCheckbox);
                nextY = favCheckbox.Bottom + 5;

                var btnRead = new Button
                {
                    Text = "📖 Oku",
                    Width = 140,
                    Height = 30,
                    Top = nextY,
                    Left = 10
                };
                btnRead.Click += (s, e) =>
                {
                    new ReaderForm(book).Show();
                };
                bookPanel.Controls.Add(btnRead);
            }
            else
            {
                var btnAdd = new Button
                {
                    Text = "Kitaplığıma Ekle",
                    Width = 140,
                    Height = 30,
                    Top = nextY,
                    Left = 10
                };
                btnAdd.Click += (s, e) =>
                {
                    bool added = AddBookToUserLibrary(book.BookID, book.TotalPages);
                    if (added)
                    {
                        MessageBox.Show($"'{book.Title}' kütüphanene eklendi!");
                        refreshCallback?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Kitap eklenirken hata oluştu.");
                    }
                };
                bookPanel.Controls.Add(btnAdd);
            }

            return bookPanel;
        }
    }
}
