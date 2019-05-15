namespace Ventas
{
    partial class ActuFactu
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
            this.dataProd = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupEncabezado.SuspendLayout();
            this.groupDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupEncabezado
            // 
            this.groupEncabezado.Size = new System.Drawing.Size(825, 203);
            this.groupEncabezado.Enter += new System.EventHandler(this.groupEncabezado_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(741, 138);
            this.btnGuardar.Size = new System.Drawing.Size(61, 55);
            this.btnGuardar.Visible = false;
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(656, 138);
            this.btnProducto.Size = new System.Drawing.Size(60, 59);
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(560, 138);
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(702, 42);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(707, 26);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(670, 104);
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(667, 88);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(512, 104);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(509, 88);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(309, 42);
            // 
            // lblVendedor
            // 
            this.lblVendedor.Location = new System.Drawing.Point(314, 26);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(309, 104);
            // 
            // lblDocumento
            // 
            this.lblDocumento.Location = new System.Drawing.Point(314, 88);
            // 
            // txtNonbreCliente
            // 
            this.txtNonbreCliente.Location = new System.Drawing.Point(107, 104);
            // 
            // groupDetalle
            // 
            this.groupDetalle.Controls.Add(this.dataProd);
            this.groupDetalle.Size = new System.Drawing.Size(805, 198);
            // 
            // btnHome
            // 
            this.btnHome.Size = new System.Drawing.Size(46, 46);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Size = new System.Drawing.Size(56, 16);
            this.lblTotal.Text = "Total $";
            // 
            // dataProd
            // 
            this.dataProd.AllowUserToAddRows = false;
            this.dataProd.AllowUserToDeleteRows = false;
            this.dataProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProd.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataProd.Location = new System.Drawing.Point(6, 19);
            this.dataProd.Name = "dataProd";
            this.dataProd.Size = new System.Drawing.Size(793, 150);
            this.dataProd.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(257, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 29);
            this.lblTitulo.TabIndex = 31;
            // 
            // ActuFactu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(860, 620);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "ActuFactu";
            this.Load += new System.EventHandler(this.ActuFactu_Load);
            this.Controls.SetChildIndex(this.groupEncabezado, 0);
            this.Controls.SetChildIndex(this.groupDetalle, 0);
            this.Controls.SetChildIndex(this.btnHome, 0);
            this.Controls.SetChildIndex(this.lblSub, 0);
            this.Controls.SetChildIndex(this.txtSub, 0);
            this.Controls.SetChildIndex(this.lblIva, 0);
            this.Controls.SetChildIndex(this.txtIva, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.groupEncabezado.ResumeLayout(false);
            this.groupEncabezado.PerformLayout();
            this.groupDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProd;
        private System.Windows.Forms.Label lblTitulo;
    }
}