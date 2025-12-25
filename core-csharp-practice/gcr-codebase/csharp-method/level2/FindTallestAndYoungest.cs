using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class FindTallestAndYoungest
    {
        static int FindYoungest(int[] ages)
        {
            int youngestIndex = 0;

            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < ages[youngestIndex])
                {
                    youngestIndex = i;
                }
            }
            return youngestIndex;
        }

        static int FindTallest(int[] heights)
        {
            int tallestIndex = 0;

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > heights[tallestIndex])
                {
                    tallestIndex = i;
                }
            }
            return tallestIndex;
        }

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

            int Youngest = FindYoungest(Age);
            int Tallest = FindTallest(Heights);


            Console.WriteLine($"Youest Person in the group is  {Names[Youngest]} and Tallest is {Names[Tallest]}");
        }
    }

}
