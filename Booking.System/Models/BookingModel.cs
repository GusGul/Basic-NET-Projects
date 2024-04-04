using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.System.Models
{
    internal class BookingModel
    {
        private List<PersonModel> _guests;
        private SuiteModel _suite;
        public int ReservedDays { get; set; }

        public BookingModel(int reservedDays)
        {
            ReservedDays = reservedDays;
            _guests = new List<PersonModel>();
        }

        public List<PersonModel> Guests
        {
            get => _guests;
            set => _guests = value;
        }
        public SuiteModel Suite
        {
            get => _suite;
            set => _suite = value;
        }

        public void AddGuest(PersonModel guest)
        {
            _guests.Add(guest);
        }

        public void AddGuests(List<PersonModel> guests)
        {
            _guests.AddRange(guests);
        }

        public void RemoveGuest(PersonModel guest)
        {
            _guests.Remove(guest);
        }

        public void AddSuite(SuiteModel suite)
        {
            _suite = suite;
        }

        public int GetTotalGuests()
        {
            return _guests.Count;
        }

        public decimal CalculateTotalPrice()
        {
            return _suite.PricePerDay * ReservedDays;
        }
    }
}
