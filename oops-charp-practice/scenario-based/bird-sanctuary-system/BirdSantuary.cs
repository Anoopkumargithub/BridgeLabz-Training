using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.bird_sanctuary_system
{
    internal class BirdSantuary
    {
        public static void Main(string[] args)
        {
            BirdUtility utility = new BirdUtility(10);
            BirdMenu menu = new BirdMenu(utility);

            menu.ShowMenu();
        }
    }
}
