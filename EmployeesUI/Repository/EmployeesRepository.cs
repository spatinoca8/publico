using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class EmployeesRepository:Conexion
    {
        /// <summary>
        /// Metodo para obtener los empleados 
        /// </summary>
        /// <returns></returns>
        public List<EmployeeObject> GetEmployees()
        {
            try
            {
                var lis = new List<EmployeeObject>();
                var con = ObtenerConexion();
                SqlCommand ordensql = new SqlCommand("GETEMPLOYEES", con);
                SqlDataReader lector = ordensql.ExecuteReader();
                while (lector.Read())
                {
                    EmployeeObject obj = new EmployeeObject();
                    obj.Tip_Id = lector["Tip_Id"].ToString();
                    obj.Num_Id = lector["Num_Id"].ToString();
                    obj.First_Name = lector["First_Name"].ToString();
                    obj.Second_Name = lector["Second_Name"].ToString();
                    obj.Middle_Name = lector["Middle_Name"].ToString();
                    obj.Last_Name = lector["Last_Name"].ToString();
                    obj.Second_Name = lector["Second_Name"].ToString();
                    obj.Addres = lector["Addres"].ToString();
                    obj.Cellphone = lector["Cellphone"].ToString();
                    obj.Email = lector["Email"].ToString();
                    lis.Add(obj);
                }

                CerrarConexion(con);
                return lis;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Metodo para almacenar los empleados 
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int SaveEmployees(EmployeeObject emp)
        {
            try
            {
                int respuesta = 0;
                var con = ObtenerConexion();
                SqlCommand ordenSql = new SqlCommand("SAVEEMPLOYEES", con);
                ordenSql.CommandType = System.Data.CommandType.StoredProcedure;
                ordenSql.Parameters.AddWithValue("@Tip_Id", emp.Tip_Id);
                ordenSql.Parameters.AddWithValue("@Num_Id", emp.Num_Id);
                ordenSql.Parameters.AddWithValue("@First_Name", emp.First_Name);
                ordenSql.Parameters.AddWithValue("@Second_Name", emp.Second_Name);
                ordenSql.Parameters.AddWithValue("@Last_Name", emp.Last_Name);
                ordenSql.Parameters.AddWithValue("@Middle_Name", emp.Middle_Name);
                ordenSql.Parameters.AddWithValue("@Addres", emp.Addres);
                ordenSql.Parameters.AddWithValue("@Cellphone", emp.Cellphone);
                ordenSql.Parameters.AddWithValue("@Email", emp.Email);

                respuesta =ordenSql.ExecuteNonQuery();
                CerrarConexion(con);
                return respuesta;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        /// <summary>
        /// Metodo para obtener el objeto por numero de documento
        /// </summary>
        /// <param name="Num_Id"></param>
        /// <returns></returns>
        public EmployeeObject GetEmployee (string Num_Id)
        {
            try
            { 
                var con = ObtenerConexion();
                EmployeeObject obj = new EmployeeObject();
                SqlCommand ordenSql = new SqlCommand("GETEMPLOYEE", con);
                ordenSql.CommandType = System.Data.CommandType.StoredProcedure;
                ordenSql.Parameters.AddWithValue("@Num_Id", Num_Id);
                SqlDataReader lector = ordenSql.ExecuteReader();
                while (lector.Read())
                {
                    
                    obj.Tip_Id = lector["Tip_Id"].ToString();
                    obj.Num_Id = lector["Num_Id"].ToString();
                    obj.First_Name = lector["First_Name"].ToString();
                    obj.Second_Name = lector["Second_Name"].ToString();
                    obj.Middle_Name = lector["Middle_Name"].ToString();
                    obj.Last_Name = lector["Last_Name"].ToString();
                    obj.Second_Name = lector["Second_Name"].ToString();
                    obj.Addres = lector["Addres"].ToString();
                    obj.Cellphone = lector["Cellphone"].ToString();
                    obj.Email = lector["Email"].ToString();
                    
                }
                CerrarConexion(con);
                return obj;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
