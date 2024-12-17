namespace Console
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Register = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.Label();
            this.surname1 = new System.Windows.Forms.Label();
            this.username1 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.name0 = new System.Windows.Forms.TextBox();
            this.surname0 = new System.Windows.Forms.TextBox();
            this.userName0 = new System.Windows.Forms.TextBox();
            this.password0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eMail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.DarkCyan;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Register.Location = new System.Drawing.Point(159, 307);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(370, 86);
            this.Register.TabIndex = 9;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click_1);
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name1.Location = new System.Drawing.Point(89, 58);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(70, 25);
            this.name1.TabIndex = 10;
            this.name1.Text = "Name:";
            // 
            // surname1
            // 
            this.surname1.AutoSize = true;
            this.surname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surname1.Location = new System.Drawing.Point(72, 100);
            this.surname1.Name = "surname1";
            this.surname1.Size = new System.Drawing.Size(98, 25);
            this.surname1.TabIndex = 11;
            this.surname1.Text = "Surname:";
            // 
            // username1
            // 
            this.username1.AutoSize = true;
            this.username1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username1.Location = new System.Drawing.Point(57, 151);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(116, 25);
            this.username1.TabIndex = 12;
            this.username1.Text = "User Name:";
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password1.Location = new System.Drawing.Point(66, 207);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(104, 25);
            this.password1.TabIndex = 13;
            this.password1.Text = "Password:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(303, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // name0
            // 
            this.name0.Location = new System.Drawing.Point(183, 61);
            this.name0.Name = "name0";
            this.name0.Size = new System.Drawing.Size(100, 22);
            this.name0.TabIndex = 20;
            // 
            // surname0
            // 
            this.surname0.Location = new System.Drawing.Point(183, 103);
            this.surname0.Name = "surname0";
            this.surname0.Size = new System.Drawing.Size(100, 22);
            this.surname0.TabIndex = 21;
            // 
            // userName0
            // 
            this.userName0.Location = new System.Drawing.Point(183, 154);
            this.userName0.Name = "userName0";
            this.userName0.Size = new System.Drawing.Size(100, 22);
            this.userName0.TabIndex = 22;
            // 
            // password0
            // 
            this.password0.Location = new System.Drawing.Point(183, 207);
            this.password0.Name = "password0";
            this.password0.Size = new System.Drawing.Size(100, 22);
            this.password0.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "E mail:";
            // 
            // eMail
            // 
            this.eMail.Location = new System.Drawing.Point(183, 260);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(100, 22);
            this.eMail.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password0);
            this.Controls.Add(this.userName0);
            this.Controls.Add(this.surname0);
            this.Controls.Add(this.name0);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.surname1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.Register);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label surname1;
        private System.Windows.Forms.Label username1;
        private System.Windows.Forms.Label password1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox name0;
        private System.Windows.Forms.TextBox surname0;
        private System.Windows.Forms.TextBox userName0;
        private System.Windows.Forms.TextBox password0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eMail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}