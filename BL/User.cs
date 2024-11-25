using System.Data;
using DAL;
namespace BL
{
    public class User
    {
        string Username;
        string Password;
        bool IsActive;
        int PersonID;

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
        public DataTable GetAllUsers()
        {
            return UserDAL.GetAllUsers();
        }

        //ADD User 


    }
}
