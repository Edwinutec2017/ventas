using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.classConexion;

namespace Ventas.controlador
{
    class FacClienselect
    {

        ConexionDb conex = new ConexionDb();
        private SqlConnection con;
        /*para validar el login*/
        private SqlDataReader leer;
        private SqlCommand cmd;
        private String sql = "";
        private Boolean msg;
        private String factura, fecha, cliente, direccion, telefono, nombreTipo,dui,vendedor;
        private int CodCliente;
        private Double Sub, iva, total;

        public string Factura
        {
            get
            {
                return factura;
            }

            set
            {
                factura = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string NombreTipo
        {
            get
            {
                return nombreTipo;
            }

            set
            {
                nombreTipo = value;
            }
        }

        public int CodCliente1
        {
            get
            {
                return CodCliente;
            }

            set
            {
                CodCliente = value;
            }
        }

        public double Sub1
        {
            get
            {
                return Sub;
            }

            set
            {
                Sub = value;
            }
        }

        public double Iva
        {
            get
            {
                return iva;
            }

            set
            {
                iva = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string Dui
        {
            get
            {
                return dui;
            }

            set
            {
                dui = value;
            }
        }

        public string Vendedor
        {
            get
            {
                return vendedor;
            }

            set
            {
                vendedor = value;
            }
        }

        /*para traer el encabezado de la factura*/

        public Boolean selecEnFact (int facid )
        {
            con = new SqlConnection(conex.Cadena);
            /*procedimiento almacenado*/
            sql = "execute factBusid 1,"+facid+"";
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
                        //data.Add(leer[0].ToString());
                        this.factura = leer[0].ToString();
                        this.fecha= leer[1].ToString();
                        this.CodCliente = Convert.ToInt32(leer[2].ToString());
                        this.cliente= leer[3].ToString();
                        this.vendedor= leer[4].ToString();
                        this.Dui= leer[5].ToString();
                        this.direccion= leer[6].ToString();
                        this.telefono= leer[7].ToString();
                        this.nombreTipo= leer[8].ToString();
                       
                        this.Sub = Convert.ToDouble(leer[9].ToString());
                        this.iva = Convert.ToDouble(leer[10].ToString());
                        this.total = Convert.ToDouble(leer[11].ToString());
                        msg = true;
                    }

                }
                else
                {
                    msg = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                msg = false;
            }
            finally
            {
                con.Close();
            }
            return msg;
            
        }
        /*para eliminar la factura */
        public Boolean elimFact(int id)
        {

            con = new SqlConnection(conex.Cadena);
            
                    sql = "execute elimFac 1,"+id+",1";
              
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

        /*para eliminar un producto*/
        public Boolean elimFactProd(int id)
        {

            con = new SqlConnection(conex.Cadena);

            sql = "execute elimFac 2,"+id+ ",1";

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
        /*para cambio de cliente*/
        public Boolean cambioCliente(int idf,int idCl)
        {

            con = new SqlConnection(conex.Cadena);

            sql = "execute elimFac 3," + idf + ","+idCl+"";
   
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
        /*para cambio de actualizar el ttotal*/
        public Boolean cambioTotalFact(Double sub,Double iva,Double tt,int id)
        {

            con = new SqlConnection(conex.Cadena);

            sql = "execute actuFacTotal " + sub+","+iva+","+tt+","+id+"";
         
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

