using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;
using DAL.Settings;

namespace DAL
{
    public class UserDAL
    {

      

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = "Select UserID,PersonID,Username,IsActive From Users";

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



        public static bool UpdateUser(int PersonID, int UserID, string Username, bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"
                            UPDATE Users 
                            SET
                             PersonID = @PersonID,
                             Username = @Username,
                             IsActive = @IsActive
                            WHERE UserID = @UserID
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("PersonID", PersonID);
            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("Username", Username);
            command.Parameters.AddWithValue("IsActive", IsActive);



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

        public static bool UpdateUserPassword(int userID, string password, string salt)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"
                            UPDATE Users 
                            SET
                             Password = @Password,
                             Salt = @Salt
                            WHERE UserID = @UserID
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Salt", salt);



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

        public static bool FindUser(int UserID, ref int PersonID, ref string Username, ref bool IsActive)
        {
            bool IsFound = false;

            return IsFound;
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

        public static bool IsUsernameExists(string Username)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);

            string Query = @"Select Found = 1 from Users Where Username = @username ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("username", Username);

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

        public static int AddNewUser(int PersonID, string Username, string Password, bool IsActive, string salt)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = @"INSERT INTO Users 
                             VALUES (
                             @PersonID,
                             @Username,
                             @Password,
                             @Salt,
                             @IsActive
                                )
                             SELECT Scope_Identity()";


            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@Salt", salt);


            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return UserID;
        }

        public static bool IsPersonLinkedToOtherUser(int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);

            string Query = @"Select Found = 1 from Users Where PersonID = @PersonID ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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




        public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string Username, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    Username = (string)reader["Username"];


                    IsActive = (bool)reader["IsActive"];

                    //ImagePath: allows null in database so we should handle null

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool RemoveUser(int UserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"Delete from Users 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowsAffected = 0;
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);
        }






    }
}
