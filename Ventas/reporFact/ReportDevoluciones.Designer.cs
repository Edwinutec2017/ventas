namespace Ventas.reporFact
{
    partial class ReportDevoluciones
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
            this.CrystalDev1 = new Ventas.reporFact.CrystalDev();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.ReportSource = this.CrystalDev1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(381, 12);
            this.lblTitulo.Size = new System.Drawing.Size(189, 25);
            this.lblTitulo.Text = "DEVOLUCIONES";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // ReportDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 689);
            this.Name = "ReportDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDev CrystalDev1;
    }
}