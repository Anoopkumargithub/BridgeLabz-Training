using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.address_book
{
    internal class AddressBookOperations
    {
        private IContact contactUtility = new ContactImpl();
        public void DisplayOperation()
        {
            Console.WriteLine("----Welcome To Address Book----");
            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1.Show Contact");
                Console.WriteLine("2. Exit");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("----Person Details----");
                        ContactDetails Person = new ContactDetails(
                                                "Anoop",
                                                "Kumar",
                                                "12 MG Road",
                                                "Bengaluru",
                                                "Karnataka",
                                                "560001",
                                                987654321,
                                                "anoop.kumar@email.com");
                        contactUtility.ShowContact(Person);
                        break;
                    case 2:
                        Console.WriteLine("Thankyou, Visit Again!!");
                        break;
                }
            }
            while (choice != 2);
        }
    }
}
