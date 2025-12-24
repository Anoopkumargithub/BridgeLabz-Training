using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BMI
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number of Persons: ");
            int NumberOfPersons = Convert.ToInt32(Console.ReadLine());

            double[] Weights = new double[NumberOfPersons];
            double[] Heights = new double[NumberOfPersons];

            double[] BMI = new double[NumberOfPersons];
            string[] WeightStatus = new string[NumberOfPersons];

            for (int i = 0; i < NumberOfPersons; i++)
            {
                Console.WriteLine($"Enter Weight of person {i}");
                Weights[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter Height of person {i}");
                Heights[i] = Convert.ToInt32(Console.ReadLine()) * 0.01;

                BMI[i] = Weights[i] / (Heights[i] * Heights[i]);

                if (BMI[i] <= 18.4)
                {
                    WeightStatus[i] = "UnderWeight";
                }
                else if (BMI[i] >= 18.5 && BMI[i] <= 24.9)
                {
                    WeightStatus[i] = "Normal";
                }
                else if (BMI[i] >= 25.0 && BMI[i] <= 39.9)
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
                Console.WriteLine($"Person with height of {Heights[i]} and weight of {Weights[i]}, having BMI {BMI[i]} and his status is {WeightStatus[i]}");
            }


        }
    }
}
