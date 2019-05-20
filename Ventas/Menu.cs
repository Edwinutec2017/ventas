﻿using System;
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
    public partial class Menu : Form
    {
        private int id,rol;
        private String nombre;
        
        public Menu()
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

        private void Menu_Load(object sender, EventArgs e)
        {

            if (this.rol.Equals(2))
            {
                lblInicio.Text = "BIENVENIDO/A " + this.nombre;
                crearUsuariosToolStripMenuItem.Enabled = false;
                manteClienteToolStripMenuItem.Enabled = false;
                manteUsuariosToolStripMenuItem.Enabled = false;
                mantenimientoFacturaToolStripMenuItem.Enabled = false;
            }
            else {
                lblInicio.Text = "BIENVENIDO/A " + this.nombre;
            }
            

        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios user = new Usuarios();
            user.Id = this.id;
            user.Nombre = this.nombre;
            user.Rol = this.rol;
            user.Accion = 1;
            user.Show();
        }

        private void manteUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios user = new Usuarios();
            user.Id = this.id;
            user.Nombre = this.nombre;
            user.Rol = this.rol;
            user.Accion = 2;
            user.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogos cat = new Catalogos();
            cat.Id = this.id;
            cat.Nombre = this.nombre;
            cat.Rol = this.rol;
            cat.Accion = 1;
            cat.Show();
        }

        private void accesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogos cat = new Catalogos();
            cat.Id = this.id;
            cat.Nombre = this.nombre;
            cat.Rol = this.rol;
            cat.Accion = 2;
            cat.Show();
        }

        private void nATURAKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void naturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.Id = this.id;
            cliente.Nombre = this.nombre;
            cliente.Rol = this.rol;
            cliente.Accion = 1;
            cliente.Show();

        }

        private void juridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.Id = this.id;
            cliente.Nombre = this.nombre;
            cliente.Rol = this.rol;
            cliente.Accion = 2;
            cliente.Show();
        }

        private void manteClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.Id = this.id;
            cliente.Nombre = this.nombre;
            cliente.Rol = this.rol;
            cliente.Accion = 3;
            cliente.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.Id = this.id;
            cliente.Nombre = this.nombre;
            cliente.Rol = this.rol;
            cliente.Accion = 4;
            cliente.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Factura fact = new Factura();
            fact.Id = this.id;
            fact.Nombre = this.nombre;
            fact.Rol = this.rol;
            fact.Show();
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaFact fact = new BusquedaFact();
            fact.Id = this.id;
            fact.Nombre = this.nombre;
            fact.Rol = this.rol;
            fact.Accion = 1;
            fact.Show();

        }

        private void buscarDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaFact fact = new BusquedaFact();
            fact.Id = this.id;
            fact.Nombre = this.nombre;
            fact.Rol = this.rol;
            fact.Accion = 2;
            fact.Show();
        }
        
        private void devolucionFacturaTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaFact fact = new BusquedaFact();
            fact.Id = this.id;
            fact.Nombre = this.nombre;
            fact.Rol = this.rol;
            fact.Accion = 3;
            fact.Show();
        }
        private void mantenimientoFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaFact fact = new BusquedaFact();
            fact.Id = this.id;
            fact.Nombre = this.nombre;
            fact.Rol = this.rol;
            fact.Accion = 4;
            fact.Show();
        }
        private void reporteDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
       


        }

        private void devolucionXDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaFact fact = new BusquedaFact();
            fact.Id = this.id;
            fact.Nombre = this.nombre;
            fact.Rol = this.rol;
            fact.Accion = 6;
            fact.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportVentas reporteVenta = new ReportVentas();
            reporteVenta.Id = this.id;
            reporteVenta.Nombre = this.nombre;
            reporteVenta.Rol = this.rol;
            reporteVenta.Show();
           
        }

        private void devolucionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportDevolucion devolucion = new ReportDevolucion();
            devolucion.Id = this.id;
            devolucion.Nombre = this.nombre;
            devolucion.Rol = this.rol;
            devolucion.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportProductosPartes repart = new ReportProductosPartes();
            repart.Id = this.id;
            repart.Nombre = this.nombre;
            repart.Rol = this.rol;
            repart.Show();
        }

        private void accesoriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportProductosAccesorios repart = new ReportProductosAccesorios();
            repart.Id = this.id;
            repart.Nombre = this.nombre;
            repart.Rol = this.rol;
            repart.Show();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void naturalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedor prove = new Proveedor();
            prove.Id = this.id;
            prove.Nombre = this.nombre;
            prove.Rol = this.rol;
            prove.Accion = 1;
            prove.Show();
        }

        private void juridicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedor prove = new Proveedor();
            prove.Id = this.id;
            prove.Nombre = this.nombre;
            prove.Rol = this.rol;
            prove.Accion = 2;
            prove.Show();
        }

        private void buscarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedor prove = new Proveedor();
            prove.Id = this.id;
            prove.Nombre = this.nombre;
            prove.Rol = this.rol;
            prove.Accion = 3;
            prove.Show();
        }

        private void mantenimientoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedor prove = new Proveedor();
            prove.Id = this.id;
            prove.Nombre = this.nombre;
            prove.Rol = this.rol;
            prove.Accion = 4;
            prove.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos produc = new Productos();
            produc.Id = this.id;
            produc.Nombre = this.nombre;
            produc.Rol = this.rol;
            produc.Accion = 1;
            produc.Show();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos produc = new Productos();
            produc.Id = this.id;
            produc.Nombre = this.nombre;
            produc.Rol = this.rol;
            produc.Accion = 2;
            produc.Show();
        }

        private void mnatenimentoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos produc = new Productos();
            produc.Id = this.id;
            produc.Nombre = this.nombre;
            produc.Rol = this.rol;
            produc.Accion = 3;
            produc.Show();
        }

        private void agregarAInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void productoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inv = new Inventario();
            inv.Id = this.id;
            inv.Nombre = this.nombre;
            inv.Rol = this.rol;
            inv.Accion = 1;
            inv.Show();
               
        }

        private void productoExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inv = new Inventario();
            inv.Id = this.id;
            inv.Nombre = this.nombre;
            inv.Rol = this.rol;
            inv.Accion = 2;
            inv.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio ini = new Inicio();
            ini.Show();
        }
    }
}
