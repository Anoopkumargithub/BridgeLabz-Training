using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BridgeLabzTraining.senariobased.atm_dispenser_system.Curreency;

namespace BridgeLabzTraining.senariobased.atm_dispenser_system
{
    internal class ATMMenu : ATMBase
    {
        public ATMMenu(int[] denominations) : base(denominations) { }

        public override void DispenseCash(int amount)
        {
            Currency[] result = new Currency[denominations.Length];
            int remaining = amount;

            for (int i = 0; i < denominations.Length; i++)
            {
                int note = denominations[i];
                int count = remaining / note;
                remaining %= note;

                result[i] = new Currency(note, count);
            }

            Console.WriteLine("Requested Amount: INR" + amount);
            DisplayResult(result, remaining);
        }

        public static void ShowMenu()
        {
            Console.WriteLine("ATM DISPENSER SYSTEM");
            Console.WriteLine("1. Scenario A (Normal ATM)");
            Console.WriteLine("2. Scenario B (INR 500 Removed)");
            Console.WriteLine("3. Scenario C (Fallback)");
            Console.Write("Choose Option: ");

            int choice = int.Parse(Console.ReadLine());

            ATMMenu atm;

            switch (choice)
            {
                case 1:
                    atm = new ATMMenu(new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 });
                    atm.DispenseCash(880);
                    break;

                case 2:
                    atm = new ATMMenu(new int[] { 200, 100, 50, 20, 10, 5, 2, 1 });
                    atm.DispenseCash(880);
                    break;

                case 3:
                    atm = new ATMMenu(new int[] { 200, 100, 50 });
                    atm.DispenseCash(883);
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
