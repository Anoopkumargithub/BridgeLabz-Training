using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.smart_warehouse_management_system
{
    internal class Furniture : WarehouseItem
    {
        private string material;

        public Furniture(string name, double price, string material)
            : base(name, price)
        {
            this.material = material;
        }

        public override string GetDetails()
        {
            return $"Furniture | Name: {name}, Price: {price}, Material: {material}";
        }
    }
}
