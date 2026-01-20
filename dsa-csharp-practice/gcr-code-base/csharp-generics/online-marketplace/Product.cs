using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.online_marketplace
{
    internal class Product<T> where T : ICategory
    {
        public string Name { get; private set; }
        public double Price { get; set; }
        public T Category { get; private set; }

        public Product(string name, double price, T category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} | Category: {Category.GetCategoryName()} | Price: {Price}";
        }
    }
}
