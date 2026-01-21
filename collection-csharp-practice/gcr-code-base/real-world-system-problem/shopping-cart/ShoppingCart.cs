using System;
using System.Collections.Generic;
using System.Collections.Specialized;

class ShoppingCart
{
    // Product → Price
    private Dictionary<string, double> priceMap = new Dictionary<string, double>();

    // Maintains insertion order (LinkedDictionary equivalent)
    private OrderedDictionary orderMap = new OrderedDictionary();

    // Add item to cart
    public void AddItem(string product, double price)
    {
        priceMap[product] = price;

        if (!orderMap.Contains(product))
            orderMap.Add(product, price);
    }

    // Display items in order added
    public void DisplayCartOrder()
    {
        Console.WriteLine("Items in Cart (Order Added):");
        foreach (DictionaryEntry item in orderMap)
            Console.WriteLine($"{item.Key} : ₹{item.Value}");
    }

    // Display items sorted by price
    public void DisplaySortedByPrice()
    {
        SortedDictionary<double, List<string>> sorted =
            new SortedDictionary<double, List<string>>();

        foreach (var item in priceMap)
        {
            if (!sorted.ContainsKey(item.Value))
                sorted[item.Value] = new List<string>();

            sorted[item.Value].Add(item.Key);
        }

        Console.WriteLine("\nItems Sorted by Price:");
        foreach (var entry in sorted)
        {
            foreach (var product in entry.Value)
                Console.WriteLine($"{product} : ₹{entry.Key}");
        }
    }

    // Calculate total price
    public double GetTotal()
    {
        double total = 0;
        foreach (double price in priceMap.Values)
            total += price;

        return total;
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        cart.AddItem("Laptop", 55000);
        cart.AddItem("Mouse", 800);
        cart.AddItem("Keyboard", 1500);
        cart.AddItem("Monitor", 12000);

        cart.DisplayCartOrder();
        cart.DisplaySortedByPrice();

        Console.WriteLine($"\nTotal Amount: ₹{cart.GetTotal()}");
    }
}
