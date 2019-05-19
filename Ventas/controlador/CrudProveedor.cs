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
    class CrudProveedor
    {
        ConexionDb conex = new ConexionDb();
        private SqlConnection con;
       // private SqlDataReader leer;
        private SqlCommand cmd;
        private String sql = "";
        private DataTable dt;
        private SqlDataAdapter da;
        /*para traer todos los proveedore */
        public void datosProve(DataGridView datagriw)
        {
          
            try
            {
                con = new SqlConnection(conex.Cadena);
                sql = "execute selecActProve 1,1,'123'";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                datagriw.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                datagriw = null;
            }
            finally
            {
                con.Close();

            }

        }

        /*para buscar */
    
        public void datosBusProve(String numero,DataGridView datagriw)
        {
            try
            {
                con = new SqlConnection(conex.Cadena);
                sql = " execute selecActProve 2,1,'"+numero+"'";
                Console.WriteLine(sql);
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                datagriw.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                datagriw = null;
            }
            finally
            {
                con.Close();

            }

        }


 /*para eliminar un registro*/
        public Boolean eliminarProve(int id)
        {
            con = new SqlConnection(conex.Cadena);
            sql = "execute selecActProve 3,"+id+",'123'";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
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
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        /*para eliminar un registro*/
        public Boolean crearNuevoProve(String nombre,String direccion,String razon,String nit,String email,String telefono,String registro,int clasificacion)
        {
            con = new SqlConnection(conex.Cadena);
            sql = "execute crudProveedor 1,1,'"+nombre+"','"+direccion+"','"+razon+"','"+nit+"','"+email+"','"+telefono+"','"+registro+"',"+clasificacion+"";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
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
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        /*para Actualizar un registro*/
        public Boolean actuProve(int id,String nombre, String direccion, String razon, String nit, String email, String telefono, String registro)
        {
            con = new SqlConnection(conex.Cadena);
            sql = "execute crudProveedor 2,"+id+",'" + nombre + "','" + direccion + "','" + razon + "','n','" + email + "','" + telefono + "','n',1";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
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
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                con.Close();
            }

        }


    }
}
