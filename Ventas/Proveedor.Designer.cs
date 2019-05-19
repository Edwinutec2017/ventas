namespace Ventas
{
    partial class Proveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataProve = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProve)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(137, 64);
            // 
            // btnHome
            // 
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(137, 243);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(379, 13);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataProve);
            this.groupBox3.Size = new System.Drawing.Size(981, 210);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            // 
            // txtReg
            // 
            this.txtReg.Enabled = false;
            // 
            // txtNIt
            // 
            this.txtNIt.Enabled = false;
            // 
            // txtRazon
            // 
            this.txtRazon.Enabled = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(304, 19);
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Size = new System.Drawing.Size(180, 21);
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Enabled = false;
            // 
            // dataProve
            // 
            this.dataProve.AllowUserToAddRows = false;
            this.dataProve.AllowUserToDeleteRows = false;
            this.dataProve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProve.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataProve.Location = new System.Drawing.Point(12, 20);
            this.dataProve.Name = "dataProve";
            this.dataProve.ReadOnly = true;
            this.dataProve.Size = new System.Drawing.Size(963, 184);
            this.dataProve.TabIndex = 0;
            this.dataProve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProve_CellContentClick);
            this.dataProve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProve_CellContentClick);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 564);
            this.Name = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProve;
    }
}