using System;

class LegacyAPI
{
    [Obsolete("OldFeature is deprecated. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Old Feature Executed");
    }

    public void NewFeature()
    {
        Console.WriteLine("New Feature Executed");
    }
}

class Program2
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();   // warning
        api.NewFeature();
    }
}
