using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.classConexion;

namespace Ventas.controlador
{
    class SelecProduc
    {
        ConexionDb conex = new ConexionDb();
        private SqlConnection con;
        /*para validar el login*/
        //private SqlDataReader leer;
        // private SqlCommand cmd;
        private String sql = "";
        private DataTable dt;
        private SqlDataAdapter da;

        /*seleccionar productos por  categorias */
        public void selecProducto(int accion, DataGridView data)
        {
            con = new SqlConnection(conex.Cadena);
            try
            {
                switch (accion)
                {
                    case 1:
                        sql = " execute selecProducto 1,'nnn'";
                        break;
                    case 2:
                        sql = " execute selecProducto 2,'nnn'";
                        break;
                }
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                data = null;

            }
            finally
            {
                con.Close();
            }

        }


        /*para  buscar un producto por categorias */
        public void buscarProducto(int accion, String nombre, DataGridView data)
        {
            con = new SqlConnection(conex.Cadena);
            try
            {
                switch (accion)
                {
                    case 1:
                        sql = " execute selecProducto 4,'" + nombre + "'";
                        Console.WriteLine(sql);
                        break;
                    case 2:
                        sql = " execute selecProducto 3,'" + nombre + "'";
                        break;
                }
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                data = null;

            }
            finally
            {
                con.Close();
            }

        }
    }
}
