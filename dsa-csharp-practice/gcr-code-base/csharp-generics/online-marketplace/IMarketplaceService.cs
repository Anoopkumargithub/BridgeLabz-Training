using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.online_marketplace
{
    internal interface IMarketplaceService
    {
        void AddBook();
        void AddClothing();
        void ApplyDiscountToAll(double percentage);
        void DisplayProducts();
    }
}
