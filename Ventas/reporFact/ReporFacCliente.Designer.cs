namespace Ventas.reporFact
{
    partial class ReporFacCliente
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
            this.CrystalFacCliente1 = new Ventas.reporFact.CrystalFacCliente();
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
            this.crystalReportViewer1.Location = new System.Drawing.Point(-25, 60);
            this.crystalReportViewer1.ReportSource = this.CrystalFacCliente1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(894, 590);
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(183, 18);
            this.lblTitulo.Size = new System.Drawing.Size(410, 25);
            this.lblTitulo.Text = "REPORTE DE FACTURAS X CLIENTE";
            // 
            // ReporFacCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 671);
            this.Name = "ReporFacCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.ReporFacCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalFacCliente CrystalFacCliente1;
    }
}