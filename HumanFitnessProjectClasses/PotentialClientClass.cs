using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanFitnessProjectClasses
{
    public class PotentialClientClass : PersonClass
    {
        public PotentialClientClass(string firstName, string lastName, string dateOfBirth,
            string emailAddress, string address, bool onEmailList)
            : base(firstName, lastName, dateOfBirth, emailAddress)
        {
            address = address;
            onEmailList = onEmailList;
        }
        public string address { get; set; }
        public bool onEmailList { get; set; }

    }
}
