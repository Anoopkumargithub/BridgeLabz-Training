using System;
using System.Globalization;
using System.Linq.Expressions;
class AadharUtility
{
    Aadhar[] aadhars = new Aadhar[3];
    int currentIndex = 0;

    public void AddAadhar()
    {
        if(currentIndex >= 10)
        {
            Console.WriteLine("No enough space");
            return ;
        }
        Console.WriteLine("Enter the Aadhar Number");
        long Number = long.Parse(Console.ReadLine());
        int  len = (int)Math.Log10(Number)+1;
        if(len != 12)
        {
            Console.WriteLine("Please Enter a valid Aadhar Number");
            AddAadhar();
            return ;
        }
        Console.WriteLine("Enter the Name");
        string name = Console.ReadLine();
        aadhars[currentIndex++] = new Aadhar(Number, name);
        Console.WriteLine("Aadhar Added Successfully");
    }
    public void sort()
    {
        int ten = 1;
        for(int i = 0; i < 12; i++)
        {            
            radix(ten , aadhars);
            ten *= 10;
        }
    }

    public void radix(int exp, Aadhar[] aadhars)
    {
        int[]count = new int[10];
        Aadhar[]output = new Aadhar[100];

        int n = aadhars.Length;
        for(int i = 0; i < n; i++)
        {
            count[(aadhars[i].AadharNumber / exp ) % 10]++;
        }

        for(int i = 1; i < 10; i++)
        {
            count[i] += count[i-1];
        }

        for(int i = n-1; i >= 0; i--)
        {
            output[count[(aadhars[i].AadharNumber / exp) % 10] - 1] = aadhars[i];
            count[(aadhars[i].AadharNumber / exp ) % 10]--;
        }

        for(int i = 0; i < n; i++)
        {
            aadhars[i] = output[i];
        }
    }

    public void search(){
        sort();
        Console.WriteLine("Enter the Aadhar Number which you want to find");
        long number = long.Parse(Console.ReadLine());
        int l = 0;
        int r = currentIndex-1;
        while(l <= r)
        {
            int mid = (l + r) / 2;
            if(aadhars[mid].AadharNumber == number)
            {
                Console.WriteLine(aadhars[mid].ToString());
                return ;
            }
            else if(aadhars[mid].AadharNumber > number)
            {
                r = mid - 1;
            }
            else l = mid + 1;
        }

        Console.WriteLine("No Aadhar Found");
        return ;
        
    }

    public void display()
    {
        for (int i = 0; i < currentIndex; i++)
        {
            Console.WriteLine(aadhars[i].ToString());
        }
    }
}