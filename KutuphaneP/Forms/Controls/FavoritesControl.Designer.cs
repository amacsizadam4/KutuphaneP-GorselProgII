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
            this.SuspendLayout();
            // 
            // flowLayoutPanelFavorites
            // 
            this.flowLayoutPanelFavorites.AutoScroll = true;
            this.flowLayoutPanelFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFavorites.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelFavorites.Name = "flowLayoutPanelFavorites";
            this.flowLayoutPanelFavorites.Size = new System.Drawing.Size(1040, 468);
            this.flowLayoutPanelFavorites.TabIndex = 0;
           // this.flowLayoutPanelFavorites.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelFavorites_Paint);
            // 
            // FavoritesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelFavorites);
            this.Name = "FavoritesControl";
            this.Size = new System.Drawing.Size(1040, 468);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFavorites;
    }
}
