using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace BirdApp
{
    class Bird
    {
        public string Name { get; set; }
        public virtual void Fly(string destination)
        {
            Console.WriteLine($"{this} is flying to {destination}");
        }

        public override string ToString()
        {
            return $"A bird named {Name}";
        }

        public static void FlyAway(List<Bird> flock, string destination)
        {
            foreach (Bird bird in flock)
            {
                bird.Fly(destination);
            }
        }
    }

    class Duck : Bird
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }
    }
    
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Loon,
    }
        
    class Program
    {
        public static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 13 },
            };

            IEnumerable<Bird> upcastDucks = ducks;
            Bird.FlyAway(upcastDucks.ToList(), "Minnesota");
        }
    }    
}