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
        private bool AdminRole = false;

        public bool CheckRole()
        {
            Console.WriteLine("----Login to Address Book System----");
            Console.Write("Enter your Email: ");
            string email = Console.ReadLine();
            Console.WriteLine();
            
            if (email.Equals("ABC@gmail.com"))
            {
                AdminRole = true;
                Console.WriteLine("Welcome Admin!!");
                return true;
            }
            else
            {
                AdminRole = false;
                Console.WriteLine("Welcome User!!");
                return true;
            }
        }

        public void DisplayOperation()
        {
            // First check role at the beginning
            if (!CheckRole())
            {
                return;
            }

            Console.WriteLine("----Welcome To Address Book System----");
            Console.WriteLine();

            if (AdminRole)
            {
                DisplayAdminMenu();
            }
            else
            {
                DisplayUserMenu();
            }
        }

        // Admin Menu - full access
        private void DisplayAdminMenu()
        {
            string choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("----Admin Address Book Menu----");
                Console.WriteLine("1. Create New Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Show All Address Books");
                Console.WriteLine("4. Manage Contacts (in selected book)");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        contactUtility.CreateAddressBook();
                        break;
                    case "2":
                        contactUtility.SelectAddressBook();
                        break;
                    case "3":
                        contactUtility.ShowAllAddressBooks();
                        break;
                    case "4":
                        ManageContactsAdmin();
                        break;
                    case "5":
                        Console.WriteLine("Thank you, Visit Again!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            }
            while (choice != "5");
        }

        // User Menu - Limited access (only ShowContact)
        private void DisplayUserMenu()
        {
            string choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("----User Menu----");
                Console.WriteLine("1. Show All Address Books");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Show Contact");
                Console.WriteLine("4. Search By City or State");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        contactUtility.ShowAllAddressBooks();
                        break;
                    case "2":
                        contactUtility.SelectAddressBook();
                        break;
                    case "3":
                        contactUtility.ShowContact();
                        break;
                    case "4":
                        SearchByCityOrState();
                        break;
                    case "5":
                        Console.WriteLine("Thank you, Visit Again!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            }
            while (choice != "5");
        }

        // Common Menu -  Search By City or State
        private void SearchByCityOrState()
        {
            Console.WriteLine("What you want to search by City or State");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            Console.WriteLine("3. Exit");

            string choice;
            do
            {
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        contactUtility.SearchByCity();
                        break;
                    case "2":
                        contactUtility.SearchByState();
                        break;
                    case "3":
                        Console.WriteLine("Back To Main Menu");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != "3");

        }

        // Admin contact management
        private void ManageContactsAdmin()
        {
            string choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("----Contact Management (Admin)----");
                Console.WriteLine("1. Show Contact");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Search by City or State");
                Console.WriteLine("6. Back to Main Menu");

                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        contactUtility.ShowContact();
                        break;
                    case "2":
                        contactUtility.AddContact();
                        break;
                    case "3":
                        contactUtility.EditContact();
                        break;
                    case "4":
                        contactUtility.DeleteContact();
                        break;
                    case "5":
                        SearchByCityOrState();
                        break;
                    case "6":
                        Console.WriteLine("Returning to Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            }
            while (choice != "6");
        }

    }
}
