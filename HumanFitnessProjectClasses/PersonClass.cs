using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanFitnessProjectClasses
{
    public class PersonClass
    {
        public PersonClass(string firstName, string lastName, string dateOfBirth,
            string emailAddress)
        {
            firstName = firstName;
            lastName = lastName;
            dateOfBirth = dateOfBirth;
            emailAddress = emailAddress;
                
        }
        protected string firstName { get; set; }
        protected string lastName { get; set; }
        protected string dateOfBirth { get; set; }
        protected string emailAddress { get; set; }

    }
}
