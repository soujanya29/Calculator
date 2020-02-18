using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.DataAccessLayer.ADO
{
   public class CalculatorAdo : ICalculatorAdo
    {

        private readonly string _connectionString;

        public CalculatorAdo(string connectionString)
        {
            _connectionString = connectionString;
        }


        public bool InsertResults(int type, int input_1, int input_2, int result)
        {
           

            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddResult";
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            cmd.Parameters.Add("@input_1", SqlDbType.Int).Value = input_1;
            cmd.Parameters.Add("@input_2", SqlDbType.Int).Value = input_2;
            cmd.Parameters.Add("@result", SqlDbType.Decimal).Value = result;
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
