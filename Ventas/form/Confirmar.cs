using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas.form
{


    public partial class Confirmar : Form
    {

        private int id, rol;
        private String nombre;
        /*para factura*/
        private int idCliente;
        private String nombreCliente = "";
        private String documento;
        private String Direccion;
        private String Telefono;
        private String tipo = "";
     
        /*para el numero de factura*/
        private String numeroFact;
        /*para el producto*/
        private Double subTotal = 0.0;
        private Double Iva = 0.0;
        private Double Total = 0.0;

        /*array de productos*/
        private List<int> idproducto = new List<int>();
        private List<String> Codigo = new List<string>();
        private List<String> nombreProducto = new List<string>();
        private List<int> cantidad = new List<int>();
        private List<Double> descuento = new List<double>();
        private List<Double> totalproducto = new List<double>();
        private List<Double> precioVenta = new List<double>();

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

        public string Documento
        {
            get
            {
                return documento;
            }

            set
            {
                documento = value;
            }
        }

        public string Direccion1
        {
            get
            {
                return Direccion;
            }

            set
            {
                Direccion = value;
            }
        }

        public string Telefono1
        {
            get
            {
                return Telefono;
            }

            set
            {
                Telefono = value;
            }
        }

        public string Tipo
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

        public List<string> Codigo1
        {
            get
            {
                return Codigo;
            }

            set
            {
                Codigo = value;
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

        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }

            set
            {
                nombreCliente = value;
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

        public Confirmar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Factura fac = new Factura();

            fac.Id = this.id;
            fac.Rol = this.Rol;
            fac.Nombre = this.nombre;
            fac.IdCliente = this.idCliente;
            fac.NombreCliente = this.nombreCliente;
            fac.Documento = this.documento;
            fac.Direccion1 = this.Direccion;
            fac.Telefono1 = this.Telefono;
            fac.Tipo = this.tipo;
            /*el detalle*/
            fac.NumeroFact = this.numeroFact;
            /*---*/
            fac.SubTotal = this.subTotal;
            fac.Iva1 = this.Iva;
            fac.Total1 = this.Total;
            /*----------------*/
            fac.Idproducto = this.idproducto;
            fac.Codigo1 = this.Codigo;
            fac.NombreProducto = this.nombreProducto;
            fac.Cantidad = this.cantidad;
            fac.Descuento = this.descuento;
            fac.Totalproducto = this.totalproducto;
            fac.PrecioVenta = this.precioVenta;
            fac.Show();
        }

        private void Confirmar_Load(object sender, EventArgs e)
        {

        }
    }
}
