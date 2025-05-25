
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneP.Forms.Controls;
using KutuphaneP.Session;

namespace KutuphaneP.Forms
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadControl(UserControl uc)
        {
            panelMainContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(uc);
        }


        private void btnMyLibrary_Click(object sender, EventArgs e)
        {
            LoadControl(new MyLibraryControl());
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            LoadControl(new AllBooksControl());
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            LoadControl(new FavoritesControl());
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            var adminPanel = new AdminUploadForm();
            adminPanel.ShowDialog();
        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserSession.UserID = 0;
                UserSession.Username = null;

                
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                
                this.Close();
            }
        }
    }
}
