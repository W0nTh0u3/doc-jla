﻿namespace SouthJLAInformationSystemC
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new SouthJLAInformationSystemC.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.BackgroundImage = global::SouthJLAInformationSystemC.Properties.Resources.soutjla_LOGOblur;
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPanel.Controls.Add(this.button4);
            this.ContentPanel.Controls.Add(this.dateTimePicker1);
            this.ContentPanel.Controls.Add(this.label2);
            this.ContentPanel.Controls.Add(this.button3);
            this.ContentPanel.Controls.Add(this.button2);
            this.ContentPanel.Controls.Add(this.button1);
            this.ContentPanel.Controls.Add(this.dataGridView1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(800, 450);
            this.ContentPanel.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingForm";
            this.Text = "Billing";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
    }
}