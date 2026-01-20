using System;

internal class FlashDealzMenu
{
    private IFlashDealz flashDealz;

    public FlashDealzMenu(IFlashDealz flashDealz)
    {
        this.flashDealz = flashDealz;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\nFlash Dealz Menu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products Sorted by Discount");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    flashDealz.DisplayProductsSortedByDiscount();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void AddProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter original price: ");
        decimal originalPrice = decimal.Parse(Console.ReadLine());

        Console.Write("Enter discount percentage: ");
        decimal discount = decimal.Parse(Console.ReadLine());

        Product product = new Product(name, originalPrice, discount);
        flashDealz.AddProduct(product);
        Console.WriteLine("Product added successfully.");
    }
}