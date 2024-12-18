namespace Console
{
    partial class UserManagement
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.comboBoxAd = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GoToAd1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAd2 = new System.Windows.Forms.ComboBox();
            this.GoToAd2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Favroilediğim İlanlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(241, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 8;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.DarkSalmon;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userName.Location = new System.Drawing.Point(170, 36);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(0, 36);
            this.userName.TabIndex = 9;
            // 
            // comboBoxAd
            // 
            this.comboBoxAd.FormattingEnabled = true;
            this.comboBoxAd.Location = new System.Drawing.Point(66, 186);
            this.comboBoxAd.Name = "comboBoxAd";
            this.comboBoxAd.Size = new System.Drawing.Size(203, 24);
            this.comboBoxAd.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(420, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 201);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // GoToAd1
            // 
            this.GoToAd1.Location = new System.Drawing.Point(66, 235);
            this.GoToAd1.Name = "GoToAd1";
            this.GoToAd1.Size = new System.Drawing.Size(203, 26);
            this.GoToAd1.TabIndex = 14;
            this.GoToAd1.Text = "İlana Git";
            this.GoToAd1.UseVisualStyleBackColor = true;
            this.GoToAd1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "İlanlarım";
            // 
            // comboBoxAd2
            // 
            this.comboBoxAd2.FormattingEnabled = true;
            this.comboBoxAd2.Location = new System.Drawing.Point(66, 361);
            this.comboBoxAd2.Name = "comboBoxAd2";
            this.comboBoxAd2.Size = new System.Drawing.Size(203, 24);
            this.comboBoxAd2.TabIndex = 16;
            // 
            // GoToAd2
            // 
            this.GoToAd2.Location = new System.Drawing.Point(66, 416);
            this.GoToAd2.Name = "GoToAd2";
            this.GoToAd2.Size = new System.Drawing.Size(203, 26);
            this.GoToAd2.TabIndex = 17;
            this.GoToAd2.Text = "İlana Git";
            this.GoToAd2.UseVisualStyleBackColor = true;
            this.GoToAd2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(822, 510);
            this.Controls.Add(this.GoToAd2);
            this.Controls.Add(this.comboBoxAd2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoToAd1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxAd);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.ComboBox comboBoxAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button GoToAd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAd2;
        private System.Windows.Forms.Button GoToAd2;
    }
}