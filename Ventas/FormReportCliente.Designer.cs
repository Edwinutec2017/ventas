namespace Ventas
{
    partial class FormReportCliente
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
            this.CrystalReportCliente1 = new Ventas.CrystalReportCliente();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.CrystalReportCliente1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(798, 590);
            // 
            // FormReportCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 665);
            this.Name = "FormReportCliente";
            this.Text = "FormReportCliente";
            this.Load += new System.EventHandler(this.FormReportCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalReportCliente CrystalReportCliente1;
    }
}