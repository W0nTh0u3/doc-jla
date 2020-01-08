namespace SouthJLAInformationSystemC
{
    partial class VerifyPopUp
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
            this.IntPrintBtn = new System.Windows.Forms.Button();
            this.ExtPrintBtn = new System.Windows.Forms.Button();
            this.FileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IntPrintBtn
            // 
            this.IntPrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntPrintBtn.Location = new System.Drawing.Point(44, 34);
            this.IntPrintBtn.Name = "IntPrintBtn";
            this.IntPrintBtn.Size = new System.Drawing.Size(119, 43);
            this.IntPrintBtn.TabIndex = 0;
            this.IntPrintBtn.Text = "Internal Print";
            this.IntPrintBtn.UseVisualStyleBackColor = true;
            this.IntPrintBtn.Click += new System.EventHandler(this.IntPrintBtn_Click);
            // 
            // ExtPrintBtn
            // 
            this.ExtPrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtPrintBtn.Location = new System.Drawing.Point(44, 83);
            this.ExtPrintBtn.Name = "ExtPrintBtn";
            this.ExtPrintBtn.Size = new System.Drawing.Size(119, 43);
            this.ExtPrintBtn.TabIndex = 1;
            this.ExtPrintBtn.Text = "External Print";
            this.ExtPrintBtn.UseVisualStyleBackColor = true;
            this.ExtPrintBtn.Click += new System.EventHandler(this.ExtPrintBtn_Click);
            // 
            // FileBtn
            // 
            this.FileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileBtn.Location = new System.Drawing.Point(44, 132);
            this.FileBtn.Name = "FileBtn";
            this.FileBtn.Size = new System.Drawing.Size(119, 43);
            this.FileBtn.TabIndex = 2;
            this.FileBtn.Text = "File";
            this.FileBtn.UseVisualStyleBackColor = true;
            this.FileBtn.Click += new System.EventHandler(this.FileBtn_Click);
            // 
            // VerifyPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(208, 215);
            this.Controls.Add(this.FileBtn);
            this.Controls.Add(this.ExtPrintBtn);
            this.Controls.Add(this.IntPrintBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VerifyPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IntPrintBtn;
        private System.Windows.Forms.Button ExtPrintBtn;
        private System.Windows.Forms.Button FileBtn;
    }
}