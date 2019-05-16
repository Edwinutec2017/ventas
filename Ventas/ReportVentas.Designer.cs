namespace Ventas
{
    partial class ReportVentas
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
            this.ReporteVentas1 = new Ventas.ReporteVentas();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.ReporteVentas1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1107, 530);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(373, 18);
            this.lblTitulo.Size = new System.Drawing.Size(255, 25);
            this.lblTitulo.Text = "REPORTE DE VENTAS";
            // 
            // ReportVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 609);
            this.Name = "ReportVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.ReportVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReporteVentas ReporteVentas1;
    }
}