using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanFitnessProjectClasses
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();           
        }
        public static WelcomePage RefToWelcomePage;
        

        public void firstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createPerson_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string dateOfBirth = dateOfBirthBox.Text;
            string emailAddress = emailAddressBox.Text;
            PersonClass person1 = new(firstName, lastName, dateOfBirth, emailAddress);

            //EmailValidation
            Regex validate_emailaddress = DataValidation.EmailValidation();

            if (validate_emailaddress.IsMatch(emailAddress) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else Displays.Display1(firstName, lastName, dateOfBirth, emailAddress);
        }

        private void addToEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameBox.Text) || string.IsNullOrEmpty(lastNameBox.Text))
            {
                MessageBox.Show("We would absolutley love to add you" +
                    " to our email list, but before we do...Please fill in any data missing above.");
            }
            else
            {
                addressBox.Visible = true;
                addressLabel.Visible = true;
                submitAddress.Visible = true;
                addressBox.Text = "";
            }
            
        }

        private void submitAddress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressBox.Text))
            {
                MessageBox.Show("We may need your address for awesome bonuses and gifts" +
                    " Please finish filling in your address above.");
            }
            else
            {
                MessageBox.Show("Boom we are so excited for you!");
            }
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string dateOfBirth = dateOfBirthBox.Text;
            string emailAddress = emailAddressBox.Text;
            string address = addressBox.Text;
            bool onEmailList = true;

            PotentialClientClass potentialClient1 = new(firstName, lastName, dateOfBirth, emailAddress, address, onEmailList);

            bool validate_Address = DataValidation.IsStringInvalid(address);
            if (validate_Address != true)
            {
                MessageBox.Show("Invalid Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                addressBox.Focus();
                return;
            }

            Displays.Display2(firstName, lastName, dateOfBirth, emailAddress, address, onEmailList);

            phoneNumberLabel.Visible = true;
            phoneNumberBox.Visible = true;
            createClient.Visible = true;
        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void createClient_Click(object sender, EventArgs e)
        {

            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string dateOfBirth = dateOfBirthBox.Text;
            string emailAddress = emailAddressBox.Text;
            string address = addressBox.Text;
            bool onEmailList = true;
            string clientID = "1001";
            string phoneNumber = phoneNumberBox.Text;
            ClientClass Client1 = new(firstName, lastName, dateOfBirth,
                emailAddress, address, onEmailList, clientID, phoneNumber);
            Regex validate_phoneNumber = DataValidation.PhoneNumberValidation();

            if (validate_phoneNumber.IsMatch(phoneNumber) != true)
            {
                MessageBox.Show("Invalid Phone Number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Displays.Display3(firstName, lastName, dateOfBirth, emailAddress, address, onEmailList, clientID, phoneNumber);
        }
}
    
}
