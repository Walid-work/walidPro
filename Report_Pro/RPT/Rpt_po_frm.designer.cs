namespace Report_Pro.RPT
{
    partial class Rpt_po_frm
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
            this.CRV_po = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_po
            // 
            this.CRV_po.ActiveViewIndex = -1;
            this.CRV_po.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_po.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_po.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_po.Location = new System.Drawing.Point(0, 0);
            this.CRV_po.Name = "CRV_po";
            this.CRV_po.SelectionFormula = "";
            this.CRV_po.Size = new System.Drawing.Size(652, 328);
            this.CRV_po.TabIndex = 0;
            this.CRV_po.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CRV_po.ViewTimeSelectionFormula = "";
            // 
            // Rpt_po_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 328);
            this.Controls.Add(this.CRV_po);
            this.Name = "Rpt_po_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Rpt_po_frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_po;

    }
}