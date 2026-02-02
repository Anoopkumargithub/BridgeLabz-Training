using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.address_book
{
    internal class ContactImpl : IContact
    {
        // Using Dictionary to store address books with their contacts
        private Dictionary<string, List<ContactDetails>> addressBooks = new Dictionary<string, List<ContactDetails>>();
        private string currentAddressBook = null; // Currently selected address book

        public void CountByCity()
        {
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            Console.WriteLine();

            CountContacts(city, "City");
        }

        public void CountByState()
        {
            Console.Write("Enter State: ");
            string state = Console.ReadLine();
            Console.WriteLine();

            CountContacts(state, "State");
        }

        public void SearchByState()
        {
            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            SearchContact(state);

        }

        public void SearchByCity()
        {
            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            SearchContact(city);
        }

        public void CreateAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            // Check for duplicate names
            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine($"Address Book '{name}' already exists!");
                return;
            }

            addressBooks[name] = new List<ContactDetails>();
            Console.WriteLine($"Address Book '{name}' created successfully!");
        }

        public void ShowAllAddressBooks()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books available.");
                return;
            }

            Console.WriteLine("----Available Address Books----");
            int index = 1;
            foreach (var book in addressBooks)
            {
                Console.WriteLine($"{index}. {book.Key} (Contacts: {book.Value.Count})");
                index++;
            }
        }

        public bool SelectAddressBook()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books available. Please create one first.");
                return false;
            }

            ShowAllAddressBooks();
            Console.WriteLine();
            Console.Write("Enter Address Book Name to open: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            if (addressBooks.ContainsKey(name))
            {
                currentAddressBook = name;
                Console.WriteLine($"----Opened Address Book: {name}----");
                return true;
            }

            Console.WriteLine($"Address Book '{name}' not found!");
            return false;
        }

        public void DeleteContact()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            var contacts = addressBooks[currentAddressBook];
            var contact = contacts.FirstOrDefault(c => c.GetFirstName() == firstName);

            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine($"Contact '{firstName}' deleted successfully.");
            }
            else
            {
                Console.WriteLine("No Contact Available with this Name");
            }
        }

        public void EditContact()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            var contacts = addressBooks[currentAddressBook];
            var contact = contacts.FirstOrDefault(c => c.GetFirstName() == firstName);

            if (contact != null)
            {
                Console.WriteLine("Current Person detail: ");
                Console.WriteLine(contact.ToString());
                Console.WriteLine();
                ContactDetails person = AddInfo();
                
                int index = contacts.IndexOf(contact);
                contacts[index] = person;

                Console.WriteLine($"{person.GetFirstName()} details updated");
            }
            else
            {
                Console.WriteLine("No Contact Available with this Name");
            }
        }

        public void AddContact()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            var contacts = addressBooks[currentAddressBook];

            while (true)
            {
                ContactDetails person = AddInfo();
                // Check duplicate contact
                if (!IsDuplicate(person))
                {
                    contacts.Add(person);
                    Console.WriteLine(person.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Added Successfully");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Person with this details is already present");
                    Console.WriteLine();
                }

                Console.Write("Do you want to add another contact? (y/n): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice?.ToLower() != "y")
                {
                    break;
                }
            }
        }

        public void ShowContact()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            var contacts = addressBooks[currentAddressBook];
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available in this Address Book.");
                return;
            }

            // Sort contacts alphabetically by First Name using LINQ
            var sortedContacts = contacts.OrderBy(c => c.GetFirstName()).ToList();

            Console.WriteLine("----Available Contacts----");
            Console.WriteLine();
            for (int i = 0; i < sortedContacts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedContacts[i].GetFirstName()}");
            }
            Console.WriteLine();

            Console.Write("Enter First Name to view full details: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            var contact = sortedContacts.FirstOrDefault(c => c.GetFirstName() == firstName);
            if (contact != null)
            {
                Console.WriteLine("Contact Details:");
                Console.WriteLine();
                Console.WriteLine(contact.ToString());
            }
            else
            {
                Console.WriteLine("No Contact Available with this Name");
            }
        }

        // helper function for input contact Data
        public ContactDetails AddInfo()
        {
            Console.WriteLine("Fill the Contact Fields: ");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter State: ");
            string state = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter ZIP Code: ");
            string zIPCode = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Phone Number (Not include +91): ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine();

            ContactDetails person = new ContactDetails(firstName, lastName, address, city, state, zIPCode, phoneNumber, email);
            return person;
        }

        // helper function for check duplicate contact
        private bool IsDuplicate(ContactDetails person)
        {
            if (currentAddressBook == null)
                return false;

            var contacts = addressBooks[currentAddressBook];
            return contacts.Any(c => c.GetFirstName() == person.GetFirstName());
        }

        // helper function for Search Contacts
        private void SearchContact(string place)
        {
            bool found = false;

            foreach (var book in addressBooks)
            {
                var matchingContacts = book.Value
                    .Where(c => c.GetState() == place || c.GetCity() == place)
                    .ToList();

                if (matchingContacts.Count > 0)
                {
                    Console.WriteLine($"Found in Address Book: {book.Key}");
                    foreach (var contact in matchingContacts)
                    {
                        Console.WriteLine(contact.ToString());
                        Console.WriteLine();
                    }
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No Contact Found!!");
                Console.WriteLine();
            }
        }

        // helper function for count Contacts 
        private void CountContacts(string place, string searchType)
        {
            int totalCount = 0;
            Dictionary<string, int> countByAddressBook = new Dictionary<string, int>();

            foreach (var book in addressBooks)
            {
                var matchingContacts = book.Value
                    .Where(c => (searchType == "City" && c.GetCity() == place) ||
                                (searchType == "State" && c.GetState() == place))
                    .ToList();

                if (matchingContacts.Count > 0)
                {
                    countByAddressBook[book.Key] = matchingContacts.Count;
                    totalCount += matchingContacts.Count;
                }
            }

            // Display results
            Console.WriteLine($"Count Results for {searchType}: '{place}'");
            Console.WriteLine();

            if (totalCount == 0)
            {
                Console.WriteLine($"No contacts found in {searchType}: '{place}'");
            }
            else
            {
                Console.WriteLine("Breakdown by Address Book:");
                foreach (var entry in countByAddressBook)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value} contact(s)");
                }
                Console.WriteLine($"Total Contacts: {totalCount}");
            }
            Console.WriteLine();
        }

        

    }
}
