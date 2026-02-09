using System;

namespace HealthCare.Utils
{
    class InputHelper
    {
        public static int ReadInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        public static DateTime ReadDate(string message)
        {
            DateTime date;
            while (true)
            {
                Console.Write(message);
                if (DateTime.TryParse(Console.ReadLine(), out date))
                    return date;

                Console.WriteLine("Invalid date format.");
            }
        }

        public static string ReadRequired(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(input));

            return input;
        }
    }
}
