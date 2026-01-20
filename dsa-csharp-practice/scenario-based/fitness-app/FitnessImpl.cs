using System;

internal class FitnessImpl : ITrack
{
    private UserProfile head; // always point to first user
    private UserProfile tail; // always point to last user
    private UserProfile currentUser; // to keep track of current user

    private int userCount; // to keep track of number of users

    
    // add user
    public void AddUser()
    {
        Console.Write("Enter user name: ");
        string name = Console.ReadLine();

        Console.Write("Enter initial steps: ");
        int steps = int.Parse(Console.ReadLine());

        UserProfile newUser = new UserProfile(name, steps, null);

        // if linked list is empty, add user at beginning
        if (head == null)
        {
            head = tail = newUser;
            currentUser = head;
        }
        else
        {
            // add user at the end
            tail.next = newUser;
            tail = newUser;
        }

        userCount++;
        Console.WriteLine("User added successfully.");
    }

    // update steps
    public void UpdateSteps()
    {
        Console.Write("Enter user name to update steps: ");
        string name = Console.ReadLine();

        UserProfile temp = head;
        while (temp != null)
        {
            if (temp.GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter new steps: ");
                int newSteps = int.Parse(Console.ReadLine());
                temp.SetSteps(newSteps); 

                // sort the list after updating steps
                SortLeaderboard();
                Console.WriteLine("Steps updated successfully.");
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("User not found.");
    }

// display leaderboard
    public void DisplayLeaderboard()
    {
        SortLeaderboard();

        Console.WriteLine("Leaderboard:");
        UserProfile temp = head;
        int rank = 1;
        while (temp != null)
        {
            Console.WriteLine(rank + ". " + temp.ToString());
            temp = temp.next;
            rank++;
        }
    }


    //   helper function for sorting the steps in descending order -- use bubble sort
    private void SortLeaderboard()
    {
        if (head == null || head.next == null)
            return;

        bool swapped;
        do
        {
            swapped = false;
            UserProfile current = head;
            while (current.next != null)
            {
                if (current.GetSteps() < current.next.GetSteps())
                {
                  
                    // swap data
                    string tempName = current.GetName();
                    int tempSteps = current.GetSteps();

                    current.SetSteps(current.next.GetSteps());
                    current.next.SetSteps(tempSteps);

                    // swapping names as well
                    current.SetSteps(current.next.GetSteps());
                    current.next.SetSteps(tempSteps);

                    swapped = true;
                }
                current = current.next;
            }
        } while (swapped);
    }
    

}