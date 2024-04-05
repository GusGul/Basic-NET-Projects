using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.System.Models
{
    internal abstract class Smartphone
    {
        public string PhoneNumber { get; set; }
        public string Model { get; set; }
        public string IMEI { get; set; }
        public int Memory { get; set; }

        public Smartphone(string phoneNumber, string model, string iMEI, int memory)
        {
            PhoneNumber = phoneNumber;
            Model = model;
            IMEI = iMEI;
            Memory = memory;
        }

        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber}...");
        }

        public void ReceiveCall(string phoneNumber)
        {
            Console.WriteLine($"Receiving call from {phoneNumber}...");
        }

        public abstract void InstallApp(string appName);
    }
}
