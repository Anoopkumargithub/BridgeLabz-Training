using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.online_marketplace
{
    internal class BookCategory : ICategory
    {
        public string GetCategoryName()
        {
            return "Book";
        }
    }

    internal class ClothingCategory : ICategory
    {
        public string GetCategoryName()
        {
            return "Clothing";
        }
    }
}
