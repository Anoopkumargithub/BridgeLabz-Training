using System;

internal class Product
{
    private string name;
    private decimal originalPrice;
    private decimal discount;

    public Product(string name, decimal originalPrice, decimal discount)
    {
        this.name = name;
        this.originalPrice = originalPrice;
        this.discount = discount;
    }

    public string GetName
    {
        get { return name; }
    }

    public decimal GetOriginalPrice
    {
        get { return originalPrice; }
    }

    public decimal GetDiscount
    {
        get { return discount; }
    }

    // calculate discounted price

    // Override ToString method for easy display
    public override string ToString()
    {
        return "Product Name: " + name + ", Original Price: " + originalPrice.ToString() + ", Discount: " + discount + "%";
    }
}