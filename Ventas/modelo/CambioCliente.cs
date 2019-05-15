using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.modelo
{
    class CambioCliente
    {
        private String factura, fecha, cliente, direccion, telefono, nombreTipo, dui,msg, vendedor;
        private int CodCliente,idfactura, idproducto, cantidad;
        private Double Sub, iva, total, descuento, totalproducto, precioVenta;

        public string Factura
        {
            get
            {
                return factura;
            }

            set
            {
                factura = value;
            }
        }

        public string Fecha
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

        public string Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
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

        public string NombreTipo
        {
            get
            {
                return nombreTipo;
            }

            set
            {
                nombreTipo = value;
            }
        }

        public int CodCliente1
        {
            get
            {
                return CodCliente;
            }

            set
            {
                CodCliente = value;
            }
        }

        public double Sub1
        {
            get
            {
                return Sub;
            }

            set
            {
                Sub = value;
            }
        }

        public double Iva
        {
            get
            {
                return iva;
            }

            set
            {
                iva = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
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

        public string Vendedor
        {
            get
            {
                return vendedor;
            }

            set
            {
                vendedor = value;
            }
        }

        public int Idfactura
        {
            get
            {
                return idfactura;
            }

            set
            {
                idfactura = value;
            }
        }

        public int Idproducto
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

        public int Cantidad
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

        public double Descuento
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

        public double Totalproducto
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

        public double PrecioVenta
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

        public void seleEnfac(int facId) {
            controlador.FacClienselect fac = new controlador.FacClienselect();
            if (fac.selecEnFact(facId).Equals(true))
            {
                this.fecha = fac.Fecha;
                this.factura = fac.Factura;
                this.CodCliente = fac.CodCliente1;
                this.cliente = fac.Cliente;
                this.dui = fac.Dui;
                this.Direccion = fac.Direccion;
                this.telefono = fac.Telefono;
                this.Sub = fac.Sub1;
                this.iva = fac.Iva;
                this.total = fac.Total;
                this.vendedor = fac.Vendedor;
                this.NombreTipo = fac.NombreTipo;
              
                this.msg = "true";
            }
            else {
                this.msg = "Cliente no se pudo encontrar";
            }

        }
        /*para eliminar la factura  es cambio de estado*/
        public void elimFact()
        {
            controlador.FacClienselect fac = new controlador.FacClienselect();
            if (fac.elimFact(this.idfactura).Equals(true))
            {
                this.msg = "Factura eliminada";
            }
            else {
                this.msg = "factura NO eliminada";
            }

        }
        /*para cambio de cliente */
        public void facCamClien() {
            controlador.FacClienselect fac = new controlador.FacClienselect();
            if (fac.cambioCliente(this.idfactura, this.CodCliente).Equals(true))
            {
                this.msg = "CLIENTE CAMBIADO";
            }
            else
            {
                this.msg = "NO se pudo cambiar el Cliente";
            }


        }

        public void cambioTotal() {
            controlador.FacClienselect f = new controlador.FacClienselect();
            if (f.cambioTotalFact(this.Sub,this.iva,this.total,this.idfactura).Equals(true)) {

                controlador.CrudFactura f2 = new controlador.CrudFactura();
                f2.Idfac = this.idfactura;
                if (f2.inserDetalle(this.precioVenta,this.cantidad,this.descuento,this.totalproducto,this.idproducto).Equals(true)) {
                    this.msg = "Producto agregado";
                } else {
                    this.msg = "No se Agrego detalle";
                }

            } else {
                this.msg = "No se Agrego";

            }


        }

    }
}
