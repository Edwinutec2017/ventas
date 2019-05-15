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
    class CrudFactura
    {
        ConexionDb conex = new ConexionDb();
        private SqlConnection con;
        /*para validar el login*/
        private SqlDataReader leer;
        private SqlCommand cmd;
        private String sql = "";
      //  private Boolean msg;
        private List<String> data = new List<String>();
        private DataTable dt;
        private SqlDataAdapter da;
       // public bool Msg;

        private int fac;
        private int idfac;
        public int Fac
        {
            get
            {
                return fac;
            }

            set
            {
                fac = value;
            }
        }

        public int Idfac
        {
            get
            {
                return idfac;
            }

            set
            {
                idfac = value;
            }
        }

        /*para traer el maximo numero*/
        public void maximoFactura()
        {

            String n = "";
            con = new SqlConnection(conex.Cadena);
            sql = "  EXECUTE numeroFACTU 1,'n'";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {

                con.Open();
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    if (leer.Read())
                    {
                        n = leer[0].ToString();
                      
                        this.fac = Convert.ToInt32(n) + 1;
                    }


                }
                else
                {
                    this.fac = this.fac + 1;
                   
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("error " + ex);
            }
            finally
            {
                con.Close();
            }

        }

        /*para traer el maximo numero*/
        public void idFactura(String numero)
        {

            String nf = "";
            con = new SqlConnection(conex.Cadena);
            sql = "  EXECUTE numeroFACTU 2,'" + numero + "'";
           
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {

                con.Open();
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    if (leer.Read())
                    {
                        nf = leer[0].ToString();
                       
                        this.idfac = Convert.ToInt32(nf);

                    }

                }
                else
                {

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("error " + ex);
            }
            finally
            {
                con.Close();
            }

        }


        /*para insertar el encabezado de la factura*/

        public Boolean inserEncabezado(int idCliente, String nuFact, int idUser, int tipo, Double sub, Double iva, Double total)
        {


            con = new SqlConnection(conex.Cadena);
            DateTime fecha = DateTime.Now.Date;
            String cons = fecha.ToString("yyy/MM/dd");

            sql = "execute crudFactura " + idCliente + ",'" + nuFact + "'," + idUser + ",'" + cons + "'," + tipo + "," + sub + "," + iva + "," + total + "";
         
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


        /*para insertar el detalle*/
        public Boolean inserDetalle(Double precio, int cantidad, Double descuento, Double total, int idproduc)
        {
            descuento = descuento / 100;
            con = new SqlConnection(conex.Cadena);
            sql = "execute detalleFactura " + precio + "," + cantidad + "," + descuento + "," + total + "," + idproduc + "," + idfac + "";
           
            
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
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
                return false;
            }
            finally { con.Close(); }
        }


        /*para seleccionar la factura */
        public void buscarFactura(int accion, String factu, DataGridView data)
        {
            con = new SqlConnection(conex.Cadena);
            try
            {
                switch (accion)
                {
                    case 1:
                        sql = "execute factSelect 1,'fa'";
                      
                        break;
                    case 2:
                        sql = "execute factSelect 2,'"+factu+"'";
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
        /*para seleccionar la factura devolucion */
        public void buscarFacturaDevolucion(int accion, String factu, DataGridView data)
        {
            con = new SqlConnection(conex.Cadena);
            try
            {
                switch (accion)
                {
                    case 1:
                        sql = "execute factSelectDevolu 1,'nn'";
                       
                        break;
                    case 2:
                        sql = "execute factSelectDevolu 1,'"+factu+"'";
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
        /*devolucion total*/
        public Boolean devolucionTotal(int idFact)
        {
        
            con = new SqlConnection(conex.Cadena);
            sql = "execute devolucion "+idFact+"";
          
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
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
                return false;
            }
            finally { con.Close(); }
        }

        /*para seleccionar la factura */
        public void seleccionaPrtoducFact(int idf, DataGridView data)
        {
            
            con = new SqlConnection(conex.Cadena);
            try
            {
            
    sql = "execute factBusid 2,"+idf+"";
         
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
