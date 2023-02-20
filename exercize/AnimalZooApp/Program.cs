using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZooApp
{
    abstract class Animal
    {
        public abstract void MakeNoise();
    }
    class Hippo : Animal
    {
        public override void MakeNoise ()
        {
            Console.WriteLine("Grunt.");
        }
        public void Swim()
        {
            Console.WriteLine("Splash! I'm going for a swim!");
        }
    }
    abstract class Canine : Animal
    {
        public bool BelongsToPack { get; protected set; } = false;
    }
    class Wolf : Canine
    {
        public Wolf(bool belongsToPack)
        {
            BelongsToPack = belongsToPack;
        }
        public override void MakeNoise()
        {
            if (BelongsToPack) Console.WriteLine("I'm in a pack.");
            Console.WriteLine("Arooooo!");
        }
        public void HuntInPack()
        {
            if (BelongsToPack) Console.WriteLine("I'm going thunting with my pack!");
            else Console.WriteLine("I'm not in a pack.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
