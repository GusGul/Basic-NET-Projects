using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.System.Models
{
    internal class SuiteModel
    {
        public string SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerDay { get; set; }

        public SuiteModel(string suiteType, int capacity, decimal pricePerDay)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            PricePerDay = pricePerDay;
        }
    }
}
