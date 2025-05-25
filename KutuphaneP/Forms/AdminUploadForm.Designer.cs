namespace KutuphaneP.Forms
{
    partial class AdminUploadForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPdfPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.picCoverPreview = new System.Windows.Forms.PictureBox();
            this.txtCover = new System.Windows.Forms.Label();
            this.txtCoverPath = new System.Windows.Forms.TextBox();
            this.btnBrowseCover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(219, 164);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yazar:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(219, 196);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(132, 22);
            this.txtAuthor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "PDF Dosyası:";
            // 
            // txtPdfPath
            // 
            this.txtPdfPath.Location = new System.Drawing.Point(219, 231);
            this.txtPdfPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPdfPath.Name = "txtPdfPath";
            this.txtPdfPath.ReadOnly = true;
            this.txtPdfPath.Size = new System.Drawing.Size(132, 22);
            this.txtPdfPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(360, 226);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(133, 28);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Dosya Konumu";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(433, 449);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(133, 44);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Kitabi Yükle";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Admin Panel";
            // 
            // picCoverPreview
            // 
            this.picCoverPreview.Location = new System.Drawing.Point(219, 303);
            this.picCoverPreview.Name = "picCoverPreview";
            this.picCoverPreview.Size = new System.Drawing.Size(132, 152);
            this.picCoverPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoverPreview.TabIndex = 4;
            this.picCoverPreview.TabStop = false;
            // 
            // txtCover
            // 
            this.txtCover.AutoSize = true;
            this.txtCover.Location = new System.Drawing.Point(95, 269);
            this.txtCover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCover.Name = "txtCover";
            this.txtCover.Size = new System.Drawing.Size(102, 16);
            this.txtCover.TabIndex = 0;
            this.txtCover.Text = "Kapak Dosyası:";
            // 
            // txtCoverPath
            // 
            this.txtCoverPath.Location = new System.Drawing.Point(219, 269);
            this.txtCoverPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoverPath.Name = "txtCoverPath";
            this.txtCoverPath.ReadOnly = true;
            this.txtCoverPath.Size = new System.Drawing.Size(132, 22);
            this.txtCoverPath.TabIndex = 1;
            // 
            // btnBrowseCover
            // 
            this.btnBrowseCover.Location = new System.Drawing.Point(360, 265);
            this.btnBrowseCover.Name = "btnBrowseCover";
            this.btnBrowseCover.Size = new System.Drawing.Size(133, 31);
            this.btnBrowseCover.TabIndex = 5;
            this.btnBrowseCover.Text = "button1";
            this.btnBrowseCover.UseVisualStyleBackColor = true;
            this.btnBrowseCover.Click += new System.EventHandler(this.btnBrowseCover_Click_1);
            // 
            // AdminUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 506);
            this.Controls.Add(this.btnBrowseCover);
            this.Controls.Add(this.picCoverPreview);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtCoverPath);
            this.Controls.Add(this.txtPdfPath);
            this.Controls.Add(this.txtCover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminUploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUploadForm";
            this.Load += new System.EventHandler(this.AdminUploadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCoverPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPdfPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picCoverPreview;
        private System.Windows.Forms.Label txtCover;
        private System.Windows.Forms.TextBox txtCoverPath;
        private System.Windows.Forms.Button btnBrowseCover;
    }
}