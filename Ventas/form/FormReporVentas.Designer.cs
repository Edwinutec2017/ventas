namespace Ventas.form
{
    partial class FormReporVentas
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
            this.lblCod = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCod.Location = new System.Drawing.Point(91, 27);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(52, 15);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Codigo";
            this.lblCod.Click += new System.EventHandler(this.lblCod_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Ventas.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(13, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(46, 34);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(85, 52);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 21);
            this.txtCod.TabIndex = 2;
            this.txtCod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(13, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(227, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(221, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 21);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 80);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acccion";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Ventas.Properties.Resources.impresora;
            this.btnImprimir.Location = new System.Drawing.Point(358, 26);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(48, 43);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Ventas.Properties.Resources.db;
            this.button3.Location = new System.Drawing.Point(244, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 43);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Ventas.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(43, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 39);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(108, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(13, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 203);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(163, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "label4";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // FormReporVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(492, 485);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome);
            this.MinimizeBox = false;
            this.Name = "FormReporVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormReporVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblCod;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Button btnImprimir;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox3;
    }
}