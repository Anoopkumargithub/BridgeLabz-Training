using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.address_book
{
    internal class ContactImpl : IContact
    {
        ContactDetails [] contacts = new ContactDetails [10];
        int count = 0;

        public void DeleteContact()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].GetFirstName() == firstName)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }
                    contacts[count - 1] = null;
                    count--;
                    Console.WriteLine($"Contact '{firstName}' deleted successfully.");
                    return;
                }
                else
                {
                    Console.WriteLine("No Contact Available with this Name");
                    return;
                }
            }
        }
        public void EditContact()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            for(int i = 0;i< contacts.Length;i++)
            {
                if(contacts[i].GetFirstName() == firstName)
                {
                    Console.WriteLine("Current Person detail: ");
                    Console.WriteLine(contacts[i].ToString());
                    Console.WriteLine();
                    ContactDetails person = AddInfo();
                    contacts[i] = person;

                    Console.WriteLine($"{contacts[i].GetFirstName()} detials updated");
                    return;
                }
                else
                {
                    Console.WriteLine("No Contact Available with this Name");
                    return;
                }
            }
        }
        public void AddContact()
        {
            while (count < contacts.Length)
            {
                ContactDetails person = AddInfo();
                contacts[count] = person;
                count++;
                Console.WriteLine(person.ToString());
                Console.WriteLine();
                Console.WriteLine("Added Successfully");
                Console.WriteLine();

                if (count == contacts.Length)
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

            if (count == contacts.Length)
            {
                Console.WriteLine("Cannot add more contacts. Address Book is Full");
            }
        }
        public void ShowContact()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts available in the Address Book.");
                return;
            }

            Console.WriteLine("----Available Contacts----");
            Console.WriteLine();
            // show firstName only
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {contacts[i].GetFirstName()}");
            }
            Console.WriteLine();

            Console.Write("Enter First Name to view full details: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            
            for (int i = 0; i < count; i++)
            {
                // on the basis of firstName show complete details
                if (contacts[i].GetFirstName() == firstName)
                {
                    Console.WriteLine("Contact Details:");
                    Console.WriteLine();
                    Console.WriteLine(contacts[i].ToString());
                    return;
                }
            }

            Console.WriteLine("No Contact Available with this Name");
            return;
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

    }
}
