using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanFitnessProjectClasses
{
    public class Displays
    {
        public static void Display1(string firstName, string lastName, string dateOfBirth,
           string emailAddress)
        {
            {

                MessageBox.Show($"Hello {firstName} {lastName}! You were " +
                $"born on {dateOfBirth} and this is your email address: {emailAddress}." +
                $" Click Add Me if you want to be added to our email list and if" +
                $" you might be interested in training with us!");



            }



        }
        public static void Display2(string firstName, string lastName, string dateOfBirth,
           string emailAddress, string address, bool onEmailList)
        {
            bool validate_Address = DataValidation.IsStringInvalid(address);
            if (validate_Address != true)
            {
                MessageBox.Show("Invalid Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show($"Awesome {firstName} {lastName}! You are now on our email list!" +
                $" We will be emailing you at {emailAddress}. And maybe even sending you some REAL mail" +
                $" at the following address: { address }." +
                $" We hope that you'll be training with us soon! " +
                $"Enter your phone number below and click the button to schedule your first session!");
            }
        }

        public static void Display3(string firstName, string lastName, string dateOfBirth,
           string emailAddress, string address, bool onEmailList, string clientID, string phoneNumber)
        {
            MessageBox.Show($"Wow. you are moving fast {firstName} {lastName}! And you are client number " +
                $"{ clientID }!!!!" +
            $" We will be contacting you shortly at the following number: { phoneNumber }." +
            $" Welcome to the family! We can't wait to see you!"); 

        }
    }
}

