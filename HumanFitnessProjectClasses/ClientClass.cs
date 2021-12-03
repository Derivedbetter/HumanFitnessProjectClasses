using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanFitnessProjectClasses
{
    public class ClientClass : PotentialClientClass
    {
        public ClientClass(string firstName, string lastName, string dateOfBirth,
            string emailAddress, string address, bool onEmailList, bool signedWaiver,
            string clientID, string phoneNumber, int sessionsLeft, string height,
            string weight, int bMI)
            : base (firstName, lastName, dateOfBirth, emailAddress, address, onEmailList)
        {
            signedWaiver = signedWaiver;
            clientID = clientID;
            phoneNumber = phoneNumber;
            sessionsLeft = sessionsLeft;
            height = height;
            weight = weight;
            bMI = bMI;
        }
        public bool signedWaiver { get; set; }
        public string clientID { get; set; }
        public string phoneNumber { get; set; }
        public int sessionsLeft { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public int bMI { get; set; }
    }
}
