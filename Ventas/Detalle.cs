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
    public partial class Detalle : form.FormDetalle
    {
        private int id, rol,accion,cantidad=0,idfact;
        private String nombre,cod;

        /**/
        private int idCliente;
        private String nombreCliente;
        private String documento;
        private String Direccion;
        private String Telefono;
        private String tipo = "";
        /**/
        private String numeroFact;
        /*para la factura*/
        private Double sub,iva,total;
        /*array de productos*/
        private List<String> Codigo = new List<string>();
        private List<int> idproductoVenta = new List<int>();
        private List<String> nombreProducto = new List<string>();
        private List<int> cantidadVendidad = new List<int>();
        private List<Double> descuento = new List<double>();
        private List<Double> totalproducto = new List<double>();
        private List<Double> precioVenta = new List<double>();
        private Double subTotal = 0.0;
        /*------------------------------*/
        public Detalle()
        {
            InitializeComponent();
        }

       
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (Accion.Equals(1))
            {
                this.Hide();
                /*encabezado factura*/
                Factura fac = new Factura();
                fac.Id = this.id;
                fac.Nombre = this.nombre;
                fac.Rol = this.rol;

                /*encabezado*/
                fac.IdCliente = this.idCliente;
                fac.NombreCliente = this.nombreCliente;
                fac.Documento = this.documento;
                fac.Direccion1 = this.Direccion;
                fac.Telefono1 = this.Telefono;
                fac.Tipo = this.tipo;
                fac.NumeroFact = this.numeroFact;
                fac.Codigo1 = this.Codigo;
                /*detalle*/
                fac.Idproducto = this.idproductoVenta;
                fac.NombreProducto = this.nombreProducto;
                fac.Cantidad = this.cantidadVendidad;
                fac.Descuento = this.descuento;
                fac.PrecioVenta = this.precioVenta;
                fac.Totalproducto = this.totalproducto;
                fac.SubTotal = this.subTotal;
                fac.Show();

            }
            else
            {
                if (this.accion.Equals(4)) {
                    this.Hide();
                    ActuFactu actu = new ActuFactu();
                    actu.Id = this.id;
                    actu.Nombre = this.nombre;
                    actu.Rol = this.rol;
                    actu.IdFact = this.idfact;
                    actu.Accion = this.accion;
                    actu.Show();
                }
                else {
                    if (this.accion.Equals(5))
                    {
                        this.Hide();
                        ActuFactu actu = new ActuFactu();
                        actu.Id = this.id;
                        actu.Nombre = this.nombre;
                        actu.Rol = this.rol;
                        actu.IdFact = this.idfact;
                        actu.Accion = this.accion;
                        actu.Show();
                    }
                    else {
                        this.Hide();
                        /*encabezado factura*/
                        Factura fac = new Factura();
                        fac.Id = this.id;
                        fac.Nombre = this.nombre;
                        fac.Rol = this.rol;

                        /*encabezado*/
                        fac.IdCliente = this.idCliente;
                        fac.NombreCliente = this.nombreCliente;
                        fac.Documento = this.documento;
                        fac.Direccion1 = this.Direccion;
                        fac.Telefono1 = this.Telefono;
                        fac.Tipo = this.tipo;
                        fac.NumeroFact = this.numeroFact;
                        fac.Codigo1 = this.Codigo;
                        /*detalle*/
                        fac.Idproducto = this.idproductoVenta;
                        fac.NombreProducto = this.nombreProducto;
                        fac.Cantidad = this.cantidadVendidad;
                        fac.Descuento = this.descuento;
                        fac.PrecioVenta = this.precioVenta;
                        fac.Totalproducto = this.totalproducto;
                        fac.SubTotal = this.subTotal;
                        fac.Show();
                    }
                }
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = data.CurrentRow.Index;
            if (this.accion.Equals(1) || this.accion.Equals(4))
            {
                txtCodigo.Text = data.Rows[i].Cells[0].Value.ToString();
                txtNombre.Text = data.Rows[i].Cells[1].Value.ToString();
                txtCantidad.Text = data.Rows[i].Cells[2].Value.ToString();
                txtPrecio.Text = data.Rows[i].Cells[3].Value.ToString();
                txtDecuento.Text = data.Rows[i].Cells[4].Value.ToString();
                txtTipo.Text= data.Rows[i].Cells[5].Value.ToString();
                btnAgregar.Enabled = true;
            }
            else {
                
                txtDecuento.Enabled = true;
                txtCantidad.Enabled = true;
                lblTipo.Visible = false;
                txtTipo.Visible = false;
                txtCodigo.Text = data.Rows[i].Cells[0].Value.ToString();
                this.cod= data.Rows[i].Cells[1].Value.ToString();
                txtNombre.Text = data.Rows[i].Cells[2].Value.ToString();
                txtPrecio.Text = data.Rows[i].Cells[3].Value.ToString();
               this.cantidad = Convert.ToInt32(data.Rows[i].Cells[4].Value.ToString());
                btnAgregar.Enabled = true;
            }
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Accion.Equals(1))
            {
                this.Hide();
                /*encabezado factura*/
                Factura fac = new Factura();
                fac.Id = this.id;
                fac.Nombre = this.nombre;
                fac.Rol = this.rol;

                /*encabezado*/
                fac.IdCliente = Convert.ToInt32(txtCodigo.Text);
                fac.NombreCliente = txtNombre.Text;
                fac.Documento = txtCantidad.Text;
                fac.Direccion1 = txtPrecio.Text;
                fac.Telefono1 = txtDecuento.Text;
                fac.Tipo = txtTipo.Text;
                fac.NumeroFact = this.numeroFact;
                /*detalle*/
                fac.Idproducto = this.idproductoVenta;
                fac.NombreProducto = this.nombreProducto;
                fac.Cantidad = this.cantidadVendidad;
                fac.Descuento = this.descuento;
                fac.PrecioVenta = this.precioVenta;
                fac.Totalproducto = this.totalproducto;
                fac.SubTotal = this.subTotal;
                fac.Codigo1 = this.Codigo;
                fac.Show();

            }
            else
            {
                if (this.accion.Equals(4))
                {/*cambio de cliente */
                    if (txtCodigo.Text.Equals("")) {
                        MessageBox.Show("Seleccione el cliente nuevo");
                    } else {
                       
                        try
                        {
                            DialogResult dialogo = MessageBox.Show("Decea Cambiar de Cliente", "Cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogo == DialogResult.Yes)
                            {
                                modelo.CambioCliente cc = new modelo.CambioCliente();
                                cc.Idfactura = this.idfact;
                                
                                cc.CodCliente1 = Convert.ToInt32(txtCodigo.Text);
                                cc.facCamClien();
                                if (cc.Msg.Equals("Se cambio el cliente"))
                                {
                                    MessageBox.Show(cc.Msg);
                                  

                                }
                                else
                                {
                                    MessageBox.Show(cc.Msg);
                                }


                            }
                            else
                           
                            return;

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        this.Hide();
                        ActuFactu ff = new ActuFactu();
                        ff.IdFact = this.idfact;
                        ff.Accion = this.accion;
                        ff.Show();
                    }



                }
                else {
                    if (txtDecuento.Text.Equals("") || txtCantidad.Text.Equals(""))
                    {
                        MessageBox.Show("Dijite la cantidad y el Descuento");
                    }
                    else
                    {
                        int p = Convert.ToInt32(txtCantidad.Text);

                        if (p > cantidad)
                        {

                            MessageBox.Show("La cantidad ingresada es mayor a la que ay en el Inventario");

                        }
                        else
                        {
                            if (this.accion.Equals(5))
                            {

                                try
                                {
                                    DialogResult dialogo = MessageBox.Show("Decea Agregar el Producto", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogo == DialogResult.Yes)
                                    {
                                        /*para actualizar la factura */
                                        modelo.CambioCliente ccc = new modelo.CambioCliente();
                                        ccc.Idfactura = this.idfact;
                                        ccc.Idproducto = Convert.ToInt32(txtCodigo.Text);
                                        ccc.PrecioVenta = Convert.ToDouble(txtPrecio.Text);
                                        ccc.Cantidad = Convert.ToInt32(txtCantidad.Text);
                                        ccc.Descuento = Convert.ToDouble(txtDecuento.Text);
                                        Double s, d, dd;
                                        d = Convert.ToDouble(txtDecuento.Text) / 100;
                                        s = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                                        
                                        dd = s * d;
                                        s = s - dd;
                                       
                                        ccc.Totalproducto = s;

                                        this.sub = this.sub + s;
                                        this.iva = this.sub * 0.13;
                                        this.total = this.sub + this.iva;

                                        ccc.Sub1 = this.sub;
                                        ccc.Iva = this.iva;
                                        ccc.Total = this.total;
                                        ccc.cambioTotal();

                                        if (ccc.Msg.Equals("Producto agregado "))
                                        {
                                        
                                            MessageBox.Show(ccc.Msg);


                                        }
                                        else
                                        {
                                            MessageBox.Show(ccc.Msg);
                                        }


                                    }
                                    else

                                        return;

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                }
                                this.Hide();
                                ActuFactu ff = new ActuFactu();
                                ff.IdFact = this.idfact;
                                ff.Accion = this.accion;
                                ff.Show();

                            }
                            else {
                                int con = idproductoVenta.Count;

                                if (con.Equals(0))
                                {

                                    idproductoVenta.Add(Convert.ToInt32(txtCodigo.Text));
                                    nombreProducto.Add(txtNombre.Text);
                                    CantidadVendidad.Add(Convert.ToInt32(txtCantidad.Text));
                                    Double desc = Convert.ToDouble(txtDecuento.Text) / 100;
                                    descuento.Add(Convert.ToDouble(txtDecuento.Text));

                                    PrecioVenta.Add(Convert.ToDouble(txtPrecio.Text));

                                    Double tott = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);

                                    Double dessprod = tott * desc;
                                    tott = tott - dessprod;
                                    this.subTotal = subTotal + tott;
                                    totalproducto.Add(tott);
                                    Codigo.Add(cod);

                                    this.Hide();
                                    Factura factu = new Factura();
                                    factu.Id = this.id;
                                    factu.Nombre = this.nombre;
                                    factu.Rol = this.rol;
                                    factu.Idproducto = this.idproductoVenta;
                                    factu.NombreProducto = this.nombreProducto;
                                    factu.Cantidad = this.cantidadVendidad;
                                    factu.Descuento = this.descuento;
                                    factu.PrecioVenta = this.precioVenta;
                                    factu.Totalproducto = this.totalproducto;
                                    factu.SubTotal = this.subTotal;
                                    factu.Codigo1 = this.Codigo;
                                    /*par el cliente*/
                                    factu.IdCliente = this.idCliente;
                                    factu.NombreCliente = this.nombreCliente;
                                    factu.Documento = this.documento;
                                    factu.Direccion1 = this.Direccion;
                                    factu.Telefono1 = this.Telefono;
                                    factu.Tipo = this.tipo;
                                    /*la factura*/
                                    factu.NumeroFact = this.numeroFact;
                                    factu.Show();

                                }
                                else
                                {
                                    Codigo.Add(cod);

                                    idproductoVenta.Add(Convert.ToInt32(txtCodigo.Text));
                                    nombreProducto.Add(txtNombre.Text);
                                    CantidadVendidad.Add(Convert.ToInt32(txtCantidad.Text));
                                    Double desc = Convert.ToDouble(txtDecuento.Text) / 100;

                                    descuento.Add(Convert.ToDouble(txtDecuento.Text));
                                    PrecioVenta.Add(Convert.ToDouble(txtPrecio.Text));
                                    Double tott = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                                    this.subTotal = subTotal + tott;

                                    Totalproducto.Add(tott);

                                    this.Hide();
                                    Factura factu = new Factura();
                                    factu.Id = this.id;
                                    factu.Nombre = this.nombre;
                                    factu.Rol = this.rol;
                                    factu.Idproducto = this.idproductoVenta;
                                    factu.NombreProducto = this.nombreProducto;
                                    factu.Cantidad = this.cantidadVendidad;
                                    factu.Descuento = this.descuento;
                                    factu.PrecioVenta = this.precioVenta;
                                    factu.Totalproducto = this.totalproducto;
                                    factu.SubTotal = this.subTotal;
                                    factu.Codigo1 = this.Codigo;
                                    /*par el cliente*/
                                    factu.IdCliente = this.idCliente;
                                    factu.NombreCliente = this.nombreCliente;
                                    factu.Documento = this.documento;
                                    factu.Direccion1 = this.Direccion;
                                    factu.Telefono1 = this.Telefono;
                                    factu.Tipo = this.tipo;
                                    factu.NumeroFact = this.numeroFact;
                                    factu.Show();

                                }
                            }

                        }

                    }
                }
            }
        }

        public int Rol
        {
            get
            {
                return Rol1;
            }

            set
            {
                Rol1 = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return IdCliente1;
            }

            set
            {
                IdCliente1 = value;
            }
        }

        public string Telefono1
        {
            get
            {
                return Telefono2;
            }

            set
            {
                Telefono2 = value;
            }
        }

        public string Direccion1
        {
            get
            {
                return Direccion2;
            }

            set
            {
                Direccion2 = value;
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

        public int Rol1
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

        public int IdCliente1
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

        public string Direccion2
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

        public string Telefono2
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

        public List<int> IdproductoVenta
        {
            get
            {
                return idproductoVenta;
            }

            set
            {
                idproductoVenta = value;
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

        public List<int> CantidadVendidad
        {
            get
            {
                return cantidadVendidad;
            }

            set
            {
                cantidadVendidad = value;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(1))
            {
                if (txtBuscar.Text.Equals(""))
                {
                    MessageBox.Show("No A dijitado ningun nombre");

                }
                else
                {
                    controlador.SelectClientFact cliente = new controlador.SelectClientFact();
                    cliente.buscarCliente(data, txtBuscar.Text);
                }
            }
            else {

                if (txtBuscar.Text.Equals(""))
                {
                    MessageBox.Show("No a dijitado el nombre a buscar del producto");
                }
                else
                {
                    controlador.SelectClientFact producto = new controlador.SelectClientFact();
                    producto.buscarProducto(data, txtBuscar.Text);
                }

            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (this.Accion.Equals(1))
            {
                btnAgregar.Enabled = false;
                lblTitulo.Text = "AGREGAR CLIENTE";
                lblBuscar.Text = "Busqueda x Nombre Cliente";
                lblDirec.Text = "Direccion";
                controlador.SelectClientFact cliente = new controlador.SelectClientFact();
                cliente.clientesTodos(data);
            }
            else
            {
                btnAgregar.Enabled = false;
                lblTitulo.Text = "AGREGAR PRODUCTOS";
                lblDirec.Text = "Precio";
                lblDocum.Text = "Cantidad (eje: 5)";
                lblTele.Text = "Descuento  (eje: 1)";
                lblBuscar.Text = "Busqueda x Nombre Producto";
                controlador.SelectClientFact producto = new controlador.SelectClientFact();
                lblTipo.Visible = false;
                txtTipo.Visible = false;
                producto.producTodos(data);

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

        public string Cod
        {
            get
            {
                return cod;
            }

            set
            {
                cod = value;
            }
        }

        public int Idfact
        {
            get
            {
                return idfact;
            }

            set
            {
                idfact = value;
            }
        }

        public double Sub
        {
            get
            {
                return sub;
            }

            set
            {
                sub = value;
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

        private void Detalle_Load(object sender, EventArgs e)
        {
            if (this.Accion.Equals(1)) {
                btnAgregar.Enabled = false;
                lblTitulo.Text = "AGREGAR CLIENTE";
                lblBuscar.Text = "Busqueda x Nombre Cliente";
                lblDirec.Text = "Direccion";
                controlador.SelectClientFact cliente = new controlador.SelectClientFact();
                cliente.clientesTodos(data);
            } else {
                if (this.accion.Equals(4))
                {
                    btnAgregar.Enabled = false;
                    lblTitulo.Text = "CAMBIO DE CLIENTE EN LA FACTURA ";
                    lblBuscar.Text = "Busqueda x Nombre Cliente";
                    lblDirec.Text = "Direccion";
                    controlador.SelectClientFact cliente = new controlador.SelectClientFact();
                    cliente.clientesTodos(data);
                }
                else {
                    btnAgregar.Enabled = false;
                    lblTitulo.Text = "AGREGAR PRODUCTOS";
                    lblDirec.Text = "Precio";
                    lblDocum.Text = "Cantidad (eje: 5)";
                    lblTele.Text = "Descuento  (eje: 1)";
                    lblBuscar.Text = "Busqueda x Nombre Producto";
                    controlador.SelectClientFact producto = new controlador.SelectClientFact();
                    lblTipo.Visible = false;
                    txtTipo.Visible = false;
                    producto.producTodos(data);
                }
             

            }
        }
    }
}
