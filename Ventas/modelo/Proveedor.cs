using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.modelo
{
    class Proveedor
    {
        private int id, clasificacion;
        private String nombre, direccion, razon, nit, email, telefono, registro, msg;

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

        public string Msg
        {
            get
            {
                return msg;
            }

            set
            {
                msg = value;
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

        public string Razon
        {
            get
            {
                return razon;
            }

            set
            {
                razon = value;
            }
        }

        public string Registro
        {
            get
            {
                return registro;
            }

            set
            {
                registro = value;
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
        /*para crear un nuevo proveedor*/
        public void insertar() {
            controlador.CrudProveedor prove = new controlador.CrudProveedor();
            if (prove.crearNuevoProve(this.nombre,this.direccion,this.razon,this.nit,this.email,this.telefono,this.registro,this.clasificacion).Equals(true)) {
                this.Msg = "Proveedor Creado";
            }
            else {
                this.Msg = "No se pudo crear el Proveedor";
                }

        }

        /*para actualizar un nuevo proveedor*/
        public void actualizar() {
            controlador.CrudProveedor prove = new controlador.CrudProveedor();
            if (prove.actuProve(this.id, this.nombre, this.direccion, this.razon, this.nit, this.email, this.telefono, this.registro).Equals(true))
            {
                this.msg = "Proveedor actualizado";
            }
            else {
                this.msg = "No se pudo actualizar el Proveedor";
            }

        }
    }
}
