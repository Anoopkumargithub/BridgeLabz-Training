using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.atm_dispenser_system
{
    internal class Curreency
    {
        internal class Currency
        {
            private int denomination;
            private int count;

            public Currency(int denomination, int count)
            {
                this.denomination = denomination;
                this.count = count;
            }

            public int Denomination
            {
                get { return denomination; }
            }

            public int Count
            {
                get { return count; }
                set { count = value; }
            }

            public override string ToString()
            {
                return "INR" + denomination + " x " + count;
            }
        }
    }
}
