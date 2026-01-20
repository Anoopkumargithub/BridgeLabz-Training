using System;

internal class UserProfile
{
    private string name;
    private int steps;

    public UserProfile next;

    public UserProfile(string name, int steps, UserProfile next)
    {
        this.name = name;
        this.steps = steps;
        this.next = null;
    }

    // get name
    public string GetName()
    {
        return name;
    }

    // get steps
    public int GetSteps()
    {
        return steps;
    }

    // set steps
    public void SetSteps(int steps)
    {
        this.steps = steps;
    }

    // override ToString method
    public override string ToString()
    {
        return "Name: " + name + ", Steps: " + steps;
    }
}