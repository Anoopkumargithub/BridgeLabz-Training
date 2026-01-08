using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.smart_home_automation_system
{
    internal class LightBulb: Appliance, IControllable
    {
        public LightBulb(string ApplianceName) : base(ApplianceName) { }

        public void Controll()
        {
            Console.WriteLine($"{ApplianceName} is Turned ON!!");
        }
    }
}
