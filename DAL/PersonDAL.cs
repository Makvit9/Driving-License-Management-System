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
            string Email,int Nationality, string Address, string ImagePath)
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
            cmd.Parameters.AddWithValue("@NationalNumber",NationalNumber );
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email",Email );
            cmd.Parameters.AddWithValue("@Nationality",Nationality );
            cmd.Parameters.AddWithValue("@Address",Address );


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


        public static void UpdatePerson()
        {

        }

        public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName,
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
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    NationalNumber = (string)reader["NationalNumber"];
                    DateOfBirth = (DateTime)reader["BirthDate"];
                    Gender = Convert.ToChar( reader["Gender"]);                    
                  
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



        public static void GetPersonInfo()
        {

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
    }
    }


    

