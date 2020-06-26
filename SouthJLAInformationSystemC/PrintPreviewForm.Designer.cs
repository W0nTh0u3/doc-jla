namespace SouthJLAInformationSystemC
{
    partial class PrintPreviewForm
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
            this.TestReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // TestReportViewer
            // 
            this.TestReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestReportViewer.LocalReport.ReportEmbeddedResource = "SouthJLAInformationSystemC.TestReports.rdlc";
            this.TestReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TestReportViewer.Name = "TestReportViewer";
            this.TestReportViewer.ServerReport.BearerToken = null;
            this.TestReportViewer.Size = new System.Drawing.Size(1200, 609);
            this.TestReportViewer.TabIndex = 0;
            // 
            // PrintPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 609);
            this.Controls.Add(this.TestReportViewer);
            this.Name = "PrintPreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internal Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrintPreviewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer TestReportViewer;
    }
}