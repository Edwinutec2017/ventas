using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.modelo
{
    class Usuarios
    {

        private int accion;
        private int id;
        private String usuario;
        private String nombre;
        private String pass;
        private String mensaje;
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

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }

        controlador.CrudUser classuser = new controlador.CrudUser();

        /*para registro de  admin  y actualizar*/
        public void crearUser()
        {
            switch (accion)
            {
                case 1:
                    if (classuser.inserActuUser(accion, 1, this.usuario, this.nombre, this.pass).Equals(true))
                    {
                        mensaje = "Usuario registrado";

                    }
                    else
                    {
                        mensaje = "Usuario no registrado";
                    }

                    break;
                case 2:
                    if (classuser.inserActuUser(accion, 1, this.usuario, this.nombre, this.pass).Equals(true))
                    {
                        mensaje = "Usuario registrado";

                    }
                    else
                    {
                        mensaje = "Usuario no registrado";
                    }


                    break;
                case 3:

                    if (classuser.inserActuUser(accion, this.id, this.usuario, this.nombre, this.pass).Equals(true))
                    {
                        mensaje = "Usuario Actualizado";

                    }
                    else
                    {
                        mensaje = "Usuario no Actualizado";
                    }

                    break;

            }


        }

        /*para eliminar un registro */
        public void eliminarRegCambioEsta()
        {
            switch (accion)
            {
                case 4:
                    if (classuser.cambioEstadoRol(accion, this.id).Equals(true))
                    {
                        mensaje = "Usuario Eliminado";

                    }
                    else
                    {
                        mensaje = "Usuario no Eliminado";
                    }

                    break;
                case 5:
                    if (classuser.cambioEstadoRol(accion, this.id).Equals(true))
                    {
                        mensaje = "Usuario Se activo";

                    }
                    else
                    {
                        mensaje = "Usuario no se pudo Activar";
                    }


                    break;
                case 6:
                    if (classuser.cambioEstadoRol(accion, this.id).Equals(true))
                    {
                        mensaje = "Usuario Cambio de rol a Admin";

                    }
                    else
                    {
                        mensaje = "Usuario no Se pudo cambiar de rol";
                    }

                    break;
                case 7:
                    if (classuser.cambioEstadoRol(accion, this.id).Equals(true))
                    {
                        mensaje = "Usuario se cambio de Rol a Vendedor";

                    }
                    else
                    {
                        mensaje = "Usuario se pudo Cambiar de rol";
                    }

                    break;
            }

        }
    }
}
