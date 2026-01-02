using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class FestivalLuckyDraw
    {
        public static void Main(string[] args)
        {
            int luckyNumber;
            string choice = "yes";

            Console.WriteLine("Welcome to Diwali Mela Lucky Draw");
            Console.WriteLine();

            while (choice == "yes")
            {
                Console.WriteLine("Enter your lucky number:");

                bool isValid = int.TryParse(Console.ReadLine(), out luckyNumber);

                // Invalid input check
                if (!isValid || luckyNumber <= 0)
                {
                    Console.WriteLine("Invalid number! Try again.\n");
                    continue;
                }

                // Lucky draw condition
                if (luckyNumber % 3 == 0 && luckyNumber % 5 == 0)
                {
                    Console.WriteLine("Congratulations! You won a gift!");
                }
                else
                {
                    Console.WriteLine("Better luck next time!");
                }

                Console.WriteLine("\nAnother visitor? (yes/no)");
                choice = Console.ReadLine().ToLower();
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for visiting Diwali Mela");
        }
    }

}
