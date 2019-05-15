namespace Ventas
{
    partial class Factura
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
            this.dataventas = new System.Windows.Forms.DataGridView();
            this.groupEncabezado.SuspendLayout();
            this.groupDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataventas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupEncabezado
            // 
            this.groupEncabezado.Size = new System.Drawing.Size(808, 203);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(589, 143);
            this.btnProducto.Size = new System.Drawing.Size(70, 45);
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(505, 140);
            this.btnCliente.Size = new System.Drawing.Size(63, 48);
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // chekCredito
            // 
            this.chekCredito.Visible = true;
            // 
            // chekEfectivo
            // 
            this.chekEfectivo.Visible = true;
            // 
            // lblPago
            // 
            this.lblPago.Visible = true;
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.Size = new System.Drawing.Size(100, 22);
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Size = new System.Drawing.Size(100, 22);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Size = new System.Drawing.Size(132, 22);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Size = new System.Drawing.Size(134, 22);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Size = new System.Drawing.Size(164, 22);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Size = new System.Drawing.Size(164, 22);
            // 
            // txtNonbreCliente
            // 
            this.txtNonbreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonbreCliente.Size = new System.Drawing.Size(138, 22);
            // 
            // txCodCliente
            // 
            this.txCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCodCliente.Size = new System.Drawing.Size(70, 22);
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Size = new System.Drawing.Size(75, 22);
            // 
            // groupDetalle
            // 
            this.groupDetalle.Controls.Add(this.dataventas);
            this.groupDetalle.Size = new System.Drawing.Size(788, 198);
            // 
            // btnHome
            // 
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dataventas
            // 
            this.dataventas.AllowUserToAddRows = false;
            this.dataventas.AllowUserToDeleteRows = false;
            this.dataventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataventas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataventas.Location = new System.Drawing.Point(6, 19);
            this.dataventas.Name = "dataventas";
            this.dataventas.Size = new System.Drawing.Size(776, 173);
            this.dataventas.TabIndex = 0;
            this.dataventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataventas_CellContentClick);
            this.dataventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataventas_CellContentClick);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(860, 617);
            this.MaximizeBox = false;
            this.Name = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.groupEncabezado.ResumeLayout(false);
            this.groupEncabezado.PerformLayout();
            this.groupDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataventas;
    }
}