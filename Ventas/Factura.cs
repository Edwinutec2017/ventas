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
    public partial class Factura : form.FormFactura
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
        private DateTime fecha;
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

        public Factura()
        {
            fecha = DateTime.Now.Date;
            InitializeComponent();
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

        private void Factura_Load(object sender, EventArgs e)
        {
            dataventas.Columns.Add("num", "#");
            dataventas.Columns.Add("producto", "Codigo");
            dataventas.Columns.Add("producto", "Producto");
            dataventas.Columns.Add("precio", "Precio $");
            dataventas.Columns.Add("descuento", "Descuento %");
            dataventas.Columns.Add("cantidad", "Cantidad");
            dataventas.Columns.Add("total", "Total $");
            if (idproducto.Count.Equals(0))
            {
                btnGuardar.Enabled = false;

            }
            else
            {
                int con = 0;
                if (idproducto.Count <= 10)
                {
                    
                    btnGuardar.Enabled = true;
                    for (int i = 0; i < idproducto.Count; i++)
                    {
                        
                        con = con + 1;
                        dataventas.Rows.Add(con,Codigo[i], nombreProducto[i], precioVenta[i], descuento[i], cantidad[i], totalproducto[i]);
                       
                    }
                    txtSub.Text = "$ " + this.subTotal;
                    this.Iva = this.subTotal * 0.13;
                    this.Total = this.subTotal + this.Iva;
                    txtIva.Text = "$" + this.Iva;
                    txtTotal.Text = "$ " + this.Total;

                }
                else
                {
                    btnProducto.Enabled = false;
                    for (int i = 0; i < idproducto.Count; i++)
                    {

                        con = con + 1;
                        dataventas.Rows.Add(con, Codigo[i], nombreProducto[i], precioVenta[i], descuento[i], cantidad[i], totalproducto[i]);

                    }
                    txtSub.Text = "$ " + this.subTotal;
                    this.Iva = this.subTotal * 0.13;
                    this.Total = this.subTotal + this.Iva;
                    txtIva.Text = "$" + this.Iva;
                    txtTotal.Text = "$ " + this.Total;

                    MessageBox.Show("Limite de  items 10");
                }

            }
            if (this.tipo.Equals(""))
            {
                txttipo.Text = "";
                txtFecha.Text = fecha.ToString("dd/MM/yyyy");
                txtSub.Text = "$" + this.SubTotal;
                txtIva.Text = "$" + this.Iva1;
                txtTotal.Text = "$" + this.Total;
                btnProducto.Enabled = false;
                controlador.CrudFactura numero = new controlador.CrudFactura();
                numero.maximoFactura();
                txtFactura.Text = "No " + numero.Fac;
                if (numero.Fac.Equals(0))
                {
                    txtFactura.Text = "FA1";
                    this.numeroFact = "FA1";
                }
                else
                {
                    txtFactura.Text = "FA" + numero.Fac;
                    this.numeroFact = "FA" + numero.Fac;
                }

            }
            else
            {
                if (this.tipo.Equals("Natural"))
                {
                    lblDocumento.Text = "DUI";
                    btnProducto.Enabled = true;

                }
                else
                {

                    lblDocumento.Text = "# Registro";
                    btnProducto.Enabled = true;


                }


                txtFecha.Text = fecha.ToString("dd/MM/yyyy");
                txCodCliente.Text = Convert.ToString(this.idCliente);
                txtNonbreCliente.Text = this.nombreCliente;
                txtDocumento.Text = this.documento;
                txtDireccion.Text = this.Direccion;
                txtTelefono.Text = this.Telefono;
                txttipo.Text = this.tipo;
                txtVendedor.Text = this.nombre;
                Console.WriteLine("numero de fACTURA" + this.numeroFact);
                txtFactura.Text = this.numeroFact;

            }

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalle detalle = new Detalle();
            detalle.Id = this.id;
            detalle.Nombre = this.nombre;
            detalle.Rol = this.rol;
            detalle.Accion = 1;
            detalle.NumeroFact = this.numeroFact;
            detalle.IdCliente = this.idCliente;
            detalle.NombreCliente = this.nombreCliente;
            detalle.Documento = this.documento;
            detalle.Direccion1 = this.Direccion;
            detalle.Telefono1 = this.Telefono;
            detalle.Tipo = this.tipo;
            /*detalle */
            detalle.IdproductoVenta = this.idproducto;
            detalle.NombreProducto = this.nombreProducto;
            detalle.CantidadVendidad = this.cantidad;
            detalle.Descuento = this.descuento;
            detalle.PrecioVenta = this.precioVenta;
            detalle.Totalproducto = this.totalproducto;
            detalle.SubTotal = this.subTotal;
            detalle.Codigo1 = this.Codigo;
            detalle.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalle detalle = new Detalle();
            detalle.Id = this.id;
            detalle.Nombre = this.nombre;
            detalle.Rol = this.rol;
            /**/
            detalle.Accion = 2;
            detalle.NumeroFact = this.numeroFact;
            detalle.IdCliente = this.idCliente;
            detalle.NombreCliente = this.nombreCliente;
            detalle.Documento = this.documento;
            detalle.Direccion1 = this.Direccion;
            detalle.Telefono1 = this.Telefono;
            detalle.Tipo = this.tipo;
            /*detalle */
            detalle.IdproductoVenta = this.idproducto;
            detalle.NombreProducto = this.nombreProducto;
            detalle.CantidadVendidad = this.cantidad;
            detalle.Descuento = this.descuento;
            detalle.PrecioVenta = this.precioVenta;
            detalle.Totalproducto = this.totalproducto;
            detalle.SubTotal = this.subTotal;
            detalle.Codigo1 = this.Codigo;
            detalle.Show();
        }

        private void dataventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataventas.CurrentRow.Index;

            try {
                DialogResult dialogo = MessageBox.Show("Decea Quitar el producto de la Factura", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogo == DialogResult.Yes)
                {

                    Codigo.RemoveAt(i);
                    nombreProducto.RemoveAt(i);
                    precioVenta.RemoveAt(i);
                    descuento.RemoveAt(i);
                    cantidad.RemoveAt(i);
                    
                    Double tt = totalproducto[i];
                    Console.WriteLine("total eliminado"+tt);

                    totalproducto.RemoveAt(i);
                    subTotal = subTotal - tt;
                    Console.WriteLine("total eliminado" +subTotal);

                    Iva = subTotal * (13 / 100);
                    Total = subTotal + Iva;
                    idproducto.RemoveAt(i);

                    this.Hide();
                    form.Confirmar act = new form.Confirmar();
                    act.Id = this.id;
                    act.Rol = this.Rol;
                    act.Nombre = this.nombre;
                    act.IdCliente = this.idCliente;
                    act.NombreCliente = this.nombreCliente;
                    act.Documento = this.documento;
                    act.Direccion1 = this.Direccion;
                    act.Telefono1 = this.Telefono;
                    act.Tipo = this.tipo;
                    /*el detalle*/
                    act.NumeroFact = this.numeroFact;
                    /*---*/
                   act.SubTotal = this.subTotal;
                    act.Iva1 = this.Iva;
                    act.Total1 = this.Total;
                    /*----------------*/
                    act.Idproducto = this.idproducto;
                    act.Codigo1 = this.Codigo;
                    act.NombreProducto = this.nombreProducto;
                    act.Cantidad = this.cantidad;
                    act.Descuento = this.descuento;
                    act.Totalproducto = this.totalproducto;
                    act.PrecioVenta = this.precioVenta;
                    act.Show();
                }
                else
                    return;

            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            int seleccion = 0;
            if (chekEfectivo.Checked && chekCredito.Checked || chekCredito.Checked && chekEfectivo.Checked)
            {
                MessageBox.Show("Seleccione el tipo de pago");

            }
            else {
                if (chekEfectivo.Checked.Equals(false) && chekCredito.Checked.Equals(false) || chekCredito.Checked.Equals(false) && chekEfectivo.Checked.Equals(false))
                {
                    MessageBox.Show("Seleccione el tipo de pago");

                }
                else {
                    if (chekEfectivo.Checked)
                    {
                        seleccion = 7;
                    }
                    else
                    {
                        seleccion = 6;
                    }

                    modelo.Factura fat = new modelo.Factura();

                    /*para el encabezado de la factura*/
                    fat.IdCliente = this.idCliente;
                    fat.NumeroFact = txtFactura.Text;

                    fat.IdUser = this.id;
                    fat.Tipo = seleccion;
                    fat.SubTotal = this.subTotal;
                    fat.Iva1 = this.Iva;
                    fat.Total1 = this.Total;
                    fat.Fecha = this.fecha;

                    /*para el detalle de la factura*/
                    fat.PrecioVenta = this.precioVenta;
                    fat.Cantidad = this.cantidad;
                    fat.Descuento = this.descuento;
                    fat.Totalproducto = this.totalproducto;
                    fat.Idproducto = this.idproducto;

                    fat.insertEncabezado();

                    if (fat.Mensaje.Equals("Factura Guardada"))
                    {
                        MessageBox.Show(fat.Mensaje);
                        /*para aser la redireccion a imprimir la factura */

                    }
                    else
                    {
                        MessageBox.Show(fat.Mensaje);

                    }
                }

            }
        }
        public void eliminar(int id) {
            int idr = id - 1;

            Codigo.RemoveAt(idr);
            nombreProducto.RemoveAt(idr);
            precioVenta.RemoveAt(idr);
            descuento.RemoveAt(idr);
            cantidad.RemoveAt(idr);
            Double tt = totalproducto.IndexOf(idr);
            totalproducto.RemoveAt(idr);
            subTotal = subTotal - tt;
            Iva = subTotal * (13 / 100);
            Total = subTotal + Iva;
            idproducto.RemoveAt(idr);
            MessageBox.Show("cantidad del arrray "+ idproducto.Count);
            for (int i = 0; i < idproducto.Count; i++)
            {
                int c = 0;
                c = c + 1;
                dataventas.Rows.Add(c, Codigo[i], nombreProducto[i], precioVenta[i], descuento[i], cantidad[i], totalproducto[i]);

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
    }
}
