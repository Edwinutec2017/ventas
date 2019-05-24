namespace Ventas.reporFact
{
    partial class ReportClientes
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
            this.CrystalClientes1 = new Ventas.reporFact.CrystalClientes();
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
            this.crystalReportViewer1.ReportSource = this.CrystalClientes1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(975, 548);
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(331, 18);
            this.lblTitulo.Size = new System.Drawing.Size(230, 25);
            this.lblTitulo.Text = "LISTA DE CLIENTES";
            // 
            // ReportClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 635);
            this.Name = "ReportClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ReportClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalClientes CrystalClientes1;
    }
}