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
    public partial class Inicio : form.Login
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {

                txtPassword.Focus();
                txtUsuario.Focus();
                MessageBox.Show("Campos Vacios");

            }
            else {
                modelo.InisioSeccion ini = new modelo.InisioSeccion();
                ini.Usuario = txtUsuario.Text;
                ini.Password = txtPassword.Text;
                ini.login();
                if (ini.Respuesta != null)
                {
                    if (ini.Respuesta.Equals("1"))
                    {
                      
                        this.Hide();
                        Menu admin = new Ventas.Menu();
                        admin.Id = ini.Iduser;
                        admin.Nombre = ini.Nombre;
                        admin.Rol = ini.RolUser;
                        admin.Show();
                      
                    }
                    else
                    {
                        if (ini.Respuesta.Equals("2"))
                        {
                            this.Hide();
                            Menu venta = new Ventas.Menu();
                            venta.Id = ini.Iduser;
                            venta.Nombre = ini.Nombre;
                            venta.Rol = ini.RolUser;
                            venta.Show();
                        }
                        else
                        {
                            MessageBox.Show("" + ini.Respuesta);
                            txtUsuario.Text = "";
                            txtPassword.Text = "";

                        }

                    }

                }

            }
        }
    }
}
