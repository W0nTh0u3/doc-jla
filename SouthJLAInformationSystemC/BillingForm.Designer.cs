namespace SouthJLAInformationSystemC
{
    partial class BillingForm
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listCombo = new System.Windows.Forms.ComboBox();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.dateFiledBox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.monthlyBtn = new System.Windows.Forms.Button();
            this.weeklyBtn = new System.Windows.Forms.Button();
            this.dailyBtn = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.BackgroundImage = global::SouthJLAInformationSystemC.Properties.Resources.soutjla_LOGOblur;
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Controls.Add(this.listCombo);
            this.ContentPanel.Controls.Add(this.typeCombo);
            this.ContentPanel.Controls.Add(this.dataGrid);
            this.ContentPanel.Controls.Add(this.button4);
            this.ContentPanel.Controls.Add(this.dateFiledBox);
            this.ContentPanel.Controls.Add(this.label2);
            this.ContentPanel.Controls.Add(this.monthlyBtn);
            this.ContentPanel.Controls.Add(this.weeklyBtn);
            this.ContentPanel.Controls.Add(this.dailyBtn);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1230, 500);
            this.ContentPanel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type:";
            // 
            // listCombo
            // 
            this.listCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCombo.FormattingEnabled = true;
            this.listCombo.Location = new System.Drawing.Point(705, 15);
            this.listCombo.Name = "listCombo";
            this.listCombo.Size = new System.Drawing.Size(121, 21);
            this.listCombo.TabIndex = 9;
            // 
            // typeCombo
            // 
            this.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "TESTS",
            "PACKAGES"});
            this.typeCombo.Location = new System.Drawing.Point(558, 15);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(121, 21);
            this.typeCombo.TabIndex = 8;
            this.typeCombo.SelectedValueChanged += new System.EventHandler(this.TypeChange);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(29, 81);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(939, 398);
            this.dataGrid.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(974, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dateFiledBox
            // 
            this.dateFiledBox.Location = new System.Drawing.Point(246, 15);
            this.dateFiledBox.Name = "dateFiledBox";
            this.dateFiledBox.Size = new System.Drawing.Size(200, 20);
            this.dateFiledBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generate Report";
            // 
            // monthlyBtn
            // 
            this.monthlyBtn.Location = new System.Drawing.Point(497, 41);
            this.monthlyBtn.Name = "monthlyBtn";
            this.monthlyBtn.Size = new System.Drawing.Size(75, 23);
            this.monthlyBtn.TabIndex = 3;
            this.monthlyBtn.Text = "Monthly";
            this.monthlyBtn.UseVisualStyleBackColor = true;
            // 
            // weeklyBtn
            // 
            this.weeklyBtn.Location = new System.Drawing.Point(416, 41);
            this.weeklyBtn.Name = "weeklyBtn";
            this.weeklyBtn.Size = new System.Drawing.Size(75, 23);
            this.weeklyBtn.TabIndex = 2;
            this.weeklyBtn.Text = "Weekly";
            this.weeklyBtn.UseVisualStyleBackColor = true;
            // 
            // dailyBtn
            // 
            this.dailyBtn.Location = new System.Drawing.Point(335, 41);
            this.dailyBtn.Name = "dailyBtn";
            this.dailyBtn.Size = new System.Drawing.Size(75, 23);
            this.dailyBtn.TabIndex = 1;
            this.dailyBtn.Text = "Daily";
            this.dailyBtn.UseVisualStyleBackColor = true;
            this.dailyBtn.Click += new System.EventHandler(this.dailyBtn_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 500);
            this.Controls.Add(this.ContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingForm";
            this.Text = "Billing";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateFiledBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button monthlyBtn;
        private System.Windows.Forms.Button weeklyBtn;
        private System.Windows.Forms.Button dailyBtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ComboBox listCombo;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Label label1;
    }
}