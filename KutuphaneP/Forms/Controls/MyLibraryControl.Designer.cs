namespace KutuphaneP.Forms.Controls
{
    partial class MyLibraryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelMyBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMyBooks
            // 
            this.flowLayoutPanelMyBooks.AutoScroll = true;
            this.flowLayoutPanelMyBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMyBooks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMyBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelMyBooks.Name = "flowLayoutPanelMyBooks";
            this.flowLayoutPanelMyBooks.Size = new System.Drawing.Size(780, 380);
            this.flowLayoutPanelMyBooks.TabIndex = 0;
            this.flowLayoutPanelMyBooks.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMyBooks_Paint);
            // 
            // MyLibraryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelMyBooks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MyLibraryControl";
            this.Size = new System.Drawing.Size(780, 380);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMyBooks;
    }
}
