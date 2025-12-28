using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction.level2
{
    internal class NumberGuessingGame
    {
        static int GenerateGuess(int low, int high)
        {
            return (low + high) / 2;
        }

        static char GetUserFeedback()
        {
            Console.Write("Is the guess High (h), Low (l), or Correct (c)? ");
            return Console.ReadLine().ToLower()[0];
        }

        static void Main(string[] args)
        {
            int low = 1;
            int high = 100;
            bool guessed = false;

            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("I will try to guess it!");

            while (!guessed && low <= high)
            {
                int guess = GenerateGuess(low, high);
                Console.WriteLine($"My guess is: {guess}");

                char feedback = GetUserFeedback();

                if (feedback == 'c')
                {
                    Console.WriteLine("I guessed it correctly!");
                    guessed = true;
                }
                else if (feedback == 'h')
                {
                    high = guess - 1;
                }
                else if (feedback == 'l')
                {
                    low = guess + 1;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter h, l, or c.");
                }
            }
        }
    }
}
