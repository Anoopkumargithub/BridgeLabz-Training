using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.bird_sanctuary_system
{
    internal class Bird
    {
        protected string name;
        public Bird(string name) 
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Bird name: " + name;
        }
    }



    // eagle
    internal class Eagle : Bird, IFlyable
    {
        public Eagle(string name) : base(name) { }

        public void Fly()
        {
            Console.WriteLine(name + " is flying high in the sky");
        }
    }

    // sparrow
    internal class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name) : base(name) { }

        public void Fly()
        {
            Console.WriteLine(name + " is flying short distances");
        }
    }

    // duck
    internal class Duck : Bird, ISwimmable
    {
        public Duck(string name) : base(name) { }

        public void Swim()
        {
            Console.WriteLine(name + " is swimming in the pond");
        }
    }

    // penguin
    internal class Penguin : Bird, ISwimmable
    {
        public Penguin(string name) : base(name) { }

        public void Swim()
        {
            Console.WriteLine(name + " is swimming in cold water");
        }
    }

    // seagull
    internal class Seagull : Bird, IFlyable, ISwimmable
    {
        public Seagull(string name) : base(name) { }

        public void Fly()
        {
            Console.WriteLine(name + " is flying near the sea");
        }

        public void Swim()
        {
            Console.WriteLine(name + " is swimming on water surface");
        }
    }
}
