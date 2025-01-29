using System;
using System.Data;
using BL.Settings;
using System.Security.Cryptography;
using DAL;
using static BL.Person;
using System.Net.Http.Headers;
using BL.Services;
using System.Text;
namespace BL
{
    public class User
    {



        
        public enum enmode { AddNew = 0, Update= 1  };
        public string Username { get; set; }
        public string Password { get; set; }
        byte[] Salt;
        public bool IsActive { get; set; }

        public Person PersonInfo;
        public int PersonID { get; set; }
        public enmode Mode;
        public int UserID { get; set; }

        private string stringSalt { get; set; }
       

        public User()
        {
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = true;

            Mode = enmode.AddNew;
        }
       
        public User(int PersonID, string Username, bool IsActive)
        {
            this.PersonInfo.PersonID = PersonID;
            this.Username  = Username;
            this.IsActive= IsActive;

            Mode = enmode.Update;
        }

        public User(int PersonID, string Username, string Password, bool IsActive)
        {
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = HashPassword(Password);
            this.IsActive = IsActive;

            Mode = enmode.Update;

        }
         
        public User(int UserID, int PersonID, string Username, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.IsActive = IsActive;

            Mode = enmode.Update;

        }

        public User(int userID, int personID, string username, string password, string salt, bool isActive)
        {
            this.UserID = userID;
            this.PersonID = personID;
            this.Username = username;
            this.Password = password;
            this.stringSalt= salt;
            this.IsActive = isActive;
        }

        private string HashPassword(string Password) => this.Password = Services.HashService.HashPassword(Password, out Salt);

        public static DataTable GetAllUsers()
        {
            return UserDAL.GetAllUsers();
        }

        private bool _AddNewUser()
        {
            Password = HashPassword(Password);
            stringSalt = Convert.ToBase64String(Salt); 
            UserID = UserDAL.AddNewUser(this.PersonID,this.Username,this.Password,this.IsActive, stringSalt);


            
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return UserDAL.UpdateUser(this.PersonID, this.UserID, this.Username, this.IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enmode.AddNew: 
                    return _AddNewUser();

                case enmode.Update:
                    return _UpdateUser();
                
            }
            return true;
        }
                
        public static bool UpdatePassword(int UserID, string NewPassword)
        {
            byte[] tempSalt;
            string stringSalt;
            NewPassword = HashService.HashPassword(NewPassword, out tempSalt);

            stringSalt = Convert.ToBase64String(tempSalt);

            return UserDAL.UpdateUserPassword(UserID, NewPassword, stringSalt);
        }

        public static bool DeleteUser(int UserID)
        {

            return UserDAL.RemoveUser(UserID);
        }


        public static User FindUser(int UserID)
        {

            int PersonID = 0; string Username = ""; bool IsActive = false;

             UserDAL.GetUserInfoByID(UserID,ref PersonID,ref Username,ref IsActive);

            return new User(UserID, PersonID, Username, IsActive);
        
        }
        public static User FindUser(string Username)
        {
            if (!UserDAL.IsUsernameExists(Username)) return null;

            //User selectedUser = new User(Username);

            int UserID = -1;
            int PersonID = -1;
            string Password = "";
            string Salt = "";
            bool IsActive = false;

            UserDAL.GetUserInfoByUsername(Username,  ref UserID, ref PersonID,  ref Password,  ref Salt,  ref IsActive);

            return new User(UserID, PersonID, Username, Password, Salt, IsActive);


            //return UserDAL.FindUser(Username, Password);
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


        public bool IsTheLoginValid(string enteredPassword)
        {
            this.Salt = Convert.FromBase64String(this.stringSalt);
            string NewHash = HashService.HashPassword(enteredPassword, this.Salt);

            return NewHash == this.Password;
        }



    }
}
