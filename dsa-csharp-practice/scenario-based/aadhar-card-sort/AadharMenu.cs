using System;
class AadharMenu
{
    public void show()
    {
        int n;
        AadharUtility utility = new AadharUtility();

        do
        {
            Console.WriteLine("Enter 1 to Add a Aadhar Card");
            Console.WriteLine("Enter 2 to sort All The Aadhar Card");
            Console.WriteLine("Enter 3 to search a The Aadhar Card");
            Console.WriteLine("Enter 4 to display all The Aadhar Card");
            Console.WriteLine("Enter 5 to leave");

            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: utility.AddAadhar();
                        break;                        

                case 2: utility.sort();
                        Console.WriteLine("Sorted Aadhars");
                        utility.display();
                        break;
                case 3: utility.search();
                        break;   
                case 4: utility.display();
                        break;
            }
            
        }
        while(n != 5);
    }
}