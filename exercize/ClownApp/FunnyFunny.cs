using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownApp
{
    internal class FunnyFunny : IClown
    {
        private string funnyThingHave { get; }
        public FunnyFunny(string funnyThing)
        {
            this.funnyThingHave = funnyThing;
        }
        void Honk()
        {
            Console.WriteLine("Hi kids! I have a" + funnyThingHave + ".");
        }

    }
}
