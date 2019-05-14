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
    public partial class Usuarios : form.FormUsuarios
    {
        private int id, rol, accion;
        private String nombre;
        public Usuarios()
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            todos();
        }
        public void todos() {
            controlador.CrudUser user = new controlador.CrudUser();
            user.datosUser(dataUser);
            limpiar();
        }
        public void limpiar() {
            txtId.Text = "";
            txtUser.Text = "";
            txtPassUser.Text = "";
            txtEstado.Text = "";
            txtNombre.Text = "";
            txtRol.Text = "";
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            if (this.accion.Equals(1))
            {
                todos();
                lblTitulo.Text = "REGISTRO DE  USUARIOS";
                lblId.Visible = false;
                txtId.Visible = false;
                lblEstado.Visible = false;
                txtEstado.Visible = false;
                lblRl.Visible = false;
                txtRol.Visible = false;
                lbBuscar.Visible = false;
                txtBuscar.Visible = false;
                btnBuscar.Visible = false;
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                btnMostrar.Visible = false;
                dataUser.Enabled = false;
            }
            else
            {
                lblTitulo.Text = "MANTENIMIENTO DE  USUARIOS";
                todos();
                txtId.Enabled = false;

                txtEstado.Enabled = false;

                txtRol.Enabled = false;
                txtUser.Enabled = false;
                txtBuscar.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                /*para cambiar si no es de  guardar */
                lblPass2.Visible = false;
                txtPassUser2.Visible = false;
                txtPassUser.PasswordChar.Equals("");
                lblRol.Visible = false;
                cheBoxAdmin.Visible = false;
                cheBoxVende.Visible = false;
                btnGuardar.Visible = false;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("Buscar x Usuario"))
            {
                txtBuscar.Enabled = true;
                txtBuscar.Text = "";
            }
            else
            {
                if (txtBuscar.Text.Equals(""))
                {
                    MessageBox.Show("No a dijitado el Usuario a Buscar");


                }
                else
                {

                    controlador.CrudUser user = new controlador.CrudUser();
                    user.datosBusqUser(dataUser, txtBuscar.Text);
                    txtBuscar.Enabled = false;
                    txtBuscar.Text = "Buscar por Usuarios";
                }

            }
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = "uno";
            int i;
            i = dataUser.CurrentRow.Index;
           
            txtId.Text = dataUser.Rows[i].Cells[0].Value.ToString();
            txtUser.Text = dataUser.Rows[i].Cells[1].Value.ToString();
            txtPassUser.Text = dataUser.Rows[i].Cells[2].Value.ToString();
            txtNombre.Text = dataUser.Rows[i].Cells[3].Value.ToString();
            txtRol.Text = dataUser.Rows[i].Cells[4].Value.ToString();
            txtEstado.Text = dataUser.Rows[i].Cells[5].Value.ToString();

            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtPassUser.Text.Equals(""))
            {

                MessageBox.Show("No se puede Actualizar No a selecciono un Registro");

            }
            else
            {

                modelo.Usuarios usermodelo = new modelo.Usuarios();
                /*para actualizar un registro */
                usermodelo.Accion = 3;
                usermodelo.Id = Convert.ToInt32(txtId.Text);
                usermodelo.Usuario = txtUser.Text;
                usermodelo.Nombre = txtNombre.Text;
                usermodelo.Pass = txtPassUser.Text;
                usermodelo.crearUser();
                MessageBox.Show(usermodelo.Mensaje);
                limpiar();
                todos();
                txtNombre.Enabled = false;
                txtPassUser.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtPassUser.Text.Equals(""))
            {

                MessageBox.Show("No se puede Eliminar No a selecciono un registro");

            }
            else
            {
                modelo.Usuarios deleteUser = new modelo.Usuarios();

                deleteUser.Accion = 4;
                deleteUser.Id = Convert.ToInt32(txtId.Text);
                deleteUser.eliminarRegCambioEsta();
                MessageBox.Show(deleteUser.Mensaje);
                limpiar();
                todos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cheBoxAdmin.Checked || cheBoxVende.Checked)
            {
                if (txtUser.Text.Equals("") || txtNombre.Text.Equals("") || txtPassUser.Text.Equals("") || txtPassUser2.Text.Equals(""))
                {
                    MessageBox.Show("Campos Vacios");
                    txtPassUser.Focus();
                    txtPassUser2.Focus();
                    txtNombre.Focus();
                    txtUser.Focus();

                }
                else
                {
                    if (cheBoxAdmin.Checked && cheBoxVende.Checked)
                    {
                        MessageBox.Show("Solo deve de seleccionar un Rol..");
                    }
                    else
                    {
                        if (txtPassUser.Text.Equals(txtPassUser2.Text))
                        {
                            modelo.Usuarios userReg = new modelo.Usuarios();

                            if (cheBoxAdmin.Checked)
                            {
                                modelo.Usuarios regUser = new modelo.Usuarios();
                                regUser.Accion = 1;
                                regUser.Usuario = txtUser.Text;
                                regUser.Nombre = txtNombre.Text;
                                regUser.Pass = txtPassUser.Text;
                                regUser.crearUser();
                                MessageBox.Show(regUser.Mensaje);
                                todos();
                                limpiar();
                                cheBoxAdmin.Checked = false;
                                txtPassUser2.Text = "";
                            }
                            else if (cheBoxVende.Checked)
                            {

                                modelo.Usuarios regUser = new modelo.Usuarios();
                                regUser.Accion = 2;
                                regUser.Usuario = txtUser.Text;
                                regUser.Nombre = txtNombre.Text;
                                regUser.Pass = txtPassUser.Text;
                                regUser.crearUser();
                                MessageBox.Show(regUser.Mensaje);
                                todos();
                                limpiar();
                                cheBoxVende.Checked = false;
                                txtPassUser2.Text = "";
                            }

                        }
                        else
                        {
                            MessageBox.Show("Contraseñas no son iguales");

                            txtPassUser2.Focus();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Campos vacios");

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
