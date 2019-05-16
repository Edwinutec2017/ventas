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
    public partial class BusquedaFact : form.FormBusquedafactura
    {
        private int id, rol,accion,idFact;
        private String nombre;
       
        public BusquedaFact()
        {
            InitializeComponent();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Ventas.Menu();
            menu.Id = this.id;
            menu.Nombre = this.nombre;
            menu.Rol = this.rol;
            menu.Show();

        }

        private void BusquedaFact_Load(object sender, EventArgs e)
        {
            if (this.accion.Equals(1))
            {
                lblTitulo.Text = "BUSQUEDA DE FACTURA";
                controlador.CrudFactura fact = new controlador.CrudFactura();
                fact.buscarFactura(1, "n", dataFact);
            }
            else {
                if (this.accion.Equals(3)) {
                    btnGuardar.Visible = false;
                    lblTitulo.Text = "DEVOLUCION DE FACTURA TOTAL";
                    controlador.CrudFactura fact = new controlador.CrudFactura();
                    fact.buscarFactura(1, "n", dataFact);
                }
                else {
                    if (this.accion.Equals(4) || this.accion.Equals(5))
                    {
                        btnEli.Visible = true;
                        btnActu.Visible = true;
                        btnEli.Enabled = false;
                        btnActu.Enabled = false;
                        lblTitulo.Text = "MANTENIMIENTO DE FACTURA";
                        controlador.CrudFactura fact = new controlador.CrudFactura();
                        fact.buscarFactura(1, "n", dataFact);
                    }
                    else {
                        if (this.accion.Equals(6))
                        {
                            btnDevDetalle.Enabled = false;
                            btnDevDetalle.Visible = true;
                            lblTitulo.Text = "DEVOLUCION X DETALLE ";
                            controlador.CrudFactura fact = new controlador.CrudFactura();
                            fact.buscarFactura(1, "n", dataFact);
                        }
                        else {
                            lblTitulo.Text = "BUSQUEDA DE DEVOLUCIONES";
                            controlador.CrudFactura fact = new controlador.CrudFactura();
                            fact.buscarFacturaDevolucion(1, "n", dataFact);
                        }
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.Equals(""))
            {
                MessageBox.Show("El Campo de Busqueda esta Vacio");
            }
            else {
                if (this.accion.Equals(1))
                {
                    /*BUSQUEDAS DE PRODUCTOS */
                    controlador.CrudFactura fact = new controlador.CrudFactura();
                    fact.buscarFactura(2, textBox9.Text, dataFact);
                }
                else
                {
                    if (this.accion.Equals(3))
                    {
                       
                        controlador.CrudFactura fact = new controlador.CrudFactura();
                        fact.buscarFactura(2, textBox9.Text, dataFact);
                    }
                    else
                    {
                        if (this.accion.Equals(4) || this.accion.Equals(5) || this.accion.Equals(6))
                        {
                            btnEli.Visible = true;
                            btnActu.Visible = true;
                            btnEli.Enabled = false;
                            btnActu.Enabled = false;
                            
                            controlador.CrudFactura fact = new controlador.CrudFactura();
                            fact.buscarFactura(2, textBox9.Text, dataFact);
                        }
                        else
                        {
                          /*BUSQUEDA DE DEVOLUCIONES */
                            controlador.CrudFactura fact = new controlador.CrudFactura();
                            fact.buscarFacturaDevolucion(2, textBox9.Text, dataFact);
                        }
                    }
                  
                }
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(1))
            {
                lblTitulo.Text = "BUSQUEDA DE FACTURA";
                controlador.CrudFactura fact = new controlador.CrudFactura();
                fact.buscarFactura(1, "n", dataFact);
            }
            else
            {
                if (this.accion.Equals(3))
                {
                    lblTitulo.Text = "DEVOLUCION DE FACTURA TOTAL";
                    controlador.CrudFactura fact = new controlador.CrudFactura();
                    fact.buscarFactura(1, "n", dataFact);
                }
                else
                {
                    if (this.accion.Equals(4) || this.accion.Equals(5))
                    {
                        lblTitulo.Text = "MANTENIMIENTO DE FACTURA";
                        controlador.CrudFactura fact = new controlador.CrudFactura();
                        fact.buscarFactura(1, "n", dataFact);
                    }
                    else
                    {
                        if (this.accion.Equals(6))
                        {
                            btnDevDetalle.Enabled = false;
                            btnDevDetalle.Visible = true;
                            lblTitulo.Text = "DEVOLUCION X DETALLE ";
                            controlador.CrudFactura fact = new controlador.CrudFactura();
                            fact.buscarFactura(1, "n", dataFact);
                        }
                        else
                        {
                            lblTitulo.Text = "BUSQUEDA DE DEVOLUCIONES";
                            controlador.CrudFactura fact = new controlador.CrudFactura();
                            fact.buscarFacturaDevolucion(1, "n", dataFact);
                        }
                    }
                }
            }
        }

        private void dataFact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (this.accion.Equals(4) || this.accion.Equals(5))
            {
                btnEli.Enabled = true;
                btnActu.Enabled = true;
            }
            else {
                if (this.accion.Equals(6)) {
                    btnImprimir.Visible = false;
                    btnDevDetalle.Enabled = true;
                } else {
                    btnImprimir.Visible = true;
                }

            }
            int i = dataFact.CurrentRow.Index;
            this.idFact = Convert.ToInt32(dataFact.Rows[i].Cells[0].Value.ToString());
           
            txtFact.Text=dataFact.Rows[i].Cells[1].Value.ToString();
            txtFecha.Text=dataFact.Rows[i].Cells[2].Value.ToString();
            txtCliente.Text= dataFact.Rows[i].Cells[3].Value.ToString();
            txtVende.Text= dataFact.Rows[i].Cells[4].Value.ToString();
           txtPago.Text= dataFact.Rows[i].Cells[5].Value.ToString();
            txtSub.Text="$"+ dataFact.Rows[i].Cells[6].Value.ToString();
            txtIva.Text="$ "+ dataFact.Rows[i].Cells[7].Value.ToString();
            txtTotal.Text= "$ "+ dataFact.Rows[i].Cells[8].Value.ToString();
            if (this.accion.Equals(3)) {
                btnGuardar.Visible = false;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            modelo.Factura fact = new modelo.Factura();
            try
            {
                DialogResult dialogo = MessageBox.Show("Decea aser la Devolucion ", "DEVOLUCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    
                   
                    fact.IdUser = this.idFact;
                    fact.devolucionTotal();
                    
                    
                   
                }
                else
                    return;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            if (fact.Mensaje.Equals("Devolucion correcta"))
            {
                MessageBox.Show(fact.Mensaje);

                lblTitulo.Text = "DEVOLUCION DE FACTURA TOTAL";
                controlador.CrudFactura dev = new controlador.CrudFactura();
                dev.buscarFactura(1, "n", dataFact);
            }
            else {
                MessageBox.Show(fact.Mensaje);
            }

        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(4)) {
                try
                {
                    DialogResult dialogo = MessageBox.Show("Dece eliminar Toda La factura", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (dialogo == DialogResult.Yes)
                    {
                        modelo.CambioCliente fact = new modelo.CambioCliente();
                        fact.Idfactura=this.idFact;
                        fact.elimFact();
                        if (fact.Msg.Equals("Factura eliminada")) {
                            MessageBox.Show(fact.Msg);

                         
                            controlador.CrudFactura fac = new controlador.CrudFactura();
                            fac.buscarFactura(1, "n", dataFact);
                        }
                        else {
                            MessageBox.Show(fact.Msg);
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

        private void btnActu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActuFactu actu = new ActuFactu();
            actu.Id = this.id;
            actu.Nombre = this.nombre;
            actu.Rol = this.rol;
            actu.Accion = this.accion;
            actu.IdFact = this.idFact;
            actu.Accion = 4;
            actu.Show();
           
        }

        private void btnDevDetalle_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActuFactu ac = new ActuFactu();
            ac.Id = this.id;
            ac.Nombre = this.nombre;
            ac.Rol = this.rol;
            ac.IdFact = this.idFact;
            ac.Accion = this.accion;
            ac.Show();
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
    }
}
