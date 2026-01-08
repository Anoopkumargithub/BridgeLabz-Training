using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.smart_home_automation_system
{
    internal class Appliance
    {
        protected string ApplianceName;

        public Appliance(string applianceName)
        {
            this.ApplianceName = applianceName;
        }

        public override string? ToString()
        {
            return "Appliance Name: "+ ApplianceName; 
        }
    }
}
