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
            this.InternalPrintViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // InternalPrintViewer
            // 
            this.InternalPrintViewer.ActiveViewIndex = -1;
            this.InternalPrintViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InternalPrintViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.InternalPrintViewer.DisplayBackgroundEdge = false;
            this.InternalPrintViewer.DisplayStatusBar = false;
            this.InternalPrintViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InternalPrintViewer.EnableToolTips = false;
            this.InternalPrintViewer.Location = new System.Drawing.Point(0, 0);
            this.InternalPrintViewer.Name = "InternalPrintViewer";
            this.InternalPrintViewer.ShowCloseButton = false;
            this.InternalPrintViewer.ShowCopyButton = false;
            this.InternalPrintViewer.ShowExportButton = false;
            this.InternalPrintViewer.ShowGotoPageButton = false;
            this.InternalPrintViewer.ShowGroupTreeButton = false;
            this.InternalPrintViewer.ShowLogo = false;
            this.InternalPrintViewer.ShowParameterPanelButton = false;
            this.InternalPrintViewer.ShowRefreshButton = false;
            this.InternalPrintViewer.ShowTextSearchButton = false;
            this.InternalPrintViewer.ShowZoomButton = false;
            this.InternalPrintViewer.Size = new System.Drawing.Size(1200, 609);
            this.InternalPrintViewer.TabIndex = 0;
            this.InternalPrintViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.InternalPrintViewer.Load += new System.EventHandler(this.PrintPreviewForm_Load);
            // 
            // PrintPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 609);
            this.Controls.Add(this.InternalPrintViewer);
            this.Name = "PrintPreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internal Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrintPreviewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer InternalPrintViewer;
    }
}