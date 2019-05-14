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
    public partial class Clientes : form.FormCliente
    {
        private int id, rol,accion;
        private String nombre;
        public Clientes()
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

        private void Clientes_Load(object sender, EventArgs e)
        {
            if (this.accion.Equals(1))
            {
                todos();
                lblTitulo.Text = "REGISTRO DE  CLIENTES";
                lblDocu.Text = "DUI";
                lblEstado.Visible = false;
                txtEstado.Visible = false;
                lblId.Visible = false;
                txtId.Visible = false;
                lblClasificacion.Visible = false;
                txtClasifi.Visible = false;
                lblTipo.Visible = false;
                txtTipo.Visible = false;
                lblClasChe.Visible = false;
                chekPeque.Visible = false;
                chekMedi.Visible = false;
                chekGra.Visible = false;
                btnBuscar.Visible = false;
                lblBuscar.Visible = false;
                txtBuscar.Visible = false;
                btnEliminar.Visible = false;
                btnActualizar.Visible = false;
                btnTodos.Visible = false;

            }
            else {
                if (this.accion.Equals(2))
                {
                    todos();
                    lblTitulo.Text = "REGISTRO DE  CLIENTES";
                    lblDocu.Text = "# Registro";
                    lblEstado.Visible = false;
                    txtEstado.Visible = false;
                    lblId.Visible = false;
                    txtId.Visible = false;
                    lblClasificacion.Visible = false;
                    txtClasifi.Visible = false;
                    lblTipo.Visible = false;
                    txtTipo.Visible = false;
                    btnBuscar.Visible = false;
                    lblBuscar.Visible = false;
                    txtBuscar.Visible = false;
                    btnEliminar.Visible = false;
                    btnActualizar.Visible = false;
                    btnTodos.Visible = false;
                }
                else {
                    if (this.accion.Equals(3))
                    {
                        todos();
                        lblTitulo.Text = "MANTENIMIENTO DE  CLIENTES";
                        lblDocu.Text = "# DOCUMENTO";
                        txtEstado.Enabled = false;
                        txtId.Enabled = false;
                        txtClasifi.Enabled = false;
                        txtTipo.Enabled = false;
                        txtNumero.Enabled = false;
                        txtNit.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnActualizar.Enabled = false;
                        lblClasChe.Visible = false;
                        chekPeque.Visible = false;
                        chekMedi.Visible = false;
                        chekGra.Visible = false;
                        btnGuardar.Visible = false;
                    }
                    else {
                        lblTitulo.Text = "BUSQUEDA DE CLIENTES";
                        lblNombre.Visible = false;
                        txtNombre.Visible = false;
                        lblDocu.Visible = false;
                        txtNumero.Visible = false;
                        lblNit.Visible = false;
                        txtNit.Visible = false;
                        lblDireccion.Visible = false;
                        txtDirec.Visible = false;
                        lblEstado.Visible = false;
                        txtEstado.Visible = false;
                        lblTelefono.Visible = false;
                        txtTelefono.Visible = false;
                        lblCorreo.Visible = false;
                        txtCorreo.Visible = false;
                        lblId.Visible = false;
                        txtId.Visible = false;
                        lblTipo.Visible = false;
                        txtTipo.Visible = false;
                        lblClasificacion.Visible = false;
                        txtClasifi.Visible = false;
                        lblClasChe.Visible = false;
                        chekPeque.Visible = false;
                        chekMedi.Visible = false;
                        chekGra.Visible = false;
                        btnGuardar.Visible = false;
                        btnActualizar.Visible = false;
                        btnEliminar.Visible = false;
                        todos();
                    }

                }
            }
        }

        private void dataCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.accion.Equals(1) || this.accion.Equals(2))
            {

            }
            else {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                int i = dataCliente.CurrentRow.Index;
                txtId.Text = dataCliente.Rows[i].Cells[0].Value.ToString();
                txtNombre.Text = dataCliente.Rows[i].Cells[1].Value.ToString();
                txtNumero.Text = dataCliente.Rows[i].Cells[2].Value.ToString();
                txtNit.Text = dataCliente.Rows[i].Cells[3].Value.ToString();
                txtDirec.Text = dataCliente.Rows[i].Cells[4].Value.ToString();
                txtTelefono.Text = dataCliente.Rows[i].Cells[5].Value.ToString();
                txtCorreo.Text = dataCliente.Rows[i].Cells[6].Value.ToString();
                txtClasifi.Text = dataCliente.Rows[i].Cells[7].Value.ToString();
                txtEstado.Text = "Activo";

                String tipo = dataCliente.Rows[i].Cells[7].Value.ToString();
                if (tipo.Equals("Natural"))
                {
                    txtTipo.Text = "Natural";
                    lblDocu.Text = "DUI";
                }
                else
                {
                    txtTipo.Text = "Juridica";
                    lblDocu.Text = "# Registro";
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Equals("") || txtNumero.Text.Equals("") || txtNit.Text.Equals("") || txtDirec.Text.Equals("") || txtCorreo.Text.Equals("") || txtTelefono.Text.Equals(""))
            {

                MessageBox.Show("Tiene Canpos vacios");

            }
            else {
                modelo.Clientes cliente = new modelo.Clientes();
                if (this.accion.Equals(2))
                {
                    if (chekGra.Checked && chekMedi.Checked && chekPeque.Checked || chekPeque.Checked && chekMedi.Checked || chekPeque.Checked && chekGra.Checked || chekMedi.Checked && chekPeque.Checked || chekMedi.Checked && chekGra.Checked || chekGra.Checked&&chekPeque.Checked || chekGra.Checked&&chekMedi.Checked)
                    {

                        MessageBox.Show("Solo deve de seleccionar  un tipo de Clasificacion");
                    }
                    else {
                        cliente.Accion = 1;
                        cliente.Nombre = txtNombre.Text;
                        cliente.Dui = txtNumero.Text;
                        cliente.Nit = txtNit.Text;
                        cliente.Direccion = txtDirec.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Email = txtCorreo.Text;
                        if (chekPeque.Checked)
                        {
                            cliente.Clasificacion = 1;
                            chekPeque.Checked = false;
                        }
                        else if (chekMedi.Checked)
                        {
                            cliente.Clasificacion = 2;
                            chekMedi.Checked = false;
                        }
                        else
                        {
                            cliente.Clasificacion = 3;
                            chekGra.Checked = false;
                        }
                        cliente.TipoCliente1 = 2;
                        /*metodo de insertar*/
                        cliente.insertActua();
                        limpiar();
                        todos();

                        MessageBox.Show(cliente.Mensaje);

                    }

                }
                else {
                    cliente.Accion = 1;
                    cliente.Nombre = txtNombre.Text;
                    cliente.Dui = txtNumero.Text;
                    cliente.Nit = txtNit.Text;
                    cliente.Direccion = txtDirec.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Email = txtCorreo.Text;
                    cliente.Clasificacion = 4;
                    cliente.TipoCliente1 = 1;
                    /*metodo de insertar*/
                    cliente.insertActua();
                    limpiar();
                    todos();
                    MessageBox.Show(cliente.Mensaje);
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("Campo vacio no Dijito nada");

            }
            else {
                limpiar();
                controlador.CrudCliente client = new controlador.CrudCliente();
                client.selecClien(2, txtBuscar.Text, dataCliente);
                if (this.accion.Equals(4))
                {


                }
                else {
                    btnActualizar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            todos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Deve de seleccionar un registro de la Tabla");
            }
            else
            {
                modelo.Clientes cliente = new modelo.Clientes();
                cliente.Id = Convert.ToInt32(txtId.Text);
                cliente.eliminar();
                MessageBox.Show(cliente.Mensaje);
                limpiar();
                todos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("No tiene campos para actualizar");
            }
            else
            {
                modelo.Clientes clientes = new modelo.Clientes();
                clientes.Accion = 2;
                clientes.Id = Convert.ToInt32(txtId.Text);
                clientes.Nombre = txtNombre.Text;
                clientes.Dui = txtNumero.Text;
                clientes.Nit = txtNit.Text;
                clientes.Direccion = txtDirec.Text;
                clientes.Telefono = txtTelefono.Text;
                clientes.Email = txtCorreo.Text;

                clientes.insertActua();
                if (clientes.Mensaje.Equals("Cliente Actualizado"))
                {
                    MessageBox.Show(clientes.Mensaje);
                    limpiar();
                    todos();

                }
                else
                {
                    MessageBox.Show(clientes.Mensaje);
                }

            }

        }

        public void todos() {
            controlador.CrudCliente client = new controlador.CrudCliente();
            client.selecClien(1, "n", dataCliente);
            
        }

        public void limpiar() {
            txtId.Text = "";
            txtNombre.Text = "";
            txtNumero.Text = "";
            txtNit.Text = "";
            txtDirec.Text = "";
            txtEstado.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtTipo.Text = "";
            txtClasifi.Text = "";
        }
    }
}
