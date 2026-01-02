using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_constructors
{
    internal class Person
    {
        private string name;
        private int age;
        private string city;

        // Normal Constructor
        public Person(string name, int age, string city)
        {
            this.name = name;
            this.age = age;
            this.city = city;
        }

        // Copy Constructor
        public Person(Person other)
        {
            this.name = other.name;
            this.age = other.age;
            this.city = other.city;
        }

        public void Display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age  : " + age);
            Console.WriteLine("City : " + city);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Anoop", 23, "Delhi");

            Console.WriteLine("Original Person Details:");
            person1.Display();

            Console.WriteLine();

            Person person2 = new Person(person1);

            Console.WriteLine("Copied Person Details:");
            person2.Display();
        }
    }
}
