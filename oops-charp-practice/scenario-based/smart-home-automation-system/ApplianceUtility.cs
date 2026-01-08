using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.smart_home_automation_system
{
    internal class ApplianceUtility
    {
        private Appliance[] appliances;
        private int count;

        public ApplianceUtility(int size)
        {
            appliances = new Appliance[size];
        }

        public void AddAppliance(Appliance appliance)
        {
            if(count <  appliances.Length-1)
            {
                appliances[count] = appliance;
                count++;
                Console.WriteLine($"{appliance} is successfully connected to Smart Home!!");
            }
            else
            {
                Console.WriteLine("No more device connected to your Smart Home!!");
            }
        }

        public void ConnectedAppliance()
        {
            for(int i = 0;i < appliances.Length;i++)
            {
                Console.WriteLine($"{i + 1}. {appliances[i].ToString()}");

                if(appliances[i] is IControllable)
                {
                    ((IControllable)appliances[i]).Controll();
                }

                Console.WriteLine("---------------------------");
            }
        }
    }
}
