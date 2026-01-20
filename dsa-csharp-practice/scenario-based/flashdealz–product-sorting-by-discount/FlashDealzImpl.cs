using System;

class FlashDealzImpl : IFlashDealz
{
    private Product[] products = new Product[100];
    private int count = 0;

    public void AddProduct(Product product)
    {
        if (count < products.Length)
        {
            products[count++] = product;
        }
        else
        {
            Console.WriteLine("Product list is full.");
        }
    }

// display products sorted by discount in descending order -- Quick Sort 
    public void DisplayProductsSortedByDiscount()
    {
        QuickSort(products, 0, count - 1);

        Console.WriteLine("Products sorted by discount (highest to lowest):");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(products[i]);
            // calculate and display discounted price
            decimal discountedPrice = products[i].GetOriginalPrice * (1 - products[i].GetDiscount / 100);
            Console.Write(", Discounted Price: " + discountedPrice.ToString("F2"));
            Console.WriteLine();
        }
    }


// helper function for Quick Sort
    private void QuickSort(Product[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

// partition function for Quick Sort
    private int Partition(Product[] arr, int low, int high)
    {
        decimal pivot = arr[high].GetDiscount;
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (arr[j].GetDiscount > pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return i + 1;
    }

// swap function
    private void Swap(Product[] arr, int i, int j)
    {
        Product temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}

