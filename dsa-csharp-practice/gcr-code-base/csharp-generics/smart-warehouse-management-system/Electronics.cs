using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.smart_warehouse_management_system
{
    internal class Electronics : WarehouseItem
    {
        private int warranty;

        public Electronics(string name, double price, int warranty)
            : base(name, price)
        {
            this.warranty = warranty;
        }

        public override string GetDetails()
        {
            return $"Electronics | Name: {name}, Price: {price}, Warranty: {warranty} years";
        }
    }
}
