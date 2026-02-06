using System;

namespace BridgeLabzTraining.senariobased.address_book
{
    internal class AddressBookOperations
    {
        private readonly IContact contactUtility = new ContactImpl();
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
                Console.WriteLine("5. Search by City");
                Console.WriteLine("6. Search by State");
                Console.WriteLine("7. Count by City");
                Console.WriteLine("8. Count by State");
                Console.WriteLine("9. Save to File");
                Console.WriteLine("10. Load from File");
                Console.WriteLine("11. Save to JSON File");
                Console.WriteLine("12. Load from JSON File");
                Console.WriteLine("13. Exit");

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
                        contactUtility.SearchByCity();
                        break;
                    case "6":
                        contactUtility.SearchByState();
                        break;
                    case "7":
                        contactUtility.CountByCity();
                        break;
                    case "8":
                        contactUtility.CountByState();
                        break;
                    case "9":
                        contactUtility.SaveToFile();
                        break;
                    case "10":
                        contactUtility.LoadFromFile();
                        break;
                    case "11":
                        contactUtility.SaveToJsonFile();
                        break;
                    case "12":
                        contactUtility.LoadFromJsonFile();
                        break;
                    case "13":
                        Console.WriteLine("Thank you, Visit Again!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            }
            while (choice != "13");
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
                Console.WriteLine("4. Search by City");
                Console.WriteLine("5. Search by State");
                Console.WriteLine("6. Count by City");
                Console.WriteLine("7. Count by State");
                Console.WriteLine("8. Save to File");
                Console.WriteLine("9. Load from File");
                Console.WriteLine("10. Save to JSON File");
                Console.WriteLine("11. Load from JSON File");
                Console.WriteLine("12. Exit");

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
                        contactUtility.SearchByCity();
                        break;
                    case "5":
                        contactUtility.SearchByState();
                        break;
                    case "6":
                        contactUtility.CountByCity();
                        break;
                    case "7":
                        contactUtility.CountByState();
                        break;
                    case "8":
                        contactUtility.SaveToFile();
                        break;
                    case "9":
                        contactUtility.LoadFromFile();
                        break;
                    case "10":
                        contactUtility.SaveToJsonFile();
                        break;
                    case "11":
                        contactUtility.LoadFromJsonFile();
                        break;
                    case "12":
                        Console.WriteLine("Thank you, Visit Again!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            }
            while (choice != "12");
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
                        contactUtility.SearchByCity();
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
