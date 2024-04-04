using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.System.Models
{
    internal class PersonModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public PersonModel(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }
}
