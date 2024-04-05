using Phone.System.Models;

namespace Phone.System
{
    class Program
    {
        static void Main(string[] args)
        {
            Iphone iphone = new Iphone("123456789", "Iphone 12", "123456789", 128);
            iphone.Call("987654321");
            iphone.ReceiveCall("987654321");
            iphone.InstallApp("Facebook");

            Console.WriteLine("\n");

            Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321", 4);
            nokia.Call("123456789");
            nokia.ReceiveCall("123456789");
            nokia.InstallApp("Twitter");

            Console.WriteLine("\n");

            Samsung samsung = new Samsung("123456789", "Samsung Galaxy S21", "123456789", 256);
            samsung.Call("987654321");
            samsung.ReceiveCall("987654321");
            samsung.InstallApp("Instagram");
        }
    }
}