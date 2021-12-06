using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanFitnessProjectClasses
{
    public class PotentialClientClass : PersonClass
    {
        protected string address;
        protected bool onEmailList;
        public PotentialClientClass(string firstName, string lastName, string dateOfBirth,
            string emailAddress, string address, bool onEmailList)
            : base(firstName, lastName, dateOfBirth, emailAddress)

        {
            //EmailValidation
            Regex validate_emailaddress = DataValidation.EmailValidation();

            if (validate_emailaddress.IsMatch(emailAddress) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool validate_Address = DataValidation.IsStringInvalid(address);
            if (validate_Address != true)
            {
                MessageBox.Show("Invalid Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        

    }
}
