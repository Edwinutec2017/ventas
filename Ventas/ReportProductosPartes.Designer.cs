﻿namespace Ventas
{
    partial class ReportProductosPartes
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
            this.ReportProductParte1 = new Ventas.ReportProductParte();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.ReportProductParte1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1107, 590);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(203, 25);
            this.lblTitulo.Text = "Reporte de Partes";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // ReportProductosPartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 662);
            this.Name = "ReportProductosPartes";
            this.Text = "ReportProductosPartes";
            this.Load += new System.EventHandler(this.ReportProductosPartes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReportProductParte ReportProductParte1;
    }
}