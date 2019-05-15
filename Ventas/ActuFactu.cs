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
    public partial class ActuFactu : form.FormFactura
    {
        private int id, rol, accion, idFact;
        private String nombre;
        public ActuFactu()
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
            BusquedaFact busqueda = new BusquedaFact();
            busqueda.Id = this.id;
            busqueda.Nombre = this.nombre;
            busqueda.Rol = this.rol;
            busqueda.Accion = this.accion;
            busqueda.IdFact = this.idFact;
            busqueda.Show();
        }

        private void groupEncabezado_Enter(object sender, EventArgs e)
        {

        }

        private void ActuFactu_Load(object sender, EventArgs e)
        {
           
            
            if (this.accion.Equals(4) || this.accion.Equals(5))
            {
                
                lblTitulo.Text = "MANTENIMIENTO DE FACTURA";
                
               
                //ppfact
                controlador.CrudFactura fac = new controlador.CrudFactura();
               
                fac.seleccionaPrtoducFact(this.idFact,dataProd);

                /*para traer el encabezado */
                modelo.CambioCliente cambio = new modelo.CambioCliente();
                cambio.seleEnfac(this.idFact);
                if (cambio.Msg.Equals("true"))
                {
                    txtFactura.Text = cambio.Factura;
                    txtVendedor.Text = cambio.Vendedor;
                    txtFecha.Text = cambio.Fecha;
                    txCodCliente.Text = cambio.CodCliente1.ToString();
                    txtNonbreCliente.Text = cambio.Cliente;
                    txtDocumento.Text = cambio.Dui;
                    txtDireccion.Text = cambio.Direccion;
                    txtTelefono.Text = cambio.Telefono;
                    txttipo.Text = cambio.NombreTipo;
                    txtSub.Text = cambio.Sub1.ToString();
                    txtIva.Text = cambio.Iva.ToString();
                    txtTotal.Text = cambio.Total.ToString();
                }
                else {
                    MessageBox.Show(cambio.Msg);
                }



            }
            else {
                btnProducto.Visible = false;
                btnCliente.Visible = false;
                lblTitulo.Text = "DEVOLUCION X DETALLE";

                //ppfact
                controlador.CrudFactura fac = new controlador.CrudFactura();

                fac.seleccionaPrtoducFact(this.idFact, dataProd);

                /*para traer el encabezado */
                modelo.CambioCliente cambio = new modelo.CambioCliente();
                cambio.seleEnfac(this.idFact);
                if (cambio.Msg.Equals("true"))
                {
                    txtFactura.Text = cambio.Factura;
                    txtVendedor.Text = cambio.Vendedor;
                    txtFecha.Text = cambio.Fecha;
                    txCodCliente.Text = cambio.CodCliente1.ToString();
                    txtNonbreCliente.Text = cambio.Cliente;
                    txtDocumento.Text = cambio.Dui;
                    txtDireccion.Text = cambio.Direccion;
                    txtTelefono.Text = cambio.Telefono;
                    txttipo.Text = cambio.NombreTipo;
                    txtSub.Text = cambio.Sub1.ToString();
                    txtIva.Text = cambio.Iva.ToString();
                    txtTotal.Text = cambio.Total.ToString();
                }
                else
                {
                    MessageBox.Show(cambio.Msg);
                }


            }
        }

        public int IdFact
        {
            get
            {
                return idFact;
            }

            set
            {
                idFact = value;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalle deta = new Detalle();
            deta.Id = this.id;
            deta.Rol = this.rol;
            deta.Nombre = this.nombre;
            deta.Idfact = this.IdFact;
            deta.Accion = 4;
            deta.Show();


        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalle deta = new Detalle();
            deta.Id = this.id;
            deta.Rol = this.rol;
            deta.Nombre = this.nombre;
            deta.Idfact = this.IdFact;
            deta.Accion = 5;
            deta.Sub = Convert.ToDouble(txtSub.Text);
            deta.Iva = Convert.ToDouble(txtIva.Text);
            deta.Total = Convert.ToDouble(txtTotal.Text);

            deta.Show();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.accion.Equals(6)) {
                try
                {
                    DialogResult dialogo = MessageBox.Show("Decea Quitar el producto de la Factura", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (dialogo == DialogResult.Yes)
                    {
                        int i = dataProd.CurrentRow.Index;
                    
                        
                        this.Hide();
                        form.Confirmar actu = new form.Confirmar();
                        actu.Id = this.id;
                        actu.Nombre = this.nombre;
                        actu.Rol = this.rol;
                        /*producto*/
                        actu.Accion = this.accion;
                        actu.ProducId = Convert.ToInt32(dataProd.Rows[i].Cells[0].Value.ToString());
                        actu.Show();

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
        public void ppfact() {
         
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
