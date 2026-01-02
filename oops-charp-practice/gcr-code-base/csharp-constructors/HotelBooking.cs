using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_constructors
{
    internal class HotelBooking
    {
        private string guestName;
        private string roomType;
        private int nights;

        // Default Constructor
        public HotelBooking()
        {
            this.guestName = "Guest";
            this.roomType = "Standard";
            this.nights = 1;
        }

        // Parameterized Constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        // Copy Constructor
        public HotelBooking(HotelBooking other)
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }

        public void Display()
        {
            Console.WriteLine("Guest Name : " + guestName);
            Console.WriteLine("Room Type  : " + roomType);
            Console.WriteLine("Nights     : " + nights);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Default Booking:");
            HotelBooking booking1 = new HotelBooking();
            booking1.Display();

            Console.WriteLine();

            Console.WriteLine("Parameterized Booking:");
            HotelBooking booking2 = new HotelBooking("Anoop", "Deluxe", 3);
            booking2.Display();

            Console.WriteLine();

            Console.WriteLine("Copied Booking:");
            HotelBooking booking3 = new HotelBooking(booking2);
            booking3.Display();
        }
    }
}
