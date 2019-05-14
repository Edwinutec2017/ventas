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
    class SelectClientFact
    {

        ConexionDb conex = new ConexionDb();
        private SqlConnection con;
        /*para validar el login*/
        //private SqlDataReader leer;
        // private SqlCommand cmd;
        private String sql = "";
        private DataTable dt;
        private SqlDataAdapter da;

        /*para la seleccion de  todo  los clienytes*/
        public void clientesTodos(DataGridView data)
        {
            con = new SqlConnection(conex.Cadena);
            try
            {
                sql = "execute selectFactClientes 1,'n'";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                data = null;
            }
            finally
            {
                con.Close();
            }

        }
        /*para la busqueda de un cliente */
        public void buscarCliente(DataGridView data, String nombre)
        {
            con = new SqlConnection(conex.Cadena);
            try
            {
                sql = "execute selectFactClientes 2,'" + nombre + "'";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                data = null;

            }
            finally
            {
                con.Close();
            }
        }
        /*para seleccionar todo  los productos */
        public void producTodos(DataGridView data)
        {
            con = new SqlConnection(conex.Cadena);
            try
            {
                sql = "  execute selectProdFact 1,'nn'";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                data = null;
            }
            finally
            {
                con.Close();
            }

        }

        /*para  buscar  un producto en especifico */
        public void buscarProducto(DataGridView data, String nombre)
        {
            con = new SqlConnection(conex.Cadena);
            try
            {
                sql = "  execute selectProdFact 2,'" + nombre + "'";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                data = null;

            }
            finally
            {
                con.Close();
            }
        }
    }
}
