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
        bool AdminRole = false;

        public bool CheckRole()
        {
            Console.Write("Enter your Email: ");
            string email = Console.ReadLine();
            if (email.Equals("ABC@gmail.com"))
            {
                AdminRole = true;
                return true;
            }
            else
            {
                Console.WriteLine("Wrong Credentials, Try Again!!");
                AdminRole = false;
            }
            return false;
        }
        public void DisplayOperation()
        {
            Console.WriteLine("----Welcome To Address Book----");
            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1.Show Contact");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Exit");

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
                                                "987654321",
                                                "anoop.kumar@email.com");
                        contactUtility.ShowContact(Person);
                        break;
                    case 2:
                        if (AdminRole)
                        {
                            contactUtility.AddContact();
                        }
                        else if (CheckRole())
                        {
                            contactUtility.AddContact();
                        }
                        break;
                    case 3:
                        if (AdminRole)
                        {
                            contactUtility.EditContact();
                        }
                        else if (CheckRole())
                        {
                            contactUtility.EditContact();
                        }
                            break;
                    case 4:
                        Console.WriteLine("Thankyou, Visit Again!!");
                        break;
                }
            }
            while (choice != 4);
        }
    }
}
