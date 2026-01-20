using System;

class FlashDealz
{
    static void Main(string[] args)
    {
        IFlashDealz flashDealz = new FlashDealzImpl();
        FlashDealzMenu menu = new FlashDealzMenu(flashDealz);
        menu.ShowMenu();
    }
}