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
    class CrudCliente
    {

        ConexionDb conex = new ConexionDb();
        private SqlConnection con;
        /*para validar el login*/
        // private SqlDataReader leer;
        private SqlCommand cmd;
        private String sql = "";
        private DataTable dt;
        private SqlDataAdapter da;

        /*para registrar un nuevo cliente y actualizar*/
        public Boolean inserActuClien(int accion, int id, String nombre, String dui, String nit, String direccion, String telefono, String correo, int tipo, int clasificacion)
        {
            con = new SqlConnection(conex.Cadena);
            String core = correo;
            switch (accion)
            {

                case 1:
                    /*insertar*/
                    sql = "execute crudCliente " + accion + ",1,'" + nombre + "','" + dui + "','" + nit + "','" + direccion + "','" + telefono + "','" + correo + "'," + tipo + "," + clasificacion + "";

                    break;
                /*para actualizar*/
                case 2:

                    sql = "execute crudCliente " + accion + "," + id + ",'" + nombre + "','" + dui + "','" + nit + "','" + direccion + "','" + telefono + "','" + correo + "',1,1";

                    break;

            }
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {

                int i = cmd.ExecuteNonQuery();
                Console.WriteLine(i);
                if (i > 0)
                {
                    return true;

                }
                else
                {
                   
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
                return false;
            }
            finally { con.Close(); }

        }

        /*para seleccionar todos los datos o por id  */
        public void selecClien(int accion, String documento, DataGridView data)
        {
            try
            {
                con = new SqlConnection(conex.Cadena);
                switch (accion)
                {
                    case 1:
                        sql = "execute crudCliente 3,1,'n','n','n','n','n','n',1,1";
                        break;
                    case 2:
                        sql = "execute crudCliente 4,1,'n','" + documento + "','n','n','n','n',1,1";
                        break;
                }

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
        public Boolean eliminar(int id)
        {
            con = new SqlConnection(conex.Cadena);

            sql = "execute crudCliente 5," + id + ",'n','n','n','n','n','n',1,1";
           

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {

                int i = cmd.ExecuteNonQuery();
                Console.WriteLine(i);
                if (i > 0)
                {
                    return true;

                }
                else
                {
                   
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
                return false;
            }
            finally { con.Close(); }

        }



    }
}
