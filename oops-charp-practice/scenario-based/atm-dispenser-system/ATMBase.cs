using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BridgeLabzTraining.senariobased.atm_dispenser_system.Curreency;

namespace BridgeLabzTraining.senariobased.atm_dispenser_system
{
    internal abstract class ATMBase : IATMService
    {
        protected int[] denominations;

        public ATMBase(int[] denominations)
        {
            this.denominations = denominations;
        }

        public abstract void DispenseCash(int amount);

        protected void DisplayResult(Currency[] currencies, int remaining)
        {
            foreach (Currency c in currencies)
            {
                if (c != null && c.Count > 0)
                {
                    Console.WriteLine(c);
                }
            }

            if (remaining != 0)
            {
                Console.WriteLine("Exact change not possible");
                Console.WriteLine("Remaining Amount: INR" + remaining);
            }
            else
            {
                Console.WriteLine("Amount Dispensed Successfully");
            }
        }
    }
}
