using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using DAL.Settings;

namespace DAL
{
    public class UserDAL
    {

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = "Select UserID,PersonID,Username,IsActive From Users";

            SqlCommand cmd = new SqlCommand(Query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

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

                conn.Close();
            }
            return dt;
        }

        public static bool UpdateUser(int PersonID, int UserID, string Username, bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"
                            UPDATE Users 
                            SET
                             PersonID = @PersonID,
                             Username = @Username,
                             IsActive = @IsActive
                            WHERE UserID = @UserID
                            ";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("PersonID", PersonID);
            cmd.Parameters.AddWithValue("UserID", UserID);
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("IsActive", IsActive);



            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                conn.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool UpdateUserPassword(int userID, string password, string salt)
        {
           

            int rowsAffected = 0;
            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"
                            UPDATE Users 
                            SET
                             Password = @Password,
                             Salt = @Salt
                            WHERE UserID = @UserID
                            ";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Salt", salt);



            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                conn.Close();
            }

            return (rowsAffected > 0);
        }

        public static void GetUserInfoByUsername(string Username, ref int userID, ref int personID, ref string password, ref string salt, ref bool isActive)
        {

            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string Query = @"Select * from Users Where Username = @Username";
            SqlCommand cmd = new SqlCommand(Query, conn);

            cmd.Parameters.AddWithValue("Username", Username);
           
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    userID = (int)reader["UserID"];
                    personID = (int)reader["PersonID"];
                    password = reader["Password"].ToString();
                    salt = reader["Salt"].ToString();
                    isActive = (bool)reader["IsActive"];
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }



      
        }

        public static bool FindUser(int UserID, ref int PersonID, ref string Username, ref bool IsActive)
        {
            bool IsFound = false;

            return IsFound;
        }

        public static bool FindUser(string username, string password)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string Query = @"Select * from Users Where Username = @username and password = @password";

            SqlCommand cmd = new SqlCommand(Query, conn);

            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }



            return false;
        }

        public static bool IsUsernameExists(string Username)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string Query = @"Select Found = 1 from Users Where Username = @username ";

            SqlCommand cmd = new SqlCommand(Query, conn);

            cmd.Parameters.AddWithValue("username", Username);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }



            return false;

        }

        public static int AddNewUser(int PersonID, string Username, string Password, bool IsActive, string salt)
        {
            int UserID = -1;

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = @"INSERT INTO Users 
                             VALUES (
                             @PersonID,
                             @Username,
                             @Password,
                             @Salt,
                             @IsActive
                                )
                             SELECT Scope_Identity()";


            SqlCommand cmd = new SqlCommand(Query, conn);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@Salt", salt);


            try
            {
                conn.Open();

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
                conn.Close();
            }


            return UserID;
        }

        public static bool IsPersonLinkedToOtherUser(int PersonID)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string Query = @"Select Found = 1 from Users Where PersonID = @PersonID ";

            SqlCommand cmd = new SqlCommand(Query, conn);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }



            return false;

        }

        public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string Username, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

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
                conn.Close();
            }

            return isFound;
        }

        public static bool RemoveUser(int UserID)
        {
            int rowsAffected = 0;

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"Delete from Users 
                                where UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                conn.Open();

                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowsAffected = 0;
            }
            finally
            {

                conn.Close();

            }

            return (rowsAffected > 0);
        }

    }
}
