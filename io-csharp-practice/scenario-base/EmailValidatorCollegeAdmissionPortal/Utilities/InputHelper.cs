using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EmailValidatorCollegeAdmissionPortal.Models;

namespace EmailValidatorCollegeAdmissionPortal.Utilities
{
    class InputHelper
    {
        // take int input
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

        // take string input
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