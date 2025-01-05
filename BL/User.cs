using System;
using System.Data;
using BL.Settings;
using System.Security.Cryptography;
using DAL;
using static BL.Person;
using System.Net.Http.Headers;
namespace BL
{
    public class User
    {
        public enum enmode { AddNew = 0, Update= 1  };
        public string Username { get; set; }
        public string Password { get; set; }
        byte[] Salt;
        public bool IsActive { get; set; }
        public int PersonID { get; set; }
        public enmode mode;
        public int UserID { get; set; }

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
        public User(int PersonID, string Username, bool IsActive)
        {
            this.PersonID = PersonID;
            this.Username = Username;
            this.IsActive = IsActive;
        }

        public User(int PersonID, string Username, string Password, bool IsActive)
        {
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
        }



        public User(int UserID, int PersonID, string Username, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.IsActive = IsActive;
        }

        // Get All Users -- DONE
        public static DataTable GetAllUsers()
        {
            return UserDAL.GetAllUsers();
        }

        //ADD User (Done_ But needs some fixing) 

        private bool _AddNewUser()
        {
            this.UserID = UserDAL.AddNewUser(this.PersonID,this.Username,this.Password,this.IsActive);


            
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return UserDAL.UpdateUser(this.PersonID, this.UserID, this.Username, this.IsActive);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enmode.AddNew: 
                    return _AddNewUser();

                case enmode.Update:
                    return _UpdateUser();
                
            }
            return true;
        }






        //Update 
        

        //Delete
        public static bool DeleteUser(int UserID)
        {

            return UserDAL.RemoveUser(UserID);
        }

        //Find User

        public static User FindUser(int UserID)
        {

            int PersonID = 0; string Username = ""; bool IsActive = false;

             UserDAL.GetUserInfoByID(UserID,ref PersonID,ref Username,ref IsActive);

            return new User(UserID, PersonID, Username, IsActive);
        
        }
        public static bool FindUser(string Username, string Password)
        {
            return UserDAL.FindUser(Username, Password);
        }

        public static bool IsTheUsernameExists(string Username)
        {
            return UserDAL.IsUsernameExists(Username);
        }


        public static bool IsPersonLinkedToOtherUser(int PersonID) 
            // Expression is ( A || ^B )
        {
            return (UserDAL.IsPersonLinkedToOtherUser(PersonID) || !PersonDAL.IsPersonExist(PersonID)) ;
        }


    }
}
