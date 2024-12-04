using System;
using System.Data;
using System.Data.SqlClient;
using DAL.Settings;

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


        public static bool FindUser(string username, string password)
        {
            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);

            string Query = @"Select * from Users Where Username = @username and password = @password";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }



            return false;
        }

    }
}
