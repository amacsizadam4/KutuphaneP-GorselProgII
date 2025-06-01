namespace KutuphaneP.Forms.Controls
{
    partial class FavoritesControl
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
            this.flowLayoutPanelFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.checkedListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanelFavorites
            // 
            this.flowLayoutPanelFavorites.AutoScroll = true;
            this.flowLayoutPanelFavorites.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelFavorites.Location = new System.Drawing.Point(126, 0);
            this.flowLayoutPanelFavorites.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelFavorites.Name = "flowLayoutPanelFavorites";
            this.flowLayoutPanelFavorites.Size = new System.Drawing.Size(997, 654);
            this.flowLayoutPanelFavorites.TabIndex = 0;
            this.flowLayoutPanelFavorites.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelFavorites_Paint);
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
            // FavoritesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBoxCategories);
            this.Controls.Add(this.flowLayoutPanelFavorites);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FavoritesControl";
            this.Size = new System.Drawing.Size(1123, 654);
            this.Load += new System.EventHandler(this.FavoritesControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFavorites;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategories;
    }
}
