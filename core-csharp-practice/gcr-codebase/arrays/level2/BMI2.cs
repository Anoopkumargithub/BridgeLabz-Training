using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BMI2
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number of Persons: ");
            int NumberOfPersons = Convert.ToInt32(Console.ReadLine());

            double[,] PersonData = new double[3, NumberOfPersons];

            string[] WeightStatus = new string[NumberOfPersons];

            for (int i = 0; i < NumberOfPersons; i++)
            {
                Console.WriteLine($"Enter Weight of person {i}");
                PersonData[0, i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Enter Height of person {i} (in cm)");
                PersonData[1, i] = Convert.ToDouble(Console.ReadLine()) * 0.01;

                PersonData[2, i] = PersonData[0, i] / (PersonData[1, i] * PersonData[1, i]);

                if (PersonData[2, i] <= 18.4)
                {
                    WeightStatus[i] = "UnderWeight";
                }
                else if (PersonData[2, i] >= 18.5 && PersonData[2, i] <= 24.9)
                {
                    WeightStatus[i] = "Normal";
                }
                else if (PersonData[2, i] >= 25.0 && PersonData[2, i] <= 39.9)
                {
                    WeightStatus[i] = "OverWeiht";
                }
                else
                {
                    WeightStatus[i] = "Obese";
                }

            }

            // Dispaly Height, weight, BMI and WeightStatus of each person

            for (int i = 0; i < NumberOfPersons; i++)
            {
                Console.WriteLine($"Person with height of {PersonData[1, i]} and weight of {PersonData[0, i]}, having BMI {PersonData[2, i]} and his status is {WeightStatus[i]}");
            }
        }

    }
}
