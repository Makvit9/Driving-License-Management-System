using BL.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    internal static class HashService
    {

        
        public static string HashPassword(string Password, out byte[] salt)
        {
            //create the salt and fill with random bits 
            RandomNumberGenerator rnd = RandomNumberGenerator.Create();
            salt = new byte[HashSettings.KEYSIZE];
            rnd.GetBytes(salt);
            //Salt done
            var Hash = new Rfc2898DeriveBytes(Password, salt, HashSettings.ITERATIONS, HashSettings.HashName).GetBytes(HashSettings.KEYSIZE);


            return Convert.ToBase64String(Hash);
        }



    }
}
