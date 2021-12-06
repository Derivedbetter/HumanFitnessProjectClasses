using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HumanFitnessProjectClasses
{

    public class DataValidation
    {
        public static Regex EmailValidation()//Validates email address.
        {//static Regex validate_emailaddress = email_validation();
         //
         //}
         //email validation method
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public static bool IsStringInvalid(string text)
        {
            if (text != null && text.Length > 4)
            {
                return true;
            }
            else return false;

        }

        public static Regex PhoneNumberValidation()
        {
            string pattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }


    }
}
