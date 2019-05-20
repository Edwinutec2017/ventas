using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.modelo
{
    class Productos
    {
        private int id,maximo,minimo,categoria,proveedor;
        private String codigo, nombre, marca, modelo, serie, descripcion,msg;
        private Double precioVenta, precioCompra;

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

        public int Maximo
        {
            get
            {
                return maximo;
            }

            set
            {
                maximo = value;
            }
        }

        public int Minimo
        {
            get
            {
                return minimo;
            }

            set
            {
                minimo = value;
            }
        }

        public int Categoria
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

        public int Proveedor
        {
            get
            {
                return proveedor;
            }

            set
            {
                proveedor = value;
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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
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

        public double PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
            }
        }

        /*metood*/
        public void insert() {
            controlador.CrudProducto produc = new controlador.CrudProducto();
            if (produc.inserProdNew(this.codigo,this.nombre,this.marca,this.modelo,this.serie,this.descripcion,this.maximo,this.minimo,this.precioVenta,this.precioCompra,this.categoria,this.proveedor).Equals(true)) {
                this.id = produc.selectIdProduct(this.codigo);
                if (this.id != 0)
                {
                    if (produc.inserIveNew(this.id).Equals(true)) {

                        this.msg = "Producto Creado";

                    } else {
                        this.msg = "No se insertar el producto...";
                    }


                }else
                {

                    this.msg = "No se insertar el producto..";
                }
            } else {
                this.msg = "No se insertar el producto.";
            }

        }

        public void actualizar() {
            controlador.CrudProducto produc = new controlador.CrudProducto();
            if (produc.actuProduct(this.id,this.codigo,this.nombre,this.marca,this.modelo,this.serie,this.precioVenta,this.precioCompra,this.proveedor)) {
                this.msg = "Producto Actualizado";
            } else {
                this.msg = "No actualizado";
            }


        }

    }

}
