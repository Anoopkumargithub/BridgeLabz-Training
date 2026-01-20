using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.smart_warehouse_management_system
{
    internal interface IWarehouseService
    {
        void AddElectronics();
        void AddGroceries();
        void AddFurniture();
        void DisplayItems();
    }
}
