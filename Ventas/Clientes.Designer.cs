namespace Ventas
{
    partial class Clientes
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
            this.dataCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // btnHome
            // 
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtNit
            // 
            this.txtNit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtDirec
            // 
            this.txtDirec.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtId
            // 
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtTipo
            // 
            this.txtTipo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtEstado
            // 
            this.txtEstado.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtClasifi
            // 
            this.txtClasifi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(371, 13);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(554, 263);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(680, 263);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(818, 262);
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // dataCliente
            // 
            this.dataCliente.AllowUserToAddRows = false;
            this.dataCliente.AllowUserToDeleteRows = false;
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCliente.Location = new System.Drawing.Point(16, 316);
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.Size = new System.Drawing.Size(908, 241);
            this.dataCliente.TabIndex = 34;
            this.dataCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCliente_CellContentClick);
            this.dataCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCliente_CellContentClick);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(987, 569);
            this.Controls.Add(this.dataCliente);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.btnHome, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.lblDocu, 0);
            this.Controls.SetChildIndex(this.txtNit, 0);
            this.Controls.SetChildIndex(this.lblNit, 0);
            this.Controls.SetChildIndex(this.txtDirec, 0);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.lblTelefono, 0);
            this.Controls.SetChildIndex(this.txtCorreo, 0);
            this.Controls.SetChildIndex(this.lblCorreo, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.txtTipo, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtClasifi, 0);
            this.Controls.SetChildIndex(this.lblClasificacion, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblClasChe, 0);
            this.Controls.SetChildIndex(this.chekPeque, 0);
            this.Controls.SetChildIndex(this.chekMedi, 0);
            this.Controls.SetChildIndex(this.chekGra, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.lblBuscar, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnTodos, 0);
            this.Controls.SetChildIndex(this.dataCliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCliente;
    }
}