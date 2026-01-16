using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

internal class HistoryManipulationImpl : IHistory
{
    private Tab head;  // always point to first tab
    private Tab tail; // always point to latest tab

    private Tab currentTab; // always point to current tab

    // Stack to store closed tabs for reopening
    private Stack<Tab> closedTabs;

    public HistoryManipulationImpl()
    {
        currentTab = head = tail = null;
        closedTabs = new Stack<Tab>();
    }


    //  create New Tab
    public void NewTab()
    {
        System.Console.Write("Enter the Url: ");
        string url = Console.Read();

        Tab newUrl = new Tab(url);

    //  if Linked List  is empty, tab at begining
        if(head == null)
        {
            head = tail = newUrl;

            currentTab = head;
            DisplayTab();
        }
        // linkedList not empty then always add tab at End
        else
        {

            // this case work only, if the user present on the Tail only
            tail.Next = newUrl;
            newUrl.prev = tail;
            tail = newUrl;

            // curent tab is always the most recent tab
            currentTab = tail; 
            DisplayTab();


            // future task-> Add logic for add new tab at any postion 
    
        }
    }

    // --------------------------  Tab Traversing -----------------------------

    // -------------------------- Forward ------------------------------------
    
    public void NextTab()
    {
        Tab current = currentTab;
        if(current.Next == null)
        {
            System.Console.WriteLine("Current Tab is the Most Recent Tab");
        }
        else
        {
            current = current.Next;
            currentTab = current;
            DisplayTab();
        }
    }
    
    // -------------------------------- Backward ------------------------------

    public void PrevTab()
    {
        Tab current = currentTab;

        if(current.Prev == null)
        {
            System.Console.WriteLine("No Previos Tab Present");;
        }
        else
        {
            current = current.Prev;
            currentTab = current;
            DisplayTab();
        }
    }

    // --------------------------------- Closing Tab-----------------------------

    public void CloseTab()
    {
        if (currentTab == null)
        {
            System.Console.WriteLine("No tabs to close");
            return;
        }

        // Store current tab in stack for reopening
        closedTabs.Push(currentTab);

        Tab tabToClose = currentTab;

        // Case 1: Only one tab exists
        if (head == tail && head == tabToClose)
        {
            head = tail = currentTab = null;
        }
        // Case 2: Closing the head tab
        else if (tabToClose == head)
        {
            head = tabToClose.Next;
            head.Prev = null;
            currentTab = head;
        }
        // Case 3: Closing the tail tab
        else if (tabToClose == tail)
        {
            tail = tabToClose.Prev;
            tail.Next = null;
            currentTab = tail;
        }
        // Case 4: Closing a middle tab
        else
        {
            tabToClose.Prev.Next = tabToClose.Next;
            tabToClose.Next.Prev = tabToClose.Prev;
            currentTab = tabToClose.Next;
        }

        if (currentTab != null)
        {
            DisplayTab();
        }
        else
        {
            System.Console.WriteLine("All tabs closed");
        }
    }


    // ---------------------------------Reoping Tab--------------------------------

    public void ReopenTab()
    {
        // Pop the most recently closed tab from stack
        if (closedTabs.Count == 0)
        {
            System.Console.WriteLine("No closed tabs to reopen");
            return;
        }

        Tab reopenedTab = closedTabs.Pop();

        // Case 1: First tab being reopened (no tabs currently exist)
        if (head == null)
        {
            head = tail = reopenedTab;
            reopenedTab.Prev = reopenedTab.Next = null;
        }
        // Case 2: Add reopened tab at the end (as most recent)
        else
        {
            reopenedTab.Prev = tail;
            reopenedTab.Next = null;
            tail.Next = reopenedTab;
            tail = reopenedTab;
        }

        currentTab = tail;
        DisplayTab();
    }
// helper function - Display Tab -------------------------------------------
    private void DisplayTab()
    {
        Tab current = currentTab;
        System.Console.WriteLine($"Current Tab: {current.ToString()}");

    }

}