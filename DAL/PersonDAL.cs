using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonDAL
    {




        // Basic Crud 

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName,
            string NationalNumber, DateTime DateOfBirth, char Gender, string Phone,
            string Email,string Nationality, string Address, string ImagePath)
        {
            int PersonID = -1;
            
            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);
           
            string Query = @"INSERT INTO PEOPLE 
                             VALUES (@FirstName , @SecondName , @ThirdName , @LastName , @NationalNumber,
                             @Gender, @DateOfBirth, @Phone, @Email , @Nationality, @Address, @ImagePath 
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


            if (ImagePath != "")
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


        public static void RemovePerson()
        {

        }


        public static void UpdatePerson()
        {

        }

        public static bool FindPerson(int NationalNumber)
        {


            return true;
        }

        public static void GetPersonInfo()
        {

        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = "SELECT Found=1 FROM Contacts WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContactID", PersonID);

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

