using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class FindTallest
    {
        static void Main()
        {
            int[] Heights = new int[3];
            int[] Age = new int[3];

            string[] Names = { "Amar", "Akbar", "Anthony" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Height of {Names[i]} : ");
                Heights[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter Age of {Names[i]} : ");
                Age[i] = Convert.ToInt32(Console.ReadLine());
            }

            int Youngest = int.MaxValue;
            int Tallest = int.MinValue;

            for (int i = 0; i < Heights.Length; i++)
            {
                if (Tallest < Heights[i])
                {
                    Tallest = i;
                }
                else continue;

                if (Youngest > Age[i])
                {
                    Youngest = i;
                }
                else continue;


                Console.WriteLine($"Youest Person in the group is  {Names[Youngest]} and Tallest is {Names[Tallest]}");
            }
        }
    }
}