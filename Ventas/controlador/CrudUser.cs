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
    class CrudUser
    {

        public CrudUser()
        {

        }
        ConexionDb conex = new ConexionDb();
        private SqlConnection con;
        /*para validar el login*/
        private SqlDataReader leer;
        private SqlCommand cmd;
        private String sql = "";
        private Boolean msg;
        private List<String> data = new List<String>();
        private DataTable dt;
        private SqlDataAdapter da;
        public bool Msg
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


        /*metodo para validar user */
        public List<String> validarLogin(String user, String passs)
        {

            con = new SqlConnection(conex.Cadena);
            /*procedimiento almacenado*/
            sql = "execute inicioSeccion " + user + "," + passs + "";
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
                        if (user.Equals(leer[1].ToString()) || passs.Equals(leer[2].ToString()))
                        {
                            data.Add(leer[0].ToString());
                            data.Add(leer[3].ToString());
                            data.Add(leer[4].ToString());
                            Msg = true;
                        }
                        else
                        {

                            Msg = false;
                        }
                    }

                }
                else
                {
                    Msg = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Msg = false;
            }
            finally
            {
                con.Close();
            }

            return data;
        }


        /*para registro de  un nuevo usuario y actualizar*/

        public Boolean inserActuUser(int accion, int id, String user, String nombre, string pass)
        {

            con = new SqlConnection(conex.Cadena);
            switch (accion)
            {
                case 1:
                    sql = "execute crudUser 1,1,'" + user + "','" + pass + "','" + nombre + "'";
                    break;
                case 2:
                    sql = "execute crudUser 2,1,'" + user + "','" + pass + "','" + nombre + "'";
                    break;
                case 3:
                    sql = "execute crudUser 3," + id + ",'" + user + "','" + pass + "','" + nombre + "'";
                    break;
            }
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

        /*para cambio de estado o  rol*/
        public Boolean cambioEstadoRol(int accion, int id)
        {
            con = new SqlConnection(conex.Cadena);
            switch (accion)
            {
                case 4:
                    sql = "execute crudUser 4," + id + ",'nn','nn','nn'";
                    break;
                case 5:
                    sql = "execute crudUser 5," + id + ",'nn','nn','nn'";
                    break;
                case 6:
                    sql = "execute crudUser 6," + id + ",'nn','nn','nn'";
                    break;
                case 7:
                    sql = "execute crudUser 7," + id + ",'nn','nn','nn'";
                    break;
            }
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


        /*para traer todos los usuario o solo uno*/
        public void datosUser(DataGridView datagriw)
        {
            String a = "us";
            try
            {
                con = new SqlConnection(conex.Cadena);
                sql = "execute selectUser 1,0," + a + "";
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
        /*para traer todos los usuario o solo uno*/
        public void datosBusqUser(DataGridView datagriw, String user)
        {

            try
            {
                con = new SqlConnection(conex.Cadena);
                sql = "execute selectUser 3,0,'" + user + "'";
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
    }
}
