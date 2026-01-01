using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class CafeteriaSystem
    {
        static void DisplayMenu()
        {
            Cafeteria cafe = new Cafeteria();
            Console.WriteLine("---- Cafeteria Menu ----");

            for (int i = 0; i < cafe.MenuItems.Length; i++)
            {
                Console.WriteLine($"{i}. {cafe.MenuItems[i]} - Rs.{cafe.Prices[i]}");
            }
        }

        static int GetItemByIndex()
        {
            Cafeteria cafe = new Cafeteria();
            Console.WriteLine("Enter item index:");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < cafe.MenuItems.Length)
            {
                return index;
            }

            Console.WriteLine("Invalid index. Try again.");
            return GetItemByIndex();
        }

        static int TakeOrder()
        {
            Cafeteria cafe = new Cafeteria();
            int totalAmount = 0;

            DisplayMenu();

            Console.WriteLine("How many items do you want to order?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int index = GetItemByIndex();
                totalAmount += cafe.Prices[index];

                Console.WriteLine($"{cafe.MenuItems[index]} added to cart");
                Console.WriteLine($"Current Total: Rs.{totalAmount}");
            }

            return totalAmount;
        }

        static void MakePayment(int totalAmount)
        {
            Console.WriteLine($"Total Bill Amount: Rs.{totalAmount}");
            Console.WriteLine("Enter payment amount:");
            int payment = int.Parse(Console.ReadLine());

            if (payment >= totalAmount)
            {
                Console.WriteLine("Payment Successful");
                Console.WriteLine($"Return Amount: Rs.{payment - totalAmount}");
            }
            else
            {
                Console.WriteLine("Insufficient amount. Please pay again.");
                MakePayment(totalAmount);
            }
        }

        public static void Main(string[] args)
        {
            int totalBill = TakeOrder();
            MakePayment(totalBill);
            Console.WriteLine("Thank you for ordering from Cafeteria");
        }
    }

    public class Cafeteria
    {
        public string[] MenuItems = new string[10]
        {
            "Veg Sandwich",
            "Cheese Burger",
            "Pasta",
            "Fried Rice",
            "Paneer Roll",
            "Cold Coffee",
            "Tea",
            "Samosa",
            "Pizza Slice",
            "Ice Cream"
        };

        public int[] Prices = new int[10]
        {
            50,   // Veg Sandwich
            120,  // Cheese Burger
            100,  // Pasta
            90,   // Fried Rice
            70,   // Paneer Roll
            60,   // Cold Coffee
            20,   // Tea
            15,   // Samosa
            80,   // Pizza Slice
            40    // Ice Cream
        };
    }
}
