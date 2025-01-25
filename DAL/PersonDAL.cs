using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonDAL
    {




        // Basic Crud 

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName,
            string NationalNumber, DateTime DateOfBirth, char Gender, string Phone,
            string Email, int Nationality, string Address, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = @"INSERT INTO PEOPLE (FirstName, SecondName, ThirdName, LastName, nationalnumber, BirthDate, Gender, phoneNumber, email, Country_ID, address, Picturepath)
                             VALUES (@FirstName , @SecondName , @ThirdName , @LastName , @NationalNumber,
                             @DateOfBirth,@Gender, @Phone, @Email , @Nationality, @Address, @ImagePath )
                             Select Scope_Identity()";


            SqlCommand cmd = new SqlCommand(Query, connection);


            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Nationality", Nationality);
            cmd.Parameters.AddWithValue("@Address", Address);


            if (ImagePath != null)
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);



            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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


            return PersonID;


        }


        public static bool RemovePerson(int PersonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"Delete from People 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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


        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName,
           string ThirdName, string LastName, string NationalNumber, DateTime BirthDate,
           char Gender, string Address, string PhoneNumber, string Email,
            int Country_ID, string PicturePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"Update  People  
                            set FirstName = @FirstName,
                                SecondName = @SecondName,
                                ThirdName = @ThirdName,
                                LastName = @LastName, 
                                NationalNumber = @NationalNumber,
                                BirthDate = @BirthDate,
                                Gender=@Gender,
                                PhoneNumber = @PhoneNumber,
                                Email = @Email, 
                                Country_ID = @Country_ID,
                                Address = @Address,  
                                PicturePath =@PicturePath
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);


            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Country_ID", Country_ID);

            if (PicturePath != "" && PicturePath != null)
                command.Parameters.AddWithValue("@PicturePath", PicturePath);
            else
                command.Parameters.AddWithValue("@PicturePath", System.DBNull.Value);


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


        public static bool GetPersonInfoByID( int PersonID, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref string NationalNumber,
            ref DateTime DateOfBirth, ref char Gender, ref string Phone, ref string Email,
            ref int Country_ID, ref string Address, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                    ThirdName = (string)reader["ThirdName"];

                    }
                    else
                    {
                        ThirdName = "";
                    }
                    LastName = (string)reader["LastName"];
                    NationalNumber = (string)reader["NationalNumber"];
                    DateOfBirth = (DateTime)reader["BirthDate"];
                    Gender = Convert.ToChar(reader["Gender"]);

                    Phone = (string)reader["phoneNumber"];
                    Email = (string)reader["Email"];
                    Country_ID = (int)reader["Country_ID"];
                    Address = (string)reader["Address"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["Picturepath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["Picturepath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

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



        public static bool GetPersonInfoByNationalNumber (ref string NationalNumber, ref int PersonID, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName,
            ref DateTime DateOfBirth, ref char Gender, ref string Phone, ref string Email,
            ref int Country_ID, ref string Address, ref string ImagePath)
        {

            bool isFound = false;

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);


            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "FindPersonByNationalNumber";

            cmd.Parameters.AddWithValue("@NationalNumber", NationalNumber);



            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];

                    }
                    else
                    {
                        ThirdName = "";
                    }
                    LastName = (string)reader["LastName"];
                    NationalNumber = (string)reader["NationalNumber"];
                    DateOfBirth = (DateTime)reader["BirthDate"];
                    Gender = Convert.ToChar(reader["Gender"]);

                    Phone = (string)reader["phoneNumber"];
                    Email = (string)reader["Email"];
                    Country_ID = (int)reader["Country_ID"];
                    Address = (string)reader["Address"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["Picturepath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["Picturepath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

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

        public static bool IsPersonExist(string NationalNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNumber = @NationalNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

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



        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = "Select * From People";

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


        public static bool IsThePersonLinkedWithUser(int PersonID)
        {
            bool IsLinked = false;


            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = @"
                            Select Found =1 from People
                            inner join Users
                            on Users.PersonID = People.PersonID
                            where People.PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                IsLinked = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {

                IsLinked = false;
            }
            finally
            {
                connection.Close();
            }

            return IsLinked;

        }


    }


    

}

    

