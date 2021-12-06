using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanFitnessProjectClasses
{
    public class PersonClass
    {
        protected string firstName;
        protected string lastName;
        protected string dateOfBirth;
        protected string emailAddress;


        public PersonClass(string firstName, string lastName, string dateOfBirth,
            string emailAddress)
        {
            //EmailValidation
            Regex validate_emailaddress = DataValidation.EmailValidation();

            if (validate_emailaddress.IsMatch(emailAddress) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

            
                
        }

        

        }
        }
    

