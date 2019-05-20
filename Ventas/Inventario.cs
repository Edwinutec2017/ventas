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
    public partial class Inventario : form.FormAgregarProductoInve
    {
        private int id, rol, accion, idproduc, cantidad;
        private String nombre;
        public Inventario()
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

        private void Inventario_Load(object sender, EventArgs e)
        {
            if (this.accion.Equals(1)) {
                txtNombre.Enabled = false;
                controlador.CrudProducto produc = new controlador.CrudProducto();
                produc.invetCero(dataInve);
            } else if (this.accion.Equals(2)) {
                txtNombre.Enabled = false;
                controlador.CrudProducto produc = new controlador.CrudProducto();
                produc.invetMayoraCero(dataInve);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("")) {
                MessageBox.Show("No dijito Codigo de Producto");
            } else if (this.accion.Equals(1)) {
                controlador.CrudProducto produc = new controlador.CrudProducto();
                produc.buscadorInvet(1, txtBuscar.Text, dataInve);
            } else if (this.accion.Equals(2)) {
                controlador.CrudProducto produc = new controlador.CrudProducto();
                produc.buscadorInvet(2, txtBuscar.Text, dataInve);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(1))
            {
                controlador.CrudProducto produc = new controlador.CrudProducto();
                produc.invetCero(dataInve);
            }
            else if (this.accion.Equals(2))
            {
                controlador.CrudProducto produc = new controlador.CrudProducto();
                produc.invetMayoraCero(dataInve);
            }
        }

        private void dataInve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataInve.CurrentRow.Index;
            this.idproduc= Convert.ToInt32(dataInve.Rows[i].Cells[0].Value.ToString());
            txtNombre.Text=dataInve.Rows[i].Cells[2].Value.ToString();
            this.cantidad = Convert.ToInt32(dataInve.Rows[i].Cells[4].Value.ToString());

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")) {
                MessageBox.Show("Deve se selecionar el Registro de la Tabla");
            } else if (tctCantidad.Text.Equals("")) {
                MessageBox.Show("No a dijitado la cantidad");
            }
            else{
                try
                {
                    DialogResult dialogo = MessageBox.Show("Decea Aumentar La cantidad del Invetario del Producto", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (dialogo == DialogResult.Yes)
                    {
                        this.cantidad = this.cantidad + Convert.ToInt32(tctCantidad.Text);
                        controlador.CrudProducto produc = new controlador.CrudProducto();
                        if (produc.actuInve(this.idproduc, this.cantidad))
                        {
                            MessageBox.Show("Inventario Aumentado");
                            
                            produc.invetCero(dataInve);
                        }
                        else {
                            MessageBox.Show("Transaccion fallida");
                        }

                    }
                    else
                        return;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Deve se selecionar el Registro de la Tabla");
            }
            else if (tctCantidad.Text.Equals(""))
            {
                MessageBox.Show("No a dijitado la cantidad");
            }
            else
            {
                try
                {
                    DialogResult dialogo = MessageBox.Show("Decea Disminuir La cantidad del Invetario del Producto", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (dialogo == DialogResult.Yes)
                    {
                        this.cantidad = this.cantidad - Convert.ToInt32(tctCantidad.Text);
                        controlador.CrudProducto produc = new controlador.CrudProducto();
                        if (produc.actuInve(this.idproduc, this.cantidad))
                        {
                            MessageBox.Show("Inventario Disminuido");
                         
                            produc.invetMayoraCero(dataInve);
                        }
                        else
                        {
                            MessageBox.Show("Transaccion fallida");
                        }

                    }
                    else
                        return;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

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

        public int Idproduc
        {
            get
            {
                return idproduc;
            }

            set
            {
                idproduc = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
    }
}
