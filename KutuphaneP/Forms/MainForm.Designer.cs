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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMyLibrary
            // 
            this.btnMyLibrary.Location = new System.Drawing.Point(16, 92);
            this.btnMyLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyLibrary.Name = "btnMyLibrary";
            this.btnMyLibrary.Size = new System.Drawing.Size(176, 33);
            this.btnMyLibrary.TabIndex = 0;
            this.btnMyLibrary.Text = "Kitaplığım";
            this.btnMyLibrary.UseVisualStyleBackColor = true;
            this.btnMyLibrary.Click += new System.EventHandler(this.btnMyLibrary_Click);
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.Location = new System.Drawing.Point(384, 92);
            this.btnAllBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Size = new System.Drawing.Size(176, 33);
            this.btnAllBooks.TabIndex = 0;
            this.btnAllBooks.Text = "Tüm Kitaplar";
            this.btnAllBooks.UseVisualStyleBackColor = true;
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // btnFavorites
            // 
            this.btnFavorites.Location = new System.Drawing.Point(200, 92);
            this.btnFavorites.Margin = new System.Windows.Forms.Padding(4);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(176, 33);
            this.btnFavorites.TabIndex = 0;
            this.btnFavorites.Text = "Favorilerim";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.AutoSize = true;
            this.panelMainContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainContent.Location = new System.Drawing.Point(16, 133);
            this.panelMainContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1123, 654);
            this.panelMainContent.TabIndex = 1;
            this.panelMainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainContent_Paint);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(958, 10);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(88, 33);
            this.btnAdminPanel.TabIndex = 2;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(1054, 10);
            this.logOut.Margin = new System.Windows.Forms.Padding(4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(75, 33);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "Çıkış Yap";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KutuphaneP.Properties.Resources.gelisim_banner;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1152, 800);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}