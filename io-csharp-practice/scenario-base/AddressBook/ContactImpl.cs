using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

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

        public void SaveToFile()
        {
            try
            {
                Console.Write("Enter file name to save (without extension): ");
                string fileName = Console.ReadLine();
                string filePath = fileName + ".csv";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write header
                    writer.WriteLine("AddressBookName,FirstName,LastName,Address,City,State,ZIPCode,PhoneNumber,Email");

                    // Write all contacts from all address books
                    foreach (var book in addressBooks)
                    {
                        string addressBookName = book.Key;
                        foreach (var contact in book.Value)
                        {
                            string line = $"{addressBookName},{contact.GetFirstName()},{contact.GetLastName()},{contact.GetAddress()},{contact.GetCity()},{contact.GetState()},{contact.GetZIPCode()},{contact.GetPhoneNumber()},{contact.GetEmail()}";
                            writer.WriteLine(line);
                        }
                    }
                }

                Console.WriteLine($"Address Book data saved successfully to {filePath}");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving to file: {ex.Message}");
                Console.WriteLine();
            }
        }

        public void LoadFromFile()
        {
            try
            {
                Console.Write("Enter file name to load (without extension): ");
                string fileName = Console.ReadLine();
                string filePath = fileName + ".csv";

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File '{filePath}' not found!");
                    Console.WriteLine();
                    return;
                }

                // Clear existing data
                Console.Write("This will replace existing data. Continue? (y/n): ");
                string confirm = Console.ReadLine();
                if (confirm?.ToLower() != "y")
                {
                    Console.WriteLine("Load operation cancelled.");
                    Console.WriteLine();
                    return;
                }

                addressBooks.Clear();
                currentAddressBook = null;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Skip header line
                    reader.ReadLine();

                    int count = 0;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 9)
                        {
                            string addressBookName = parts[0];
                            string firstName = parts[1];
                            string lastName = parts[2];
                            string address = parts[3];
                            string city = parts[4];
                            string state = parts[5];
                            string zipCode = parts[6];
                            string phoneNumber = parts[7];
                            string email = parts[8];

                            // Create address book if it doesn't exist
                            if (!addressBooks.ContainsKey(addressBookName))
                            {
                                addressBooks[addressBookName] = new List<ContactDetails>();
                            }

                            // Create contact and add to address book
                            ContactDetails contact = new ContactDetails(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
                            addressBooks[addressBookName].Add(contact);
                            count++;
                        }
                    }

                    Console.WriteLine($"Successfully loaded {count} contact(s) from {filePath}");
                    Console.WriteLine($"Total Address Books: {addressBooks.Count}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading from file: {ex.Message}");
                Console.WriteLine();
            }
        }

        public void SaveToJsonFile()
        {
            try
            {
                Console.Write("Enter file name to save (without extension): ");
                string fileName = Console.ReadLine();
                string filePath = fileName + ".json";

                // Create a structure to hold address books and contacts
                var jsonData = new Dictionary<string, List<Dictionary<string, string>>>();

                foreach (var book in addressBooks)
                {
                    var contactsList = new List<Dictionary<string, string>>();
                    
                    foreach (var contact in book.Value)
                    {
                        var contactData = new Dictionary<string, string>
                        {
                            { "FirstName", contact.GetFirstName() },
                            { "LastName", contact.GetLastName() },
                            { "Address", contact.GetAddress() },
                            { "City", contact.GetCity() },
                            { "State", contact.GetState() },
                            { "ZIPCode", contact.GetZIPCode() },
                            { "PhoneNumber", contact.GetPhoneNumber() },
                            { "Email", contact.GetEmail() }
                        };
                        contactsList.Add(contactData);
                    }
                    
                    jsonData[book.Key] = contactsList;
                }

                // Serialize to JSON with formatting
                string jsonString = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
                File.WriteAllText(filePath, jsonString);

                Console.WriteLine($"Address Book data saved successfully to {filePath}");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving to JSON file: {ex.Message}");
                Console.WriteLine();
            }
        }

        public void LoadFromJsonFile()
        {
            try
            {
                Console.Write("Enter file name to load (without extension): ");
                string fileName = Console.ReadLine();
                string filePath = fileName + ".json";

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File '{filePath}' not found!");
                    Console.WriteLine();
                    return;
                }

                // Clear existing data
                Console.Write("This will replace existing data. Continue? (y/n): ");
                string confirm = Console.ReadLine();
                if (confirm?.ToLower() != "y")
                {
                    Console.WriteLine("Load operation cancelled.");
                    Console.WriteLine();
                    return;
                }

                addressBooks.Clear();
                currentAddressBook = null;

                // Read and deserialize JSON
                string jsonString = File.ReadAllText(filePath);
                var jsonData = JsonConvert.DeserializeObject<Dictionary<string, List<Dictionary<string, string>>>>(jsonString);

                int count = 0;
                foreach (var bookEntry in jsonData)
                {
                    string addressBookName = bookEntry.Key;
                    addressBooks[addressBookName] = new List<ContactDetails>();

                    foreach (var contactData in bookEntry.Value)
                    {
                        ContactDetails contact = new ContactDetails(
                            contactData["FirstName"],
                            contactData["LastName"],
                            contactData["Address"],
                            contactData["City"],
                            contactData["State"],
                            contactData["ZIPCode"],
                            contactData["PhoneNumber"],
                            contactData["Email"]
                        );
                        addressBooks[addressBookName].Add(contact);
                        count++;
                    }
                }

                Console.WriteLine($"Successfully loaded {count} contact(s) from {filePath}");
                Console.WriteLine($"Total Address Books: {addressBooks.Count}");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading from JSON file: {ex.Message}");
                Console.WriteLine();
            }
        }

    }
}
