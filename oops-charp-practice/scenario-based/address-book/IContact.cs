using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.address_book
{
    internal interface IContact
    {
        void ShowContact();

        void AddContact();

        void EditContact();

        void DeleteContact();
    }
}
