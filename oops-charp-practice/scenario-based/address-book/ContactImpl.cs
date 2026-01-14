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
        public void EditContact()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            for(int i = 0;i< contacts.Length;i++)
            {
                if(contacts[i].GetFirstName() != firstName)
                {
                    Console.WriteLine("No Contact Available with this Name");
                    return;
                }
                else
                {
                    Console.WriteLine("Current Person detail: ");
                    Console.WriteLine(contacts[i].ToString());
                    Console.WriteLine();
                    ContactDetails person = AddInfo();
                    contacts[i] = person;

                    Console.WriteLine($"{contacts[i].GetFirstName()} detials updated");

                }
            }
        }
        public void AddContact()
        {
            ContactDetails person = AddInfo();
            if(count < contacts.Length)
            {
                contacts[count] = person;
                count++;
                Console.WriteLine(person.ToString());
                Console.WriteLine();
                Console.WriteLine("Added SucessFully");
            }
            if(count == contacts.Length)
            {
                Console.WriteLine("Address Book is Full");
            }


        }
        public void ShowContact(ContactDetails person)
        {
            Console.WriteLine(person.ToString());
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
