using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownApp
{
    internal class ScaryScary : IScaryClown
    {
        private int scaryThingCount;
        private string funnyThingHave;
        public ScaryScary(string funnyThingHave, int scaryThingCount)
        {
            this.funnyThingHave = funnyThingHave;
            this.scaryThingCount = scaryThingCount;
        }
        void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha! Look at my..." + scaryThingCount);
        }
    }
}
