using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.classConexion
{
    class ConexionDb
    {

        //solo modifique los parametros necesarios 
        private String namedb = "ModuloVentas";//nombre de la db 
        private String usersql = "equipo0\\SQLExpress";//asi deve de ir el nombre del usuario
        private String cadena = "";
        public SqlConnection conecdb = new SqlConnection();

        /*inicializat las variable cadena */
        public ConexionDb()
        {
            Cadena = $"Data Source={usersql};Initial Catalog={namedb}; Integrated Security=True";

        }
        public string Cadena
        {
            get
            {
                return cadena;
            }

            set
            {
                cadena = value;
            }
        }
    }
}
