using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program1
{
    static void Main()
    {
        Animal dog = new Dog();
        dog.MakeSound();
    }
}
