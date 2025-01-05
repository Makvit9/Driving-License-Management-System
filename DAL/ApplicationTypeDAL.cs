using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Settings;
using System.Net;

namespace DAL
{
    public class ApplicationTypeDAL
    {



        public static DataTable GetAllApplications()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = "Select * From ApplicationTypes";

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

        public static bool GetApplicationTypeInfo(int ApplicationTypeID, ref string ApplicationTypeName, ref decimal ApplicationTypeFees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);


            string Query = @"SELECT * from ApplicationTypes 
                            WHERE ApplicationTypeID = @ApplicationTypeID";


            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ApplicationTypeName = (string)reader["ApplicationTypeName"];
                    ApplicationTypeFees = (Decimal)reader["Price"];

                    reader.Close();
                }
                }
            catch (Exception)
            {

                isFound = false;
            }
            return isFound;
        }


        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeName, decimal ApplicationTypeFees)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"Update  ApplicationTypes  
                            set ApplicationTypeName = @ApplicationTypeName,
                                Price = @ApplicationTypeFees
                                where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeName", ApplicationTypeName);
            command.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
    }
}
