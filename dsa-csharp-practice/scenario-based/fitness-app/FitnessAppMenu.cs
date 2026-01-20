using System;

internal class FitnessAppMenu
{
    public static void ShowMenu()
    {
        FitnessImpl fitnessImpl = new FitnessImpl();
        int choice = 0;

        do
        {
            Console.WriteLine("\n--- Fitness App Menu ---");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Update Steps");
            Console.WriteLine("3. Display Leaderboard");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    fitnessImpl.AddUser();
                    break;
                case 2:
                    fitnessImpl.UpdateSteps();
                    break;
                case 3:
                    fitnessImpl.DisplayLeaderboard();
                    break;
                case 4:
                    Console.WriteLine("Exiting the application.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 4);
    }
}