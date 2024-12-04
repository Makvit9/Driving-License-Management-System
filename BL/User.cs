using System;
using System.Data;
using BL.Settings;
using System.Security.Cryptography;
using DAL;
namespace BL
{
    public class User
    {
        string Username;
        string Password;
        byte[] Salt;
        bool IsActive;
        int PersonID;


        static HashAlgorithmName HashName => HashAlgorithmName.SHA512;

        public string HashPassword(string Password, out byte[] salt)
        {
            //create the salt and fill with random bits 
            RandomNumberGenerator rnd = RandomNumberGenerator.Create();
            salt = new byte[HashSettings.KEYSIZE];
            rnd.GetBytes(salt);
            //Salt done
            var Hash = new Rfc2898DeriveBytes(Password, salt, HashSettings.ITERATIONS, HashName).GetBytes(HashSettings.KEYSIZE);


            return Convert.ToBase64String(Hash);
        }


        public User()
        {
            PersonID = -1;
            Username = "";
            Password = "";
            IsActive = false;
        }

        public User(int PersonID, string Username, string Password, bool IsActive)
        {
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
        }


        // Get All Users -- DONE
        public static DataTable GetAllUsers()
        {
            return UserDAL.GetAllUsers();
        }

        //ADD User 

        //Delete

        //Update 

        //Find User
        public static bool FindUser(string Username, string Password)
        {
            return UserDAL.FindUser(Username, Password);
        }



    }
}
