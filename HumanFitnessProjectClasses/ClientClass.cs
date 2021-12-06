using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanFitnessProjectClasses
{
    public class ClientClass : PotentialClientClass
    {
        protected string clientID;
        protected string phoneNumber;

        public ClientClass(string firstName, string lastName, string dateOfBirth,
            string emailAddress, string address, bool onEmailList,
            string clientID, string phoneNumber)
            : base (firstName, lastName, dateOfBirth, emailAddress, address, onEmailList)
        {
            clientID = "1001";
            Regex validate_phoneNumber = DataValidation.PhoneNumberValidation();

            if (validate_phoneNumber.IsMatch(phoneNumber) != true)
            {
                MessageBox.Show("Invalid Phone Number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

           

        }
        
    }
}
