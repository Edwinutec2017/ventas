using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.classConexion;
using System.IO;
namespace Ventas.controlador
{
    class GenerarXml
    {
        ConexionDb conex = new ConexionDb();
        private SqlConnection con;
        private int idfa;
       /*rear los reportes*/
         private SqlDataReader leer;
        private SqlCommand cmd;
        private String sql = "";
       // private DataTable dt;
       private SqlDataAdapter ad;
        private DataSet ds;
        private String a, b, c, d;

        /*para buscar el registro*/
        public Boolean generar(String cod,int id) {
            try
            {
                /*son dos consultas en una sola*/
                con = new SqlConnection(conex.Cadena);
                sql = "execute impEncaFact '" + cod + "';execute imDetaFact " + id + "";
                ad = new SqlDataAdapter(sql, con);
                ad.TableMappings.Add("ventas1", "detalle");
                ds = new DataSet("factura");
                ad.Fill(ds, "ventas");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally {
                con.Close();
            }
        }

        public Boolean generarArchivo() {
            try {
                /*1 se crear el directorio*/
                a = "C:";
                b = "\\xml";
                c = a + b;
                Directory.CreateDirectory(c);
                /*2 se genera el archivo xml*/
                b = "\\xml\\";
                d = "ventas.xml";
                c = a + b + d;
                ds.WriteXml(c,XmlWriteMode.WriteSchema);
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }

        }



        /*Busca el id de la Fcatura */
        public int buscaIdFcat(String numero)
        {
            con = new SqlConnection(conex.Cadena);
            /*procedimiento almacenado*/
            sql = "execute selectIdFact '"+numero+"'";
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
                        /*retorn  el id de la factura*/
                        idfa=Convert.ToInt32(leer[0].ToString());
                    }
                }
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                idfa = 0;
            }
            finally
            {
                con.Close();
            }
            return idfa;
        }


    }
}
