using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.smart_warehouse_management_system
{
    internal class Groceries : WarehouseItem
    {
        private string expiryDate;

        public Groceries(string name, double price, string expiryDate)
            : base(name, price)
        {
            this.expiryDate = expiryDate;
        }

        public override string GetDetails()
        {
            return $"Groceries | Name: {name}, Price: {price}, Expiry: {expiryDate}";
        }
    }
}
