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
    class CrudProducto
    {

        ConexionDb conex = new ConexionDb();
        private SqlConnection con;
        private SqlDataReader leer;
        private SqlCommand cmd;
        private String sql = "";
        private DataTable dt;
        private SqlDataAdapter da;
        /*para traer todos los producto */
        int id;
        /*para traer todos los proveedore */
        public void datosProduct(DataGridView datagriw)
        {
            try
            {
                con = new SqlConnection(conex.Cadena);
                sql = " execute selectElimProduct 1,1,'c78'";
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

        /*para traer productos a cero */
        public void invetCero(DataGridView datagriw)
        {
            try
            {
                con = new SqlConnection(conex.Cadena);
                sql = "execute selectCanInvetActu 1";
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
        /*para traer productos mayor a cero */
        public void invetMayoraCero(DataGridView datagriw)
        {
            try
            {
                con = new SqlConnection(conex.Cadena);
                sql = "execute selectCanInvetActu 2";
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


        /*para traer todos los proveedore */
        public void datosBusProduct(String codi,DataGridView datagriw)
        {
            try
            {
                con = new SqlConnection(conex.Cadena);
                sql = " execute selectElimProduct 2,1,'"+codi+"'";
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
        /*buscador de inventario */
        public void buscadorInvet(int accion,String codi, DataGridView datagriw)
        {
            try
            {
                con = new SqlConnection(conex.Cadena);
                switch (accion) {
                    case 1:
                        sql = "execute busInveCantidad 1,'"+codi+"'";
                        break;
                    case 2:
                        sql = "execute busInveCantidad 2,'" + codi + "'";

                        break;
                }
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
        /*para buscar el id del producto guardado*/

        public int  selectIdProduct(String codigo)
        {
            con = new SqlConnection(conex.Cadena);
            /*procedimiento almacenado*/
            sql = "execute selectIdProdu '"+codigo+"'";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    if (leer.Read())
                    {
                        id = Convert.ToInt32(leer[0].ToString());
                    }
                    else {
                        id = 0;
                    }

                }
                else
                {
                
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
          
            }
            finally
            {
                con.Close();
            }

            return id;
        }
        /*agregar al inventario uno nuevo */
        public Boolean inserIveNew(int id)
        {
            con = new SqlConnection(conex.Cadena);
           sql = "execute selectCatActInve 2,"+id+",0";
             
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        /*acualizar  inventario uno nuevo */
        public Boolean actuInve(int id,int cantidad)
        {
            con = new SqlConnection(conex.Cadena);
            sql = "execute selectCatActInve 3," + id + ","+cantidad+"";

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        /*eliminar producto */
        public Boolean elimProduc(int id)
        {
            con = new SqlConnection(conex.Cadena);
            sql = "execute elimPodcut "+id+"";

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                con.Close();
            }

        }


        /*crear un nuevo producto */
        public Boolean inserProdNew(String codigo,String nombre,String  marca,String modelo,String serie,String descripcion,int maximo,int minimo,Double pv,Double pc,int cate,int prove)
        {
            con = new SqlConnection(conex.Cadena);
            sql = "execute crudProduc 1,1,'"+codigo+"','"+nombre+"','"+marca+"','"+modelo+"','"+serie+"','"+descripcion+"',"+maximo+","+minimo+","+pv+","+pc+","+cate+","+prove+"";

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        /*actualizar un producto */
        public Boolean actuProduct(int id,String codigo, String nombre, String marca, String modelo, String serie, Double pv, Double pc,int prove)
        {
            con = new SqlConnection(conex.Cadena);
            sql = "execute crudProduc 2,"+id+",'"+codigo+"','" + nombre + "','" + marca + "','" + modelo + "','" + serie + "','n',0,0," + pv + "," + pc + ",1," + prove + "";

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                con.Close();
            }

        }

    }
}
