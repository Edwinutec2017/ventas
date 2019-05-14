using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.modelo
{
    class Clientes
    {
        private int id;
        private String nombre;
        private String dui;
        private String nit;
        private String direccion;
        private String telefono;
        private String email;
        private int TipoCliente;
        private int clasificacion;
        private String mensaje;
        private int accion;
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

        public string Dui
        {
            get
            {
                return dui;
            }

            set
            {
                dui = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }



        public int Clasificacion
        {
            get
            {
                return clasificacion;
            }

            set
            {
                clasificacion = value;
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

        public int TipoCliente1
        {
            get
            {
                return TipoCliente;
            }

            set
            {
                TipoCliente = value;
            }
        }

        /*metodos*/

        /*para insertar y actualizar*/
        public void insertActua()
        {
            controlador.CrudCliente cliente = new controlador.CrudCliente();

            switch (this.accion)
            {
                case 1:
                    if (cliente.inserActuClien(this.accion, 1, this.nombre, this.dui, this.nit, this.direccion, this.telefono, this.email, this.TipoCliente1, this.clasificacion).Equals(true))
                    {
                        this.mensaje = "Cliente Registrado";
                    }
                    else
                    {

                        this.mensaje = "No se  pudo registrar el Cliente DUI ya existe";
                    }
                    break;

                case 2:
                    if (cliente.inserActuClien(this.accion, this.id, this.nombre, this.dui, this.nit, this.direccion, this.telefono, this.email, 1, 1).Equals(true))
                    {
                        this.mensaje = "Cliente Actualizado";
                    }
                    else
                    {
                        this.mensaje = "No se  pudo aser la transaccion";
                    }

                    break;

            }

        }


        /*para eliminar un registro*/

        public void eliminar()
        {
            controlador.CrudCliente cliente = new controlador.CrudCliente();

            if (cliente.eliminar(this.id).Equals(true))
            {
                this.mensaje = "Registro Eliminado";

            }
            else
            {
                this.mensaje = "Registro no Eliminado";
            }

        }
    }
}
