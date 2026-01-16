using System;


// Doubly Linked 
internal class Tab
{
    // data on Linked List
    public string Url;
    public Tab Prev, Next;

    // constructor
    public Tab(string url)
    {
        this.Url = url;
        Next = Prev = null;
    }

    public override string ToString()
    {
        return Url;
    }

}

