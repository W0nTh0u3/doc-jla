namespace SouthJLAInformationSystemC
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernamePic = new System.Windows.Forms.PictureBox();
            this.PasswordPic = new System.Windows.Forms.PictureBox();
            this.UsernameUnder = new System.Windows.Forms.Panel();
            this.PasswordUnder = new System.Windows.Forms.Panel();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameBox.Location = new System.Drawing.Point(69, 234);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(225, 22);
            this.UsernameBox.TabIndex = 3;
            this.UsernameBox.Text = "admin";
            this.UsernameBox.Click += new System.EventHandler(this.UsernameBox_Click);
            this.UsernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameBox_KeyDown);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(69, 288);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(225, 22);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.Text = "admin";
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameBox_KeyDown);
            // 
            // UsernamePic
            // 
            this.UsernamePic.Image = global::SouthJLAInformationSystemC.Properties.Resources.user_64px;
            this.UsernamePic.Location = new System.Drawing.Point(22, 215);
            this.UsernamePic.Name = "UsernamePic";
            this.UsernamePic.Size = new System.Drawing.Size(41, 41);
            this.UsernamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsernamePic.TabIndex = 5;
            this.UsernamePic.TabStop = false;
            // 
            // PasswordPic
            // 
            this.PasswordPic.Image = global::SouthJLAInformationSystemC.Properties.Resources.password_64px;
            this.PasswordPic.Location = new System.Drawing.Point(22, 275);
            this.PasswordPic.Name = "PasswordPic";
            this.PasswordPic.Size = new System.Drawing.Size(41, 41);
            this.PasswordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordPic.TabIndex = 6;
            this.PasswordPic.TabStop = false;
            // 
            // UsernameUnder
            // 
            this.UsernameUnder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.UsernameUnder.Location = new System.Drawing.Point(69, 260);
            this.UsernameUnder.Name = "UsernameUnder";
            this.UsernameUnder.Size = new System.Drawing.Size(225, 3);
            this.UsernameUnder.TabIndex = 7;
            // 
            // PasswordUnder
            // 
            this.PasswordUnder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.PasswordUnder.Location = new System.Drawing.Point(69, 313);
            this.PasswordUnder.Name = "PasswordUnder";
            this.PasswordUnder.Size = new System.Drawing.Size(225, 3);
            this.PasswordUnder.TabIndex = 8;
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.SignInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(33, 335);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(261, 37);
            this.SignInBtn.TabIndex = 1;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WrongLabel.Location = new System.Drawing.Point(116, 382);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(94, 13);
            this.WrongLabel.TabIndex = 10;
            this.WrongLabel.Text = "Wrong Credentials";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WrongLabel);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.PasswordUnder);
            this.Controls.Add(this.UsernameUnder);
            this.Controls.Add(this.PasswordPic);
            this.Controls.Add(this.UsernamePic);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFormV2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.PictureBox UsernamePic;
        private System.Windows.Forms.PictureBox PasswordPic;
        private System.Windows.Forms.Panel UsernameUnder;
        private System.Windows.Forms.Panel PasswordUnder;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label WrongLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}