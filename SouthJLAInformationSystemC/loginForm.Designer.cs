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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.Btn_signin = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnl_login);
            this.panel1.Controls.Add(this.Panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pnl_login
            // 
            this.pnl_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_login.Controls.Add(this.WrongLabel);
            this.pnl_login.Controls.Add(this.Btn_signin);
            this.pnl_login.Controls.Add(this.Label1);
            this.pnl_login.Controls.Add(this.Label4);
            this.pnl_login.Controls.Add(this.passBox);
            this.pnl_login.Controls.Add(this.userBox);
            resources.ApplyResources(this.pnl_login, "pnl_login");
            this.pnl_login.Name = "pnl_login";
            // 
            // WrongLabel
            // 
            resources.ApplyResources(this.WrongLabel, "WrongLabel");
            this.WrongLabel.Name = "WrongLabel";
            // 
            // Btn_signin
            // 
            resources.ApplyResources(this.Btn_signin, "Btn_signin");
            this.Btn_signin.Name = "Btn_signin";
            this.Btn_signin.UseVisualStyleBackColor = true;
            this.Btn_signin.Click += new System.EventHandler(this.Btn_signin_Click);
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // passBox
            // 
            resources.ApplyResources(this.passBox, "passBox");
            this.passBox.Name = "passBox";
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox3_KeyDown);
            // 
            // userBox
            // 
            resources.ApplyResources(this.userBox, "userBox");
            this.userBox.Name = "userBox";
            this.userBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox4_KeyDown);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Panel2, "Panel2");
            this.Panel2.Name = "Panel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label WrongLabel;
        internal System.Windows.Forms.Button Btn_signin;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox passBox;
        internal System.Windows.Forms.TextBox userBox;
    }
}

