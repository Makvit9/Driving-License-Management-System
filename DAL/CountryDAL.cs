using DAL.Settings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CountryDAL
    {
        public static DataTable GetCountriesList()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);

            string Query = "SELECT Name FROM Countries";

            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

                reader.Close();
            }
            catch (Exception)
            {

                return null;
            }

            finally { connection.Close(); }

            return dataTable;
        }

        public static bool GetInfoByCountryName(string countryName, ref int iD, ref string code)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);

            string Query = @"Select * from Countries where CountryName like \'@CountryName%\'";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@CountryName", countryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    iD = Convert.ToInt32(reader["CountryID"]);

                    
                    if (reader["IsoCode"] != DBNull.Value)
                        code = (string)reader["IsoCode"];
                    else
                        code = "";



                }


            }
            catch (Exception e)
            {

                IsFound = false;
            }

            finally { connection.Close(); }

            return IsFound;
        }
    
        public static int GetCountryID(string countryName)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);

            string Query = "SELECT ID FROM Countries where CountryName = @countryName";

            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();


            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }
    
    
    
    }
}
