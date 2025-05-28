using System;
using System.IO;
using System.Windows.Forms;
using PdfiumViewer;
using KutuphaneP.Models;
using KutuphaneP.Session;
using KutuphaneP.DataAccess;
using MySql.Data.MySqlClient;
using LibraryManagementSystem.DataAccess;

namespace KutuphaneP.Forms
{
    public partial class ReaderForm : Form
    {
        private PdfViewer pdfViewer;
        private int bookID;
        private int totalPages;
        private int lastSavedPage = -1;
        private Timer pageMonitor;

        public ReaderForm(Book book)
        {
            InitializeComponent();
            this.bookID = book.BookID;
            InitializePDFViewer();
            LoadPDF(book);
        }

        private void InitializePDFViewer()
        {
            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            this.Controls.Add(pdfViewer);

            pageMonitor = new Timer();
            pageMonitor.Interval = 1000; // 1 second
            pageMonitor.Tick += PageMonitor_Tick;
        }

        private void LoadPDF(Book book)
        {
            if (!File.Exists(book.PDFPath))
            {
                MessageBox.Show("PDF dosyası bulunamadı:\n" + book.PDFPath);
                this.Close();
                return;
            }

            try
            {
                var document = PdfiumViewer.PdfDocument.Load(book.PDFPath);
                pdfViewer.Document = document;
                totalPages = document.PageCount;

                int savedPage = GetLastPage(book.BookID);
                pdfViewer.Renderer.Page = savedPage;
                UpdateProgressLabel(savedPage);
                lastSavedPage = savedPage;

                pageMonitor.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF dosyası bulunamadı :\n" + ex.Message);
                this.Close();
            }
        }


        private void PageMonitor_Tick(object sender, EventArgs e)
        {
            if (pdfViewer.Document == null)
                return;

            int currentPage = pdfViewer.Renderer.Page;

            if (currentPage != lastSavedPage)
            {
                UpdateProgressLabel(currentPage);
                SaveCurrentPage(bookID, currentPage, totalPages);
                lastSavedPage = currentPage;
            }
        }

        private void UpdateProgressLabel(int currentPage)
        {
            double progress = ((double)(currentPage + 1) / totalPages) * 100;
            this.Text = $"Okunuyor... Sayfa {currentPage + 1}/{totalPages} ({progress:F1}%)";
        }

        private int GetLastPage(int bookID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT LastPage FROM UserLibrary WHERE UserID = @UserID AND BookID = @BookID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);
                cmd.Parameters.AddWithValue("@BookID", bookID);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void SaveCurrentPage(int bookID, int currentPage, int totalPages)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                double completion = ((double)(currentPage + 1) / totalPages);

                string query = @"UPDATE UserLibrary 
                                 SET LastPage = @LastPage, TotalPages = @TotalPages, Completion = @Completion 
                                 WHERE UserID = @UserID AND BookID = @BookID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LastPage", currentPage);
                cmd.Parameters.AddWithValue("@TotalPages", totalPages);
                cmd.Parameters.AddWithValue("@Completion", completion);
                cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.ExecuteNonQuery();
            }


        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            pageMonitor?.Stop();
            pageMonitor?.Dispose();
        }

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            // leave this empty or add custom init logic here
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            pdfViewer.ZoomMode = PdfViewerZoomMode.FitWidth;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            pdfViewer.ZoomMode = PdfViewerZoomMode.FitHeight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pdfViewer.ZoomMode = PdfViewerZoomMode.FitBest;
        }

        private void lblProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
