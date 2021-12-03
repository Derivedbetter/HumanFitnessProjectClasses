using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanFitnessProjectClasses
{
    public class ReadyToRenewClientClass : ClientClass
    {
        public ReadyToRenewClientClass(string firstName, string lastName, string dateOfBirth,
            string emailAddress, string address, bool onEmailList, bool signedWaiver,
            string clientID, string phoneNumber, int sessionsLeft, string height,
            string weight, int bMI, bool renewalMessageSent, bool sessionsAdded)
            : base(firstName, lastName, dateOfBirth, emailAddress, address, onEmailList,
                  signedWaiver, clientID, phoneNumber, sessionsLeft, height, weight, bMI)
        {
            renewalMessageSent = renewalMessageSent;
            sessionsAdded = sessionsAdded;
        }
        public bool renewalMessageSent { get; set; }
        public bool sessionsAdded { get; set; }
        
    }
}
