using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Conexion
    {
        string conectar = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        protected SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection con = new SqlConnection(conectar);
                
                    con.Open();
                    return con;

                

            }
            catch (Exception)
            {

                throw;
            }
        }
        protected void CerrarConexion(SqlConnection con)
        {
            try
            {
                using (con = new SqlConnection(conectar))
                    con.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

