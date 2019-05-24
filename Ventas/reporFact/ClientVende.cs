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
    public partial class ClientVende : form.FormReporVentas
    {
        private int id, rol,accion;
        private String nombre;
        public ClientVende()
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

        private void ClientVende_Load(object sender, EventArgs e)
        {
            label3.Text = "Busqueda x Codigo";
            if (this.accion.Equals(1)) {
                controlador.CrudUser vend = new controlador.CrudUser();
                vend.datosUserVendedor(dataReport);
                lblTitulo.Text = "REPORTE DE VENTAS POR VENDEDOR";
            } else if (this.accion.Equals(2)) {
                controlador.CrudUser vend = new controlador.CrudUser();
                vend.datosCliente(dataReport);
                lblTitulo.Text = "REPORTE DE VENTAS POR CLIENTES";
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

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("No a dijitado nada");

            }
            else {
                if (this.accion.Equals(1))
                {
                    controlador.CrudUser vend = new controlador.CrudUser();
                    vend.datosUserVendedorBuscar(Convert.ToInt32(textBox3.Text),dataReport);
                 
                }
                else if (this.accion.Equals(2))
                {
                    controlador.CrudUser vend = new controlador.CrudUser();
                    vend.datosClienteBuscar(Convert.ToInt32(textBox3.Text), dataReport);
                    
                }
            }
        }

        private void dataReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnImprimir.Enabled = true;
            int i = dataReport.CurrentRow.Index;
            txtCod.Text = dataReport.Rows[i].Cells[0].Value.ToString();
            txtNombre.Text= dataReport.Rows[i].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (this.accion.Equals(1))
            {
                controlador.CrudUser vend = new controlador.CrudUser();
                vend.datosUserVendedor(dataReport);
         
            }
            else if (this.accion.Equals(2))
            {
                controlador.CrudUser vend = new controlador.CrudUser();
                vend.datosCliente(dataReport);
             
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(2)) {
                /*clientes*/
                controlador.GenerarXml xml = new controlador.GenerarXml();
                if (xml.generarFacCliente(Convert.ToInt32(txtCod.Text)))
                {
                    if (xml.generarArchivoRerpFacCliente())
                    {
                        MessageBox.Show("Reporte Generado....");
                        this.Hide();
                        reporFact.ReporFacCliente report = new reporFact.ReporFacCliente();
                        report.Id = this.id;
                        report.Nombre = this.nombre;
                        report.Rol = this.rol;
                        report.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se puede generar el reporte....");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede generar el reporte....");
                }
            } else if (this.accion.Equals(1)) {
                /*vendedor*/
                controlador.GenerarXml xml = new controlador.GenerarXml();
                if (xml.generarFacVendedor(Convert.ToInt32(txtCod.Text)))
                {
                    if (xml.generarArchivoRerpFacVendedor())
                    {
                        MessageBox.Show("Reporte Generado....");
                        this.Hide();
                        reporFact.FormFacVende report = new reporFact.FormFacVende();
                        report.Id = this.id;
                        report.Nombre = this.nombre;
                        report.Rol = this.rol;
                        report.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se puede generar el reporte....");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede generar el reporte....");
                }
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Ventas.Menu();
            menu.Id = this.Id;
            menu.Nombre = this.Nombre;
            menu.Rol = this.Rol;
            menu.Show();
        }
    }
}
