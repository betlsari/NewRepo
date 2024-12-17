namespace Console
{
    partial class Forum
    {   /// <summary>
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
            this.btnAddPosts = new System.Windows.Forms.Button();
            this.lstPosts = new System.Windows.Forms.ListBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lstComments = new System.Windows.Forms.ListBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPosts
            // 
            this.btnAddPosts.Location = new System.Drawing.Point(44, 415);
            this.btnAddPosts.Name = "btnAddPosts";
            this.btnAddPosts.Size = new System.Drawing.Size(174, 23);
            this.btnAddPosts.TabIndex = 0;
            this.btnAddPosts.Text = "Gönderi Ekle";
            this.btnAddPosts.UseVisualStyleBackColor = true;
            this.btnAddPosts.Click += new System.EventHandler(this.btnAddPosts_Click_1);
            // 
            // lstPosts
            // 
            this.lstPosts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lstPosts.FormattingEnabled = true;
            this.lstPosts.ItemHeight = 16;
            this.lstPosts.Location = new System.Drawing.Point(28, 112);
            this.lstPosts.Name = "lstPosts";
            this.lstPosts.Size = new System.Drawing.Size(261, 212);
            this.lstPosts.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(125, 333);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(115, 22);
            this.txtTitle.TabIndex = 2;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(28, 387);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(194, 22);
            this.txtContent.TabIndex = 3;
            // 
            // lstComments
            // 
            this.lstComments.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lstComments.FormattingEnabled = true;
            this.lstComments.ItemHeight = 16;
            this.lstComments.Location = new System.Drawing.Point(493, 112);
            this.lstComments.Name = "lstComments";
            this.lstComments.Size = new System.Drawing.Size(257, 212);
            this.lstComments.TabIndex = 4;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(553, 333);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(174, 22);
            this.txtComment.TabIndex = 5;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(553, 387);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(174, 23);
            this.btnAddComment.TabIndex = 6;
            this.btnAddComment.Text = "Yorum Ekle";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(25, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Konu Başlığı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 106);
            this.label2.TabIndex = 8;
            this.label2.Text = "FORUM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lstComments);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lstPosts);
            this.Controls.Add(this.btnAddPosts);
            this.Name = "MainForm";
            this.Text = "Forum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPosts;
        private System.Windows.Forms.ListBox lstPosts;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ListBox lstComments;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
}