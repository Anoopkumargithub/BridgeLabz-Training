using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.smart_warehouse_management_system
{
    internal abstract class WarehouseItem
    {
        protected string name;
        protected double price;

        protected WarehouseItem(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract string GetDetails();
    }
}
