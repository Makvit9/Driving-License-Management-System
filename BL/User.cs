using System;
using System.Data;
using BL.Settings;
using System.Security.Cryptography;
using DAL;
using static BL.Person;
using System.Net.Http.Headers;
using BL.Services;
namespace BL
{
    public class User
    {



        private string _username;
        private string _password;
        private string _salt;
        private int _personid;
        private int _userid;
        private bool _isActive;
        public enum enmode { AddNew = 0, Update= 1  };
        public string Username { get => _username;  }
        public string Password { get => _password; }
        byte[] Salt;
        public bool IsActive { get; set; }

        public Person PersonInfo;
        public int PersonID { get => _personid; }
        public enmode Mode;
        public int UserID { get => _userid; }

        private string stringSalt { get => _salt; }
        

        


        public User()
        {
            _personid = -1;
            _username = "";
            _password = "";
            _isActive = true;

            Mode = enmode.AddNew;
        }
        public User(int PersonID, string Username, bool IsActive)
        {
            this.PersonInfo.PersonID = PersonID;
            _username  = Username;
            _isActive = IsActive;

            Mode = enmode.Update;
        }

        public User(int PersonID, string Username, string Password, bool IsActive)
        {
            _personid = PersonID;
            _username = Username;
            _password = HashPassword(Password);
            _isActive = IsActive;

            Mode = enmode.Update;

        }

        private User(string Username)
        {
            _username = Username;
        }

        private string HashPassword(string Password) => _password = Services.HashService.HashPassword(Password, out Salt);
        


        public User(int UserID, int PersonID, string Username, bool IsActive)
        {
            _userid = UserID;
            _personid = PersonID;
            _username = Username;
            _isActive = IsActive;

            Mode = enmode.Update;

        }

        // Get All Users -- DONE
        public static DataTable GetAllUsers()
        {
            return UserDAL.GetAllUsers();
        }

        //ADD User (Done_ But needs some fixing) 

        private bool _AddNewUser()
        {
            _password = HashPassword(Password);
            _salt = Convert.ToBase64String(Salt); 
            _userid = UserDAL.AddNewUser(this.PersonID,this.Username,this.Password,this.IsActive, stringSalt);


            
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






        //Update 
        
        public static bool UpdatePassword(int UserID, string NewPassword)
        {
            byte[] tempSalt;
            string stringSalt;
            NewPassword = HashService.HashPassword(NewPassword, out tempSalt);

            stringSalt = Convert.ToBase64String(tempSalt);

            return UserDAL.UpdateUserPassword(UserID, NewPassword, stringSalt);
        }



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
        public static User FindUser(string Username, string Password)
        {
            if (!UserDAL.IsUsernameExists(Username)) return null;

            User selectedUser = new User(Username);
            UserDAL.GetUserInfoByUsername(Username,  ref selectedUser._userid,  ref selectedUser._personid,  ref selectedUser._password,  ref selectedUser._salt,  ref selectedUser._isActive);
            
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


    }
}
