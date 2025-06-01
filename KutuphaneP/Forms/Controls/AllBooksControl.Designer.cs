namespace KutuphaneP.Forms.Controls
{
    partial class AllBooksControl
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
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.checkedListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(126, 0);
            this.flowLayoutPanelBooks.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(997, 654);
            this.flowLayoutPanelBooks.TabIndex = 0;
            this.flowLayoutPanelBooks.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelBooks_Paint);
            // 
            // checkedListBoxCategories
            // 
            this.checkedListBoxCategories.CheckOnClick = true;
            this.checkedListBoxCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkedListBoxCategories.FormattingEnabled = true;
            this.checkedListBoxCategories.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxCategories.Name = "checkedListBoxCategories";
            this.checkedListBoxCategories.Size = new System.Drawing.Size(121, 654);
            this.checkedListBoxCategories.TabIndex = 0;
            this.checkedListBoxCategories.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxCategories_SelectedIndexChanged);
            // 
            // AllBooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBoxCategories);
            this.Controls.Add(this.flowLayoutPanelBooks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AllBooksControl";
            this.Size = new System.Drawing.Size(1123, 654);
            this.Load += new System.EventHandler(this.AllBooksControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBooks;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategories;
    }
}
