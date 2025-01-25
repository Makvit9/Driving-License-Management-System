using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.People_Screens.Validators
{
    public static class Validators
    {

        public static bool IsEmailValid(string EmailAddress)
        {
            Regex rgx = new Regex(@"^[A-Z0-9a-z._%+-]{2,63}@(?:[A-Za-z0-9-]{1,125}\.)+[A-Za-z]{2,63}$");

            return rgx.IsMatch(EmailAddress);
        }

        public static bool ContainsNumbersOnly(string number) => 
            Regex.IsMatch(number, "[^0-9]");

        public static bool IsTheCellEmpty(string value) => 
            string.IsNullOrEmpty(value);

        public static bool IsPhoneNumberLengthCorrect(string phoneNumber , int requiredLength = 10) =>
            (phoneNumber.Length == requiredLength);




    }
}
