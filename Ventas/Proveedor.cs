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
    public partial class Proveedor : form.FormProveedor
    {
        private int id, rol,accion,idprove;
        private String nombre,nombreprove;

        private string codigo, nombreproduc, marca, modelo, serie, idproduc, categoria, maxima, minima, pv, pc;

        public Proveedor()
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
            if (this.accion.Equals(5))
            {
                this.Hide();
                Productos product = new Productos();
                product.Id = this.id;
                product.Nombre = this.nombre;
                product.Rol = this.rol;
                product.IdProve = this.idprove;
                product.NombreProve = this.nombreprove;
                product.Accion = this.accion;
                product.Show();
            } else if (this.accion.Equals(6)) {
               
                    this.Hide();
                    Productos product = new Productos();
                    product.Id = this.id;
                    product.Nombre = this.nombre;
                    product.Rol = this.rol;
                    product.IdProve = this.idprove;
                    product.NombreProve = this.nombreprove;
                    product.Accion = this.accion;
                /**/
                product.Codigo = this.codigo;
                product.Nombreproduc = this.nombreproduc;
                product.Marca = this.marca;
                product.Modelo = this.modelo;
                product.Serie = this.serie;
                product.Idproduc = this.idproduc;
                product.Categoria = this.categoria;
                product.Maxima = this.maxima;
                product.Minima = this.minima;
                product.Pv = this.pv;
                product.Pc = this.pc;
              
                    product.Show();
                

            }
            else {
                this.Hide();
                Menu menu = new Ventas.Menu();
                menu.Id = this.id;
                menu.Nombre = this.nombre;
                menu.Rol = this.rol;
                menu.Show();
            }


        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            todo();

            if (this.accion.Equals(1)) {
                lblTitulo.Text = "Registro de Proveedor";
                lblRazon.Text = "Proveedor";
                lblReg.Text = "# DUI";
                lblId.Visible = false;
                txtId.Visible = false;
                lblClasificacion.Visible = false;
                txtClasificacion.Visible = false;
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                lblTipo.Visible = false;
                checGrande.Visible = false;
                chekMediano.Visible = false;
                chekPeque.Visible = false;
                /*para buscar*/
                lblBuscar.Visible = false;
                btnBuscar.Visible = false;
                btnTodos.Visible = false;
                txtbuscar.Visible = false;
                /*para avilitar los campos*/
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtRazon.Enabled = true;
                txtNIt.Enabled = true;
                txtReg.Enabled = true;
                txtCorreo.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = true;

            } else if (this.accion.Equals(2)) {
                lblTitulo.Text = "Registro de Proveedor";
                lblReg.Text = "# Registro";
                lblId.Visible = false;
                txtId.Visible = false;
                lblClasificacion.Visible = false;
                txtClasificacion.Visible = false;
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                lblBuscar.Visible = false;
                btnBuscar.Visible = false;
                btnTodos.Visible = false;
                /*para buscar*/
                lblBuscar.Visible = false;
                btnBuscar.Visible = false;
                btnTodos.Visible = false;
                txtbuscar.Visible = false;
                /*para avilitar los campos*/
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtRazon.Enabled = true;
                txtNIt.Enabled = true;
                txtReg.Enabled = true;
                txtCorreo.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = true;


            } else if (this.accion.Equals(3)) {
                lblTitulo.Text = "Busqueda de Proveedor";
                lblBuscar.Text = "Busqueda x Registro o DUI";
                groupBox1.Visible = false;
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                btnGuardar.Visible = false;
            } else if (this.accion.Equals(4)) {
                lblTitulo.Text = "Mantenimiento de Proveedor";
                lblBuscar.Text = "Busqueda x Registro o DUI";
                lblTipo.Visible = false;
                checGrande.Visible = false;
                chekMediano.Visible = false;
                chekPeque.Visible = false;
                btnGuardar.Visible = false;
            } else if (this.accion.Equals(5)) {
                lblTitulo.Text = "Agregar  Proveedor";
                lblBuscar.Text = "Busqueda x Registro o DUI";
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                lblTipo.Visible = false;
                checGrande.Visible = false;
                chekMediano.Visible = false;
                chekPeque.Visible = false;
            } else if (this.accion.Equals(6)) {
                lblTitulo.Text = "Agregar  Proveedor";
                lblBuscar.Text = "Busqueda Nombre de proveedor";
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                lblTipo.Visible = false;
                checGrande.Visible = false;
                chekMediano.Visible = false;
                chekPeque.Visible = false;
                txtbuscar.Text = this.nombreprove;
            }
        }

        public void todo(){
            controlador.CrudProveedor prove = new controlador.CrudProveedor();
            prove.datosProve(dataProve);
            }

        /*seleccion la data*/
        public void datos() {

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            todo();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals(6)) {
                if (txtbuscar.Text.Equals(""))
                {
                    MessageBox.Show("No a dijitado Que buscar");
                    txtbuscar.Focus();
                }
                else
                {

                    controlador.CrudProveedor prove = new controlador.CrudProveedor();
                    prove.datosBusNombProve(txtbuscar.Text, dataProve);
                    txtbuscar.Text = "";
                }

            } else {
                if (txtbuscar.Text.Equals(""))
                {
                    MessageBox.Show("No a dijitado Que buscar");
                    txtbuscar.Focus();
                }
                else
                {

                    controlador.CrudProveedor prove = new controlador.CrudProveedor();
                    prove.datosBusProve(txtbuscar.Text, dataProve);
                    txtbuscar.Text = "";
                }
            }
        }

        private void dataProve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.accion.Equals(4)) {
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtRazon.Enabled = true;
                txtCorreo.Enabled = true;
                txtTelefono.Enabled = true;
                int i = dataProve.CurrentRow.Index;
                txtId.Text = dataProve.Rows[i].Cells[0].Value.ToString();
                txtNombre.Text = dataProve.Rows[i].Cells[1].Value.ToString();
                txtDireccion.Text = dataProve.Rows[i].Cells[2].Value.ToString();
                txtRazon.Text = dataProve.Rows[i].Cells[3].Value.ToString();
                txtNIt.Text = dataProve.Rows[i].Cells[4].Value.ToString();
                txtCorreo.Text = dataProve.Rows[i].Cells[5].Value.ToString();
                txtTelefono.Text = dataProve.Rows[i].Cells[6].Value.ToString();
                txtReg.Text = dataProve.Rows[i].Cells[7].Value.ToString();
                txtClasificacion.Text = dataProve.Rows[i].Cells[8].Value.ToString();
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            } else if (this.accion.Equals(5) || this.accion.Equals(6)) {
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtRazon.Enabled = true;
                txtCorreo.Enabled = true;
                txtTelefono.Enabled = true;
                int i = dataProve.CurrentRow.Index;
                txtId.Text = dataProve.Rows[i].Cells[0].Value.ToString();
                txtNombre.Text = dataProve.Rows[i].Cells[1].Value.ToString();
                txtDireccion.Text = dataProve.Rows[i].Cells[2].Value.ToString();
                txtRazon.Text = dataProve.Rows[i].Cells[3].Value.ToString();
                txtNIt.Text = dataProve.Rows[i].Cells[4].Value.ToString();
                txtCorreo.Text = dataProve.Rows[i].Cells[5].Value.ToString();
                txtTelefono.Text = dataProve.Rows[i].Cells[6].Value.ToString();
                txtReg.Text = dataProve.Rows[i].Cells[7].Value.ToString();
                txtClasificacion.Text = dataProve.Rows[i].Cells[8].Value.ToString();
                btnGuardar.Enabled = true;
            }
         
       


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtDireccion.Text.Equals("") || txtRazon.Text.Equals("") || txtNIt.Text.Equals("") || txtReg.Text.Equals("") || txtCorreo.Equals("") || txtTelefono.Equals(""))
            {
                MessageBox.Show("Tiene campos Vacios");
            }
            else if (this.accion.Equals(1))
            {
                modelo.Proveedor prove = new modelo.Proveedor();
                prove.Nombre = txtNombre.Text;
                prove.Direccion = txtDireccion.Text;
                prove.Razon = txtRazon.Text;
                prove.Nit = txtNIt.Text;
                prove.Registro = txtReg.Text;
                prove.Email = txtCorreo.Text;
                prove.Telefono = txtTelefono.Text;
                prove.Clasificacion = 4;
                prove.insertar();
                if (prove.Msg.Equals("Proveedor Creado"))
                {
                    MessageBox.Show(prove.Msg);
                    todo();
                    limipar();
                }
                else
                {
                    MessageBox.Show(prove.Msg);
                }

            }
            else if (this.accion.Equals(2)) {
                if (checGrande.Checked && chekMediano.Checked && chekPeque.Checked || checGrande.Checked && chekMediano.Checked || checGrande.Checked && chekPeque.Checked || chekMediano.Checked && chekPeque.Checked)
                {
                    MessageBox.Show("Solo deve de selecciona un tipo ");
                }
                else if (chekPeque.Checked.Equals(false) && checGrande.Checked.Equals(false) && chekMediano.Checked.Equals(false))
                {
                    MessageBox.Show("Selecione un Tipo de Proveedor");
                }
                else {
                    modelo.Proveedor prove = new modelo.Proveedor();
                    prove.Nombre = txtNombre.Text;
                    prove.Direccion = txtDireccion.Text;
                    prove.Razon = txtRazon.Text;
                    prove.Nit = txtNIt.Text;
                    prove.Registro = txtReg.Text;
                    prove.Email = txtCorreo.Text;
                    prove.Telefono = txtTelefono.Text;
                    if (chekPeque.Checked) {
                        prove.Clasificacion = 1;
                    } else if (chekMediano.Checked) {
                        prove.Clasificacion = 2;
                    } else {
                        prove.Clasificacion = 3;
                    }
                    prove.insertar();
                    if (prove.Msg.Equals("Proveedor Creado")) {
                        MessageBox.Show(prove.Msg);
                        todo();
                        limipar();
                    } else {
                        MessageBox.Show(prove.Msg);
                    }
                }
            } else if (this.accion.Equals(5)) {
                this.Hide();
                MessageBox.Show("Proveedor agregado");
                Productos product = new Productos();
                product.Id = this.id;
                product.Nombre = this.nombre;
                product.Rol = this.rol;
                product.IdProve = Convert.ToInt32(txtId.Text);
                product.NombreProve = txtNombre.Text;
                product.Accion = this.accion;
                product.Show();
            } else if (this.accion.Equals(6)) {
                this.Hide();
                Productos product = new Productos();
                product.Id = this.id;
                product.Nombre = this.nombre;
                product.Rol = this.rol;
                product.IdProve = Convert.ToInt32(txtId.Text);
                product.NombreProve = txtNombre.Text;
                product.Accion = this.accion;
                /**/
                product.Codigo = this.codigo;
                product.Nombreproduc = this.nombreproduc;
                product.Marca = this.marca;
                product.Modelo = this.modelo;
                product.Serie = this.serie;
                product.Idproduc = this.idproduc;
                product.Categoria = this.categoria;
                product.Maxima = this.maxima;
                product.Minima = this.minima;
                product.Pv = this.pv;
                product.Pc = this.pc;
              
                product.Show();

            }


        }
        public void limipar(){
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtRazon.Text = "";
            txtNIt.Text = "";
            txtReg.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
            txtClasificacion.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un registro a Eliminar");
            }
            else {
                controlador.CrudProveedor prove = new controlador.CrudProveedor();
                this.id = Convert.ToInt32(txtId.Text);
                if (prove.eliminarProve(this.id))
                {
                    MessageBox.Show("Proveedor Eliminado");
                    limipar();
                    todo();
                }
                else
                {
                    MessageBox.Show("No se  pudo eliminar en Proveedor");
                }
            }
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un registro para actualizar");
            }
            else {
                modelo.Proveedor prove = new modelo.Proveedor();
                prove.Id = Convert.ToInt32(txtId.Text);
                prove.Nombre = txtNombre.Text;
                prove.Direccion = txtDireccion.Text;
                prove.Razon = txtRazon.Text;
                prove.Email = txtCorreo.Text;
                prove.Telefono = txtTelefono.Text;
                prove.actualizar();
                if (prove.Msg.Equals("Proveedor actualizado")) {
                    MessageBox.Show(prove.Msg);
                    limipar();
                    todo();
                } else {
                    MessageBox.Show(prove.Msg);
                }

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

        public int Idprove
        {
            get
            {
                return idprove;
            }

            set
            {
                idprove = value;
            }
        }

        public string Nombreprove
        {
            get
            {
                return nombreprove;
            }

            set
            {
                nombreprove = value;
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
