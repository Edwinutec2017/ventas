namespace Ventas
{
    partial class Usuarios
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
            this.dataUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(12, 164);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 193);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(144, 111);
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(144, 82);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 111);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(12, 84);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(144, 193);
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(144, 174);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(561, 265);
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataUser
            // 
            this.dataUser.AllowUserToAddRows = false;
            this.dataUser.AllowUserToDeleteRows = false;
            this.dataUser.AllowUserToResizeRows = false;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataUser.Location = new System.Drawing.Point(12, 325);
            this.dataUser.Name = "dataUser";
            this.dataUser.ReadOnly = true;
            this.dataUser.Size = new System.Drawing.Size(677, 203);
            this.dataUser.TabIndex = 27;
            this.dataUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_CellContentClick);
            this.dataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_CellContentClick);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(701, 540);
            this.Controls.Add(this.dataUser);
            this.Name = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.btnHome, 0);
            this.Controls.SetChildIndex(this.lblUser, 0);
            this.Controls.SetChildIndex(this.txtUser, 0);
            this.Controls.SetChildIndex(this.lblPass1, 0);
            this.Controls.SetChildIndex(this.txtPassUser, 0);
            this.Controls.SetChildIndex(this.lblPass2, 0);
            this.Controls.SetChildIndex(this.txtPassUser2, 0);
            this.Controls.SetChildIndex(this.lblRol, 0);
            this.Controls.SetChildIndex(this.cheBoxAdmin, 0);
            this.Controls.SetChildIndex(this.cheBoxVende, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.lblRl, 0);
            this.Controls.SetChildIndex(this.txtRol, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.lbBuscar, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnMostrar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.dataUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataUser;
    }
}