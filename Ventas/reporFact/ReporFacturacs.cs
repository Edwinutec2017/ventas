using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas.reporFact
{
    public partial class ReporFacturacs : form.FormRepor
    {
        private int id, rol;
        private String nombre;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

       

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }

        public ReporFacturacs()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            
        }

        private void ReporFacturacs_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Impresion de Factura";
            CrystalFactura1.Refresh();


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Ventas.Menu();
            menu.Id = this.id;
            menu.Nombre = this.nombre;
            menu.Rol = this.Rol;
            menu.Show();

        }
    }
}
