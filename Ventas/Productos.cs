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
    public partial class Productos : form.FormProduct
    {
        private int id, rol,accion,idProve;
        private String nombre,nombreProve;
        /**/
        private string codigo, nombreproduc, marca, modelo, serie, idproduc, categoria, maxima, minima, pv, pc;

        public Productos()
        {
            InitializeComponent();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Ventas.Menu();
            menu.Id = this.id;
            menu.Nombre = this.nombre;
            menu.Rol = this.rol;
            menu.Show();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            todo();
        }

        public void todo() {
            controlador.CrudProducto producto = new controlador.CrudProducto();
            producto.datosProduct(dataProducto);
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            todo();
            if (this.accion.Equals(1)) {
                lblTitulo.Text = "Nuevo Producto";
                lblCodigo.Visible = false;
                txtCodigo.Visible = false;
                lblId.Visible = false;
                txtId.Visible = false;
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                btnBuscar.Visible = false;
                txtBuscar.Visible = false;
                lblBuscar.Visible = false;
                btnTodos.Visible = false;
                btnguardar.Enabled = false;
                txtproveedor.Enabled = false;
                /**/
                txtNombre.Enabled = false;
                txtMarca.Enabled = false;
                txtModelo.Enabled = false; txtSerie.Enabled = false;
                txtDescripcion.Enabled = false;
                txtMaxima.Enabled = false;
                txtMinima.Enabled = false;
                txtPrecioVenta.Enabled = false;
                txtPrecioCompra.Enabled = false;
                checAccseorios.Enabled = false;
                checkPartes.Enabled = false;
            } else if (this.accion.Equals(2)) {
                lblTitulo.Text = "Busqueda de Producto";
                groupBox1.Visible = false;
                btnProve.Visible = false;
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                btnguardar.Visible = false;

            } else if (this.accion.Equals(3)) {
                lblTitulo.Text = "Mantenimiento de Producto";
                txtCodigo.Enabled = false;
                txtId.Enabled = false;
                txtproveedor.Enabled = false;
                lblCategoria.Visible = false;
                checAccseorios.Visible = false;
                checkPartes.Visible = false;
                lblDescrip.Text = "Categoria";
                btnguardar.Visible = false;
                txtMaxima.Enabled = false;
                txtMinima.Enabled = false;
                txtDescripcion.Enabled = false;
            } else if (this.accion.Equals(5)) {
                txtNombre.Enabled = true;
                txtMarca.Enabled = true;
                txtModelo.Enabled = true;
                txtSerie.Enabled = true;
                txtDescripcion.Enabled = true;
                txtMaxima.Enabled = true;
                txtMinima.Enabled = true;
                txtPrecioCompra.Enabled = true;
                txtPrecioVenta.Enabled = true;
                txtproveedor.Text = this.nombreProve;
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                btnguardar.Enabled = true;
                lblCodigo.Visible = true;
                txtCodigo.Visible = true;
                lblId.Visible = false;
                txtId.Visible = false;
                txtproveedor.Enabled = false;

            }else if(this.accion.Equals(6)){
                lblTitulo.Text = "Mantenimiento de Producto";
                txtCodigo.Enabled = false;
                txtId.Enabled = false;
                txtproveedor.Enabled = false;
                lblCategoria.Visible = false;
                checAccseorios.Visible = false;
                checkPartes.Visible = false;
                lblDescrip.Text = "Categoria";
                btnguardar.Visible = false;
                txtDescripcion.Enabled = false;
                /**/
                txtCodigo.Text = this.codigo;
                Console.WriteLine("viene de proveee "+this.codigo);
                txtNombre.Text = this.nombreproduc;
                txtMarca.Text = this.marca;
                txtModelo.Text = this.modelo;
                txtSerie.Text = this.serie;
                txtId.Text = this.idproduc;
                txtDescripcion.Text = this.categoria;
                txtMaxima.Text = this.maxima;
                txtMinima.Text = this.minima;
                txtPrecioCompra.Text = this.pc;
                txtPrecioVenta.Text = this.pv;
                txtproveedor.Text = this.nombreProve;
                txtMaxima.Enabled = false;
                txtMinima.Enabled = false;

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("No dijito nada para Buscar");
            }
            else {
                controlador.CrudProducto product = new controlador.CrudProducto();
                product.datosBusProduct(txtBuscar.Text,dataProducto);
            }
        }

        private void dataProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.accion.Equals(3) || this.accion.Equals(6)) {
                int i = dataProducto.CurrentRow.Index;
                txtId.Text = dataProducto.Rows[i].Cells[0].Value.ToString();
                txtCodigo.Text = dataProducto.Rows[i].Cells[1].Value.ToString();
                txtNombre.Text = dataProducto.Rows[i].Cells[2].Value.ToString();
                txtMarca.Text = dataProducto.Rows[i].Cells[3].Value.ToString();
                txtModelo.Text = dataProducto.Rows[i].Cells[4].Value.ToString();
                txtSerie.Text = dataProducto.Rows[i].Cells[5].Value.ToString();
                txtMaxima.Text = dataProducto.Rows[i].Cells[6].Value.ToString();
                txtMinima.Text = dataProducto.Rows[i].Cells[7].Value.ToString();
                txtPrecioCompra.Text = dataProducto.Rows[i].Cells[8].Value.ToString();
                txtPrecioVenta.Text = dataProducto.Rows[i].Cells[9].Value.ToString();
                txtDescripcion.Text = dataProducto.Rows[i].Cells[10].Value.ToString();
                txtproveedor.Text = dataProducto.Rows[i].Cells[11].Value.ToString();


            }
        }

        private void btnProve_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(3) || this.accion.Equals(6)) {

                if (txtCodigo.Text.Equals(""))
                {
                    MessageBox.Show("Deve de Selecciona un Dato de la Tabla");

                } else {
                    try
                    {
                        DialogResult dialogo = MessageBox.Show("Decea Cambiar de Proveedor el Producto", "Cambio de Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogo == DialogResult.Yes)
                        {
                            this.Hide();
                            Proveedor prove = new Proveedor();
                            prove.Id = this.id;
                            prove.Nombre = this.nombre;
                            prove.Rol = this.rol;
                            prove.Accion = 6;
                            /*para manda los datos */
                            prove.Idproduc = txtId.Text;
                            prove.Codigo = txtCodigo.Text;
                            Console.WriteLine(txtCodigo.Text);
                            prove.Nombreproduc = txtNombre.Text;
                            prove.Marca = txtMarca.Text;
                            prove.Modelo = txtModelo.Text;
                            prove.Serie = txtSerie.Text;
                            prove.Categoria = txtDescripcion.Text;
                            prove.Maxima = txtMaxima.Text;
                            prove.Minima = txtMinima.Text;
                            prove.Pc = txtPrecioCompra.Text;
                            prove.Pv = txtPrecioVenta.Text;
                            prove.Nombreprove = txtproveedor.Text;
                            prove.Idprove = 0;
                            prove.Show();

                        }
                        else
                            return;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

            }
            else {
                this.Hide();
                Proveedor prove = new Proveedor();
                prove.Id = this.id;
                prove.Nombre = this.nombre;
                prove.Rol = this.rol;
                prove.Accion = 5;
                prove.Show();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtMarca.Text.Equals("") || txtModelo.Text.Equals("") || txtSerie.Text.Equals("") || txtDescripcion.Text.Equals("") || txtMaxima.Text.Equals("") || txtMinima.Text.Equals("") || txtPrecioCompra.Text.Equals("") || txtPrecioVenta.Text.Equals(""))
            {
                MessageBox.Show("Tiene Campos Vacios");
            }
            else if (checAccseorios.Checked && checkPartes.Checked)
            {
                MessageBox.Show("Solo seleccione una categoria");
            }
            else if (checkPartes.Checked.Equals(false) && checAccseorios.Checked.Equals(false)) {
                MessageBox.Show("Selecione la categoria");

            } else {
                modelo.Productos produc = new modelo.Productos();
                produc.Codigo = txtCodigo.Text;
                produc.Nombre = txtNombre.Text;
                produc.Marca = txtMarca.Text;
                produc.Modelo = txtModelo.Text;
                produc.Serie = txtSerie.Text;
                produc.Descripcion = txtDescripcion.Text;
                produc.Maximo = Convert.ToInt32(txtMaxima.Text);
                produc.Minimo = Convert.ToInt32(txtMinima.Text);
                produc.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                produc.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                if (checkPartes.Checked)
                {
                    produc.Categoria = 1;

                }
                else
                {
                    produc.Categoria = 2;
                }
                produc.Proveedor = this.idProve;
                /*se llama el metodo*/
                produc.insert();
                if (produc.Msg.Equals("Producto Creado"))
                {
                    MessageBox.Show(produc.Msg);
                    todo();
                    btnguardar.Enabled = false;
                    limipar();
                    inavilitar();
                }
                else
                {
                    MessageBox.Show(produc.Msg);
                }


            }
        }

        public void inavilitar() {
            txtCodigo.Enabled=false;
            txtNombre.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtDescripcion.Enabled = false;
            txtMaxima.Enabled = false;
            txtMinima.Enabled = false;
            txtPrecioCompra.Enabled = false;
            txtPrecioVenta.Enabled = false;
        }

        public void limipar() {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtSerie.Text = "";
            txtDescripcion.Text = "";
            txtMaxima.Text = "";
            txtMinima.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(3) || this.accion.Equals(6))
            {

                if (txtCodigo.Text.Equals(""))
                {
                    MessageBox.Show("Deve de Seleccionar un Registro de la Tabla");

                }
                else
                {
                    try
                    {
                        DialogResult dialogo = MessageBox.Show("Decea actualizar los datos del Producto", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                        if (dialogo == DialogResult.Yes)
                        {
                            if (this.idProve.Equals(0)) {
                                MessageBox.Show("Seleccione Nuevamente el proveedor");
                            } else {
                                modelo.Productos produc = new modelo.Productos();
                                produc.Id = Convert.ToInt32(txtId.Text);
                                produc.Nombre = txtNombre.Text;

                                produc.Codigo = txtCodigo.Text;
                                produc.Marca = txtMarca.Text;
                                produc.Modelo = txtModelo.Text;
                                produc.Serie = txtSerie.Text;
                                produc.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                                produc.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                                produc.Proveedor = this.idProve;
                                produc.actualizar();
                                if (produc.Msg.Equals("Producto Actualizado")) {
                                    MessageBox.Show(produc.Msg);
                                    todo();
                                    txtId.Text = "";
                                    txtCodigo.Text = "";
                                    txtNombre.Text = "";
                                    txtMarca.Text = "";
                                    txtModelo.Text = "";
                                    txtSerie.Text = "";
                                    txtDescripcion.Text = "";
                                    txtMaxima.Text = "";
                                    txtMinima.Text = "";
                                    txtPrecioCompra.Text = "";
                                    txtPrecioVenta.Text = "";
                                    txtproveedor.Text = "";
                                } else {
                                    MessageBox.Show(produc.Msg);
                                }
                              

                            }


                        }
                        else
                            return;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(3) || this.accion.Equals(6))
            {

                if (txtCodigo.Text.Equals(""))
                {
                    MessageBox.Show("Deve de Selecciona un Registro de la Tabla");

                }
                else
                {
                    try
                    {
                        DialogResult dialogo = MessageBox.Show("Decea eliminar el Producto", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogo == DialogResult.Yes)
                        {
                            controlador.CrudProducto produc = new controlador.CrudProducto();
                            if (produc.elimProduc(Convert.ToInt32(txtId.Text))) {
                                MessageBox.Show("Producto Eliminado");
                                todo();
                            } else {
                                MessageBox.Show("Producto No  Eliminado");
                            }

                        }
                        else
                            return;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

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

        public int IdProve
        {
            get
            {
                return idProve;
            }

            set
            {
                idProve = value;
            }
        }

        public string NombreProve
        {
            get
            {
                return nombreProve;
            }

            set
            {
                nombreProve = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nombreproduc
        {
            get
            {
                return nombreproduc;
            }

            set
            {
                nombreproduc = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Serie
        {
            get
            {
                return serie;
            }

            set
            {
                serie = value;
            }
        }

        public string Idproduc
        {
            get
            {
                return idproduc;
            }

            set
            {
                idproduc = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public string Maxima
        {
            get
            {
                return maxima;
            }

            set
            {
                maxima = value;
            }
        }

        public string Minima
        {
            get
            {
                return minima;
            }

            set
            {
                minima = value;
            }
        }

        public string Pv
        {
            get
            {
                return pv;
            }

            set
            {
                pv = value;
            }
        }

        public string Pc
        {
            get
            {
                return pc;
            }

            set
            {
                pc = value;
            }
        }
    }
}
