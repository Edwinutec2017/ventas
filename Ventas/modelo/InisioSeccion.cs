using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.modelo
{
    class InisioSeccion
    {

        public InisioSeccion()
        {
        }

        private String usuario = "";
        private String password = "";
        private String nombre;
        private int iduser;
        private int rolUser;
        private String respuesta = null;
        private List<String> recibir = new List<string>();
        public string Usuario

        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
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

        public int Iduser
        {
            get
            {
                return iduser;
            }

            set
            {
                iduser = value;
            }
        }

        public string Respuesta
        {
            get
            {
                return respuesta;
            }

            set
            {
                respuesta = value;
            }
        }

        public int RolUser
        {
            get
            {
                return rolUser;
            }

            set
            {
                rolUser = value;
            }
        }

        /*validar usuario*/
        public void login()
        {
            controlador.CrudUser inicio = new controlador.CrudUser();

            recibir = inicio.validarLogin(this.usuario, this.password);
            Console.WriteLine(inicio.Msg);
            if (inicio.Msg.Equals(true))
            {
                Console.WriteLine(recibir);
                if (recibir != null)
                {
                    this.iduser = Convert.ToInt32(recibir[0]);
                    this.nombre = recibir[1];
                    this.rolUser = Convert.ToInt32(recibir[2]);

                    if (rolUser.Equals(1))
                    {
                        respuesta = "1";
                    }
                    else
                    {
                        respuesta = "2";
                    }
                }


            }
            else
            {
                Console.WriteLine(recibir + " mensaje " + inicio.Msg);
                respuesta = "No esta registrado o Inactivo";
            }


        }
    }
}
