using System.Text;
using Booking.System.Models;

Console.OutputEncoding = Encoding.UTF8;

List<PersonModel> guests = new List<PersonModel>();

PersonModel person1 = new PersonModel("John", "Doe", 25);
PersonModel person2 = new PersonModel("Jane", "Doe", 23);
PersonModel person3 = new PersonModel("Alice", "Doe", 5);

guests.Add(person1);
guests.Add(person2);
guests.Add(person3);

SuiteModel suite = new SuiteModel("Luxury", 4, 1000);

BookingModel booking = new BookingModel(5);
booking.AddGuests(guests);
booking.AddSuite(suite);

Console.WriteLine($"Total guests: {booking.GetTotalGuests()}");
Console.WriteLine($"Total price: {booking.CalculateTotalPrice()}");