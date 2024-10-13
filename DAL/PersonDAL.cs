using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonDAL
    {


        // Basic Crud 

        public static void AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName,
            string NationalNumber, DateTime DateOfBirth, byte Gender, string Phone,
            string Email,string Nationality, string Address )
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString.connectionString);
           
            string Query = "INSERT INTO People " +
                "VALUES ( @FirstName , @SecondName , @ThirdName , @LastName , @NationalNumber," +
                "@DateOfBirth, @Gender, @Phone, @Email , @Nationality, @Address, ";

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
    }
}
