using System;
using System.Data;
using System.Net;
using System.Security.Policy;
using DAL;


namespace BL
{
    public class Person
    {
       public enum enMode { Addnew =  0, Update = 1};

        private int PersonID { get; set; }
        private string FirstName { get; }
        private string SecondName { get; }
    
        private string ThirdName { get; }
        private string LastName { get; }
        private string NationalNumber { get; }

        private DateTime DateOfBirth { get; }
        private char Gender { get; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CountryName { get; }
        public string Address { get; }

        public string ImagePath { get; }

        public enMode Mode = enMode.Addnew;
          
        
        Person()
        {
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            NationalNumber ="" ;
            DateOfBirth = DateTime.Now;
            Gender = ' ';
            Phone = "";
            Email = "";
            CountryName = "";
            Address = "";
            Mode = enMode.Addnew;
        }

        public Person(string firstname, string secondname, string thirdname, string finalname,
            string nationalNumber, DateTime dateofbirth, char gender, string phone,
            string email, string countryName, string address)
        {
            FirstName = firstname;
            SecondName = secondname;
            ThirdName = thirdname;
            LastName = finalname;
            NationalNumber = nationalNumber;
            DateOfBirth = dateofbirth;
            Gender = gender;
            Phone = phone;
            Email = email;
            CountryName = countryName;
            Address = address;

            Mode = enMode.Update;

        }
        
        
        public static DataTable GetAllPeople()
        {
            return PersonDAL.GetAllPeople();
        }
        
        
        
        private bool _AddNewPerson()
        {
                this.PersonID = PersonDAL.AddNewPerson(this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.NationalNumber, this.DateOfBirth,
                this.Gender, this.Phone, this.Email, this.CountryName,
                this.Address, this.ImagePath);

            return (this.PersonID != -1);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Addnew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    break;
                    //return _UpdateContact();

            }




            return false;
        }

    }
}
