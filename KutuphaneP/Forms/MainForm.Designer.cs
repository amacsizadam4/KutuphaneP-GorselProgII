namespace KutuphaneP.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMyLibrary = new System.Windows.Forms.Button();
            this.btnAllBooks = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMyLibrary
            // 
            this.btnMyLibrary.Location = new System.Drawing.Point(16, 15);
            this.btnMyLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyLibrary.Name = "btnMyLibrary";
            this.btnMyLibrary.Size = new System.Drawing.Size(176, 48);
            this.btnMyLibrary.TabIndex = 0;
            this.btnMyLibrary.Text = "Kitaplığım";
            this.btnMyLibrary.UseVisualStyleBackColor = true;
            this.btnMyLibrary.Click += new System.EventHandler(this.btnMyLibrary_Click);
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.Location = new System.Drawing.Point(200, 15);
            this.btnAllBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Size = new System.Drawing.Size(176, 48);
            this.btnAllBooks.TabIndex = 0;
            this.btnAllBooks.Text = "Tüm Kitaplar";
            this.btnAllBooks.UseVisualStyleBackColor = true;
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // btnFavorites
            // 
            this.btnFavorites.Location = new System.Drawing.Point(384, 15);
            this.btnFavorites.Margin = new System.Windows.Forms.Padding(4);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(176, 48);
            this.btnFavorites.TabIndex = 0;
            this.btnFavorites.Text = "Favorilerim";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.AutoSize = true;
            this.panelMainContent.Location = new System.Drawing.Point(16, 70);
            this.panelMainContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1040, 468);
            this.panelMainContent.TabIndex = 1;
            this.panelMainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainContent_Paint);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(880, 15);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(176, 48);
            this.btnAdminPanel.TabIndex = 2;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(666, 15);
            this.logOut.Margin = new System.Windows.Forms.Padding(4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(176, 48);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "Çıkış Yap";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1072, 555);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.btnAllBooks);
            this.Controls.Add(this.btnMyLibrary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMyLibrary;
        private System.Windows.Forms.Button btnAllBooks;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button logOut;
    }
}