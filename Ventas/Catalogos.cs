using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Catalogos : form.FormCatalogos
    {
        private int id, rol,accion;
        private String nombre;
        public Catalogos()
        {
            InitializeComponent();
        }

        public int Accion
        {
            get
            {
                return accion;
            }

            set
            {
                accion = value;
            }
        }

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Ventas.Menu();

            menu.Id = this.id;
            menu.Nombre = this.nombre;
            menu.Rol = this.rol;
            menu.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("No a dijitado El nombre del producto");
            }
            else {
                if (this.accion.Equals(1))
                {
                    controlador.SelecProduc sele = new controlador.SelecProduc();

                    sele.buscarProducto(1, txtBuscar.Text, dataProducCat);
                    txtBuscar.Text = "";
                }
                else
                {
                    controlador.SelecProduc sele = new controlador.SelecProduc();
                    sele.buscarProducto(2, txtBuscar.Text, dataProducCat);
                    txtBuscar.Text = "";
                }
            }
        }

        private void Catalogos_Load(object sender, EventArgs e)
        {
            if (this.accion.Equals(1)) {
                dataProducCat.Enabled = false;
                controlador.SelecProduc sele = new controlador.SelecProduc();
                sele.selecProducto(1, dataProducCat);
                lblTitulo.Text = "CATEGORIA PARTES";
            }
            else {
                dataProducCat.Enabled = false;
                controlador.SelecProduc sele = new controlador.SelecProduc();
                sele.selecProducto(2, dataProducCat);
                lblTitulo.Text = "CATEGORIA ACCESORIOS";
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(1))
            {
            
                controlador.SelecProduc sele = new controlador.SelecProduc();
                sele.selecProducto(1, dataProducCat);
                
            }
            else
            {
          
                controlador.SelecProduc sele = new controlador.SelecProduc();
                sele.selecProducto(2, dataProducCat);
             
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
    }
}
