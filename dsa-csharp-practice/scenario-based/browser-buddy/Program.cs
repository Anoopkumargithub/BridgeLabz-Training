// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("----Browser Buddy----");
        
        BrowserMenu menu = new BrowserMenu();
        menu.DisplayMenu();
    }
}