using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class MathematicalOperations
    {
        static int Menu()
        {
            Console.WriteLine("_______Mathematical Operation_______");
            Console.WriteLine("What operation what you want to do: ");
            Console.WriteLine("1. Find Factorial of a Number?");
            Console.WriteLine("2. Check Prime Number");
            Console.WriteLine("3. Find GCD of 2 Numbers");
            Console.WriteLine("4. Nth Fibonacci Number");
            Console.WriteLine("5. Exit");

            int operations = Convert.ToInt32(Console.ReadLine());
            switch (operations)
            {
                case 1:
                    {
                        //Factorial();
                        Operations.Factorial();
                        break;
                    }
                case 2:
                    {
                        //PrimeNumber();
                        Operations.PrimeNumber();
                        break;
                    }
                case 3:
                    {
                        //GCD();
                        Operations.GCD();
                        break;
                    }
                case 4:
                    {
                        //Fibonacci();
                        Operations.Fibonacci();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Thank You");
                        return 1;
                    }
            }
             return Menu();
        }
        public static void Main(string[] args)
        {
            Menu();
        }
    }

    internal class Operations()
    {
        internal static void Factorial()
        {
            Console.WriteLine("____Factorial____");
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;
            
            for(int i = 1;i< number;i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {number} is {factorial}");
        }

        internal static void PrimeNumber()
        {
            Console.WriteLine("____Prime Number____");
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = false;

            for (int i = 2; i*i<number; i++)
            {
                if(number % i == 0)
                {
                    isPrime = true;
                }
                else
                {
                    isPrime = false;
                }
            }
            Console.WriteLine($"{number} is Prime Number {isPrime}");
        }

        internal static void GCD()
        {
            Console.WriteLine("____GCD____");
            Console.Write("Enter a Number 1: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Number 2: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int smallNumber = Math.Min(firstNumber, secondNumber);

            for(int i = smallNumber; i > 0; i--)
            {
                if(smallNumber % i == 0)
                {
                    Console.WriteLine($"GCD of {firstNumber} {secondNumber} is {i}");
                    break;
                }
            }
        }

        internal static void Fibonacci()
        {
            Console.WriteLine("____Nth Fibonacci____");
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 0;
            int secondNumber = 1;
            int answer = firstNumber + secondNumber;

            for (int i = 2; i < number; i++)
            {
                firstNumber = secondNumber;
                secondNumber = answer;
                answer = firstNumber + secondNumber;
            }
            Console.WriteLine($"{number}th Fibonacci Number is {answer}");
        }

    }

}

    