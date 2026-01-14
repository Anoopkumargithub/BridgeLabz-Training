using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.address_book
{
    internal class ContactImpl : IContact
    {
        public void ShowContact(ContactDetails person)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
