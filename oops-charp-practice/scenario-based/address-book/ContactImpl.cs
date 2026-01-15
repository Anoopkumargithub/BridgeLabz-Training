using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.address_book
{
    internal class ContactImpl : IContact
    {
        private ContactDetails[,] contacts = new ContactDetails[5, 10]; // 5 address books, 10 contacts each
        private string[] addressBookNames = new string[5]; // Store address book names
        private int[] contactCounts = new int[5]; // Track contacts per address book
        private int addressBookCount = 0; // Total number of address books
        private int currentAddressBookIndex = -1; // Currently selected address book

        
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
            if (addressBookCount >= addressBookNames.Length)
            {
                Console.WriteLine("Cannot create more Address Books. Maximum limit reached.");
                return;
            }

            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            // Check for duplicate names
            for (int i = 0; i < addressBookCount; i++)
            {
                if (addressBookNames[i] == name)
                {
                    Console.WriteLine($"Address Book '{name}' already exists!");
                    return;
                }
            }

            addressBookNames[addressBookCount] = name;
            contactCounts[addressBookCount] = 0;
            addressBookCount++;
            Console.WriteLine($"Address Book '{name}' created successfully!");
        }

        public void ShowAllAddressBooks()
        {
            if (addressBookCount == 0)
            {
                Console.WriteLine("No Address Books available.");
                return;
            }

            Console.WriteLine("----Available Address Books----");
            for (int i = 0; i < addressBookCount; i++)
            {
                Console.WriteLine($"{i + 1}. {addressBookNames[i]} (Contacts: {contactCounts[i]})");
            }
        }

        public bool SelectAddressBook()
        {
            if (addressBookCount == 0)
            {
                Console.WriteLine("No Address Books available. Please create one first.");
                return false;
            }

            ShowAllAddressBooks();
            Console.WriteLine();
            Console.Write("Enter Address Book Name to open: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < addressBookCount; i++)
            {
                if (addressBookNames[i] == name)
                {
                    currentAddressBookIndex = i;
                    Console.WriteLine($"----Opened Address Book: {addressBookNames[i]}----");
                    return true;
                }
            }

            Console.WriteLine($"Address Book '{name}' not found!");
            return false;
        }

        public void DeleteContact()
        {
            if (currentAddressBookIndex == -1)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            int count = contactCounts[currentAddressBookIndex];
            for (int i = 0; i < count; i++)
            {
                if (contacts[currentAddressBookIndex, i].GetFirstName() == firstName)
                {
                    // Shift contacts to the left
                    for (int j = i; j < count - 1; j++)
                    {
                        contacts[currentAddressBookIndex, j] = contacts[currentAddressBookIndex, j + 1];
                    }
                    contacts[currentAddressBookIndex, count - 1] = null;
                    contactCounts[currentAddressBookIndex]--;
                    Console.WriteLine($"Contact '{firstName}' deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("No Contact Available with this Name");
        }

        public void EditContact()
        {
            if (currentAddressBookIndex == -1)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            int count = contactCounts[currentAddressBookIndex];
            for (int i = 0; i < count; i++)
            {
                if (contacts[currentAddressBookIndex, i].GetFirstName() == firstName)
                {
                    Console.WriteLine("Current Person detail: ");
                    Console.WriteLine(contacts[currentAddressBookIndex, i].ToString());
                    Console.WriteLine();
                    ContactDetails person = AddInfo();
                    contacts[currentAddressBookIndex, i] = person;

                    Console.WriteLine($"{contacts[currentAddressBookIndex, i].GetFirstName()} details updated");
                    return;
                }
            }

            Console.WriteLine("No Contact Available with this Name");
        }

        public void AddContact()
        {
            if (currentAddressBookIndex == -1)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            int maxContacts = contacts.GetLength(1); // Second dimension size (10)
            int count = contactCounts[currentAddressBookIndex];

            while (count < maxContacts)
            {
                ContactDetails person = AddInfo();
                // Check duplicate contact
                if (!IsDuplicate(currentAddressBookIndex, person) || count == 0)
                {
                    contacts[currentAddressBookIndex, count] = person;
                    contactCounts[currentAddressBookIndex]++;
                    count++;
                    Console.WriteLine(person.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Added Successfully");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Person with this details is allready present");
                    Console.WriteLine();
                }

                if (count == maxContacts)
                {
                    Console.WriteLine("Address Book is Full");
                    break;
                }

                Console.Write("Do you want to add another contact? (y/n): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice?.ToLower() != "y")
                {
                    break;
                }
            }

            if (count == maxContacts)
            {
                Console.WriteLine("Cannot add more contacts. Address Book is Full");
            }
        }

        public void ShowContact()
        {
            if (currentAddressBookIndex == -1)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            int count = contactCounts[currentAddressBookIndex];
            if (count == 0)
            {
                Console.WriteLine("No contacts available in this Address Book.");
                return;
            }

            Console.WriteLine("----Available Contacts----");
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {contacts[currentAddressBookIndex, i].GetFirstName()}");
            }
            Console.WriteLine();

            Console.Write("Enter First Name to view full details: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[currentAddressBookIndex, i].GetFirstName() == firstName)
                {
                    Console.WriteLine("Contact Details:");
                    Console.WriteLine();
                    Console.WriteLine(contacts[currentAddressBookIndex, i].ToString());
                    return;
                }
            }

            Console.WriteLine("No Contact Available with this Name");
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

            ContactDetails person = new ContactDetails(firstName, lastName, address, city,
                                                        state, zIPCode, phoneNumber, email);
            return person;
        }

        // helper function for check duplicate contact
        bool IsDuplicate(int currentAddressBookIndex, ContactDetails person)
        {
            int count = contactCounts[currentAddressBookIndex];
            for (int i = 0; i < count; i++)
            {
                if (contacts[currentAddressBookIndex, i].GetFirstName() == person.GetFirstName())
                {
                    return true;
                }
            }
            return false;
        }

        // helper function for Search Contacts

        private void SearchContact(string place)
        {
            bool found = true;

            for(int i = 0;i < addressBookCount; i++)
            {
                int totalContact = contactCounts[i];
                for(int j = 0;j < totalContact; j++)
                {
                    if (contacts[i,j].GetState() == place)
                    {
                        contacts[i, j].ToString();
                        Console.WriteLine();
                        found = false;
                    }
                    else if (contacts[i,j].GetCity() == place)
                    {
                        contacts[i,j].ToString();
                        Console.WriteLine();
                        found = false;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No Contact Founds!!");
                Console.WriteLine();
            }
        }
    }
}
