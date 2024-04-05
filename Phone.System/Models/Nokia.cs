using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.System.Models
{
    internal class Nokia : Smartphone
    {
        public Nokia(string phoneNumber, string model, string iMEI, int memory) : base(phoneNumber, model, iMEI, memory)
        {
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing {appName} on {Model} using PlayStore...");
        }
    }
}
