namespace Console
{
    partial class FavoritesForm
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
            this.dgwFavorites = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFavorites)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFavorites
            // 
            this.dgwFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFavorites.Location = new System.Drawing.Point(208, 175);
            this.dgwFavorites.Name = "dgwFavorites";
            this.dgwFavorites.RowHeadersWidth = 51;
            this.dgwFavorites.RowTemplate.Height = 24;
            this.dgwFavorites.Size = new System.Drawing.Size(240, 150);
            this.dgwFavorites.TabIndex = 0;
            // 
            // FavoritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwFavorites);
            this.Name = "FavoritesForm";
            this.Text = "FavoritesForm";
            this.Load += new System.EventHandler(this.FavoritesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFavorites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFavorites;
    }
}