using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.smart_home_automation_system
{
    internal class SmartHome
    {
        public static void Main(string[] args)
        {
            ApplianceUtility utility = new ApplianceUtility(10);
            ApplianceMenu menu = new ApplianceMenu(utility);

            menu.ShowMenu();
        }
    }
}
