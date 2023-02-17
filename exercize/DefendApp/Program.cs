using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefendApp
{
    class TallGuy : IClown
    {
        public string FunnyThingHave
        {
            get { return "big shoes"; }
        }
        public void Honk()
        {
            Console.WriteLine("Honk honk");
        }
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {            
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() {Height = 76, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
            Console.WriteLine($"The tall guy has {tallGuy.FunnyThingHave}");
            tallGuy.Honk();
            Console.ReadKey();
        }
    }
}
