namespace Ventas
{
    partial class BusquedaFact
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
            this.dataFact = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFact)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(650, 37);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(648, 18);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(650, 94);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(647, 75);
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(446, 94);
            // 
            // lblIva
            // 
            this.lblIva.Location = new System.Drawing.Point(447, 75);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(446, 37);
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(444, 18);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(32, 224);
            this.groupBox2.Size = new System.Drawing.Size(955, 93);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(876, 23);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(790, 20);
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnHome
            // 
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataFact);
            this.groupBox3.Location = new System.Drawing.Point(21, 323);
            this.groupBox3.Size = new System.Drawing.Size(966, 240);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(32, 60);
            this.groupBox1.Size = new System.Drawing.Size(955, 158);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(686, 20);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActu
            // 
            this.btnActu.Location = new System.Drawing.Point(510, 20);
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // btnEli
            // 
            this.btnEli.Location = new System.Drawing.Point(592, 20);
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // dataFact
            // 
            this.dataFact.AllowUserToAddRows = false;
            this.dataFact.AllowUserToDeleteRows = false;
            this.dataFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFact.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataFact.Location = new System.Drawing.Point(6, 20);
            this.dataFact.Name = "dataFact";
            this.dataFact.ReadOnly = true;
            this.dataFact.Size = new System.Drawing.Size(945, 207);
            this.dataFact.TabIndex = 0;
            this.dataFact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFact_CellContentClick);
            this.dataFact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFact_CellContentClick);
            // 
            // BusquedaFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(999, 575);
            this.Name = "BusquedaFact";
            this.Load += new System.EventHandler(this.BusquedaFact_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFact;
    }
}