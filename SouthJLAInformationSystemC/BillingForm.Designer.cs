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
            this.components = new System.ComponentModel.Container();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dateFiledBox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SouthJLAInformationSystemC.DatabaseDataSet();
            this.uniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.BackgroundImage = global::SouthJLAInformationSystemC.Properties.Resources.soutjla_LOGOblur;
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ContentPanel.Controls.Add(this.button4);
            this.ContentPanel.Controls.Add(this.dateFiledBox);
            this.ContentPanel.Controls.Add(this.label2);
            this.ContentPanel.Controls.Add(this.button3);
            this.ContentPanel.Controls.Add(this.button2);
            this.ContentPanel.Controls.Add(this.button1);
            this.ContentPanel.Controls.Add(this.dataGridView1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1230, 500);
            this.ContentPanel.TabIndex = 22;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Monthly";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Weekly";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Daily";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uniqueID,
            this.name,
            this.date,
            this.account,
            this.package,
            this.totalAmt,
            this.netAmount,
            this.paidAmt,
            this.balance});
            this.dataGridView1.DataSource = this.databaseDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(100, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uniqueID
            // 
            this.uniqueID.HeaderText = "Lab No.";
            this.uniqueID.Name = "uniqueID";
            this.uniqueID.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Patient Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // account
            // 
            this.account.HeaderText = "Reffered By";
            this.account.Name = "account";
            this.account.ReadOnly = true;
            this.account.Width = 200;
            // 
            // package
            // 
            this.package.HeaderText = "Package";
            this.package.Name = "package";
            this.package.ReadOnly = true;
            // 
            // totalAmt
            // 
            this.totalAmt.HeaderText = "Total Amt";
            this.totalAmt.Name = "totalAmt";
            this.totalAmt.ReadOnly = true;
            // 
            // netAmount
            // 
            this.netAmount.HeaderText = "Net Amt";
            this.netAmount.Name = "netAmount";
            this.netAmount.ReadOnly = true;
            // 
            // paidAmt
            // 
            this.paidAmt.HeaderText = "Paid Amt";
            this.paidAmt.Name = "paidAmt";
            this.paidAmt.ReadOnly = true;
            // 
            // balance
            // 
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateFiledBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn package;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
    }
}