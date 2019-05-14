using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.modelo
{
    class Factura
    {

        private int idUser;
        /*para el cliente*/
        private int idCliente;
        private DateTime fecha;
        private int tipo;
        /*para el producto*/
        private Double subTotal;
        private Double Iva;
        private Double Total;
        private String numeroFact;
        private String mensaje;
        /*array de productos*/
        private List<int> idproducto = new List<int>();
        private List<String> nombreProducto = new List<string>();
        private List<int> cantidad = new List<int>();
        private List<Double> descuento = new List<double>();
        private List<Double> totalproducto = new List<double>();
        private List<Double> precioVenta = new List<double>();

        public int IdUser
        {
            get
            {
                return idUser;
            }

            set
            {
                idUser = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }



        public double SubTotal
        {
            get
            {
                return subTotal;
            }

            set
            {
                subTotal = value;
            }
        }

        public double Iva1
        {
            get
            {
                return Iva;
            }

            set
            {
                Iva = value;
            }
        }

        public double Total1
        {
            get
            {
                return Total;
            }

            set
            {
                Total = value;
            }
        }

        public string NumeroFact
        {
            get
            {
                return numeroFact;
            }

            set
            {
                numeroFact = value;
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

        public List<string> NombreProducto
        {
            get
            {
                return nombreProducto;
            }

            set
            {
                nombreProducto = value;
            }
        }

        public List<int> Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public List<int> Idproducto
        {
            get
            {
                return idproducto;
            }

            set
            {
                idproducto = value;
            }
        }

        public List<double> Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public List<double> Totalproducto
        {
            get
            {
                return totalproducto;
            }

            set
            {
                totalproducto = value;
            }
        }

        public List<double> PrecioVenta
        {
            get
            {
                return precioVenta;
            }

            set
            {
                precioVenta = value;
            }
        }

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }


        /*para insertar el encabezado de la factura*/
        public void insertEncabezado()
        {
            controlador.CrudFactura fac = new controlador.CrudFactura();

            if (fac.inserEncabezado(this.idCliente, this.numeroFact, this.idUser, this.tipo, this.subTotal, this.Iva, this.Total).Equals(true))
            {

                int id = idfac();
                if (inserDetalle(id).Equals(true))
                {
                    this.mensaje = "Factura Guardada";

                }
                else
                {
                    this.mensaje = "Detalle de la Factura No se pudo Guardar";

                }


            }
            else
            {
                this.mensaje = "No se  insertar la Factura";
            }

        }
        /*para buscar el id de la factura*/

        public int idfac()
        {
            controlador.CrudFactura fac = new controlador.CrudFactura();
            fac.idFactura(this.numeroFact);
            
            return fac.Idfac;
        }
        /*para crear el detalle de la factura*/

        public Boolean inserDetalle(int id)
        {
            
            Boolean a = false;

           
            controlador.CrudFactura fac = new controlador.CrudFactura();
            fac.Idfac = id;
            for (int i = 0; i < idproducto.Count; i++)
            {
               
                a = fac.inserDetalle(precioVenta[i], cantidad[i], descuento[i], totalproducto[i], idproducto[i]);


            }
            return a;
        }
        /*para aser la devolucion total de la factura*/
        public void devolucionTotal() {
            controlador.CrudFactura fact = new controlador.CrudFactura();
         
            if (fact.devolucionTotal(this.idUser).Equals(true)) {
                this.mensaje = "Devolucion correcta";
            }
            else {
                this.mensaje = "No se  iso la Devolucion";
            }

}

    }
}
