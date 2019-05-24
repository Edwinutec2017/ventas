namespace Ventas.reporFact
{
    partial class ClientVende
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataReport = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(55, 53);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(54, 160);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataReport);
            this.groupBox3.Location = new System.Drawing.Point(54, 261);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(85, 22);
            this.lblTitulo.Size = new System.Drawing.Size(66, 24);
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataReport
            // 
            this.dataReport.AllowUserToAddRows = false;
            this.dataReport.AllowUserToDeleteRows = false;
            this.dataReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataReport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataReport.Location = new System.Drawing.Point(13, 19);
            this.dataReport.Name = "dataReport";
            this.dataReport.ReadOnly = true;
            this.dataReport.Size = new System.Drawing.Size(405, 167);
            this.dataReport.TabIndex = 0;
            this.dataReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReport_CellContentClick);
            this.dataReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReport_CellContentClick);
            // 
            // ClientVende
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 476);
            this.Name = "ClientVende";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.ClientVende_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataReport;
    }
}