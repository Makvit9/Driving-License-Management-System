using System;
using System.Net;
using System.Security.Policy;
using DAL;

namespace BL
{
    public class Person
    {
        enum enMode { Addnew =  1, Update = 2};


        private string FirstName { get; }
        private string SecondName { get; }
    
        private string ThirdName { get; }
        private string LastName { get; }
        private string NationalNumber { get; }

        private DateTime DateOfBirth { get; }
        private byte Gender { get; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Nationality { get; }
        public string Address { get; }

        Person()
        {
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            NationalNumber ="" ;
            DateOfBirth = DateTime.Now;
            Gender = 0;
            Phone = "";
            Email = "";
            Nationality = "";
            Address = "";
        }

        Person(string firstname, string secondname, string thirdname, string finalname,
            string nationalNumber, DateTime dateofbirth, byte gender, string phone,
            string email, string nationality, string address)
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
            Nationality = nationality;
            Address = address;
        }



    }
}
