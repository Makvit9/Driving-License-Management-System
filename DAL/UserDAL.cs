using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {



        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = "Select * From Users";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {

                connection.Close();
            }
            return dt;
        }


    }
}
