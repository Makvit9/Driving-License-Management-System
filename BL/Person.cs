using System;
using System.Data;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Policy;
using DAL;


namespace BL
{
    public class Person
    {
       public enum enMode { Addnew =  0, Update = 1};

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    
        public string ThirdName { get; set; }
        public string LastName { get;set; }
        public string NationalNumber { get;set; }

        public DateTime DateOfBirth { get;set; }
        public char Gender { get;set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CountryID { get; set; }
        public string Address { get; set; }

        public string ImagePath { get; set; }

        public enMode Mode = enMode.Addnew;
          
        
        public Person()
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
            CountryID = -1;
            Address = "";
            Mode = enMode.Addnew;
        }

        public Person(string firstname, string secondname, string thirdname, string finalname,
            string nationalNumber, DateTime dateofbirth, char gender, string phone,
            string email, int countryId, string address, string imagePath)
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
            CountryID = countryId;
            Address = address;
            ImagePath = imagePath;
            Mode = enMode.Update;

        }

        public Person(int personID, string firstname, string secondname, string thirdname, string finalname,
           string nationalNumber, DateTime dateofbirth, char gender, string phone,
           string email, int countryId, string address, string imagePath)
        {
            PersonID = personID;
            FirstName = firstname;
            SecondName = secondname;
            ThirdName = thirdname;
            LastName = finalname;
            NationalNumber = nationalNumber;
            DateOfBirth = dateofbirth;
            Gender = gender;
            Phone = phone;
            Email = email;
            CountryID = countryId;
            Address = address;
            ImagePath = imagePath;
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
                this.Gender, this.Phone, this.Email, this.CountryID,
                this.Address, this.ImagePath);

            return (this.PersonID != -1);
        }

        public static Person Find(int PersonID)
        {
            string firstname = "", secondname = "", thirdname = "", lastname = "", nationalnumber = "";
            string phone = "", email = "", imagePath = "",address = "";
            int countryid = -1;
            char gender = ' ';
            DateTime dateofbirth = DateTime.Now;

            if (PersonDAL.GetPersonInfoByID( PersonID, ref firstname, ref secondname, ref thirdname,
                ref lastname, ref nationalnumber, ref dateofbirth,
                ref gender, ref phone, ref email, ref countryid,
                ref address, ref imagePath))

                return new Person(PersonID, firstname, secondname, thirdname, lastname, nationalnumber, dateofbirth
                    , gender, phone, email, countryid, address, imagePath);



            return null;        
        }

        public static Person Find(string NationalNumber)
        {
            string firstname = "", secondname = "", thirdname = "", lastname = "";
            string phone = "", email = "", imagePath = "", address = "";
            int countryid = -1, personID = -1;
            char gender = ' ';
            DateTime dateofbirth = DateTime.Now;

            if (PersonDAL.GetPersonInfoByNationalNumber(ref NationalNumber, ref personID, ref firstname, ref secondname,
                ref thirdname, ref lastname, ref dateofbirth, ref gender, ref phone, ref email, ref countryid,
                ref address, ref imagePath))
            {
                return new Person(personID,firstname, secondname, thirdname, lastname, NationalNumber, dateofbirth,
                    gender, phone, email, countryid, address, imagePath);
            }
            return null;
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
                    return _updatePerson();
                    

            }




            return false;
        }


        public static bool IsPersonExist(string NationalNumber)
        {
            return PersonDAL.IsPersonExist(NationalNumber);
        }

        public static bool DeletePerson(int PersonID)
        {

            return PersonDAL.RemovePerson(PersonID) && !PersonDAL.IsThePersonLinkedWithUser(PersonID);
        }


       private bool _updatePerson()
        {
            return PersonDAL.UpdatePerson(PersonID, FirstName, SecondName,
                ThirdName, LastName, NationalNumber, DateOfBirth,
                Gender, Address, Phone, Email, CountryID, ImagePath);
        }


    }
}
