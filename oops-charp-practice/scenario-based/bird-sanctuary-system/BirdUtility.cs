using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.bird_sanctuary_system
{
    internal class BirdUtility
    {
        private Bird[] birds;
        private int count;

        public BirdUtility(int size)
        {
            birds = new Bird[size];
            count = 0;
        }

        public void AddBird(Bird bird)
        {
            if (count < birds.Length)
            {
                birds[count] = bird;
                count++;
                Console.WriteLine("Bird added successfully");
            }
            else
            {
                Console.WriteLine("Sanctuary is full");
            }
        }

        public void ShowBirdActivities()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(birds[i].ToString());

                if (birds[i] is IFlyable)
                {
                    ((IFlyable)birds[i]).Fly();
                }

                if (birds[i] is ISwimmable)
                {
                    ((ISwimmable)birds[i]).Swim();
                }

                Console.WriteLine("-------------------");
            }
        }
    }
}
