using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownApp
{
    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();

        void ScareAdults()
        {
            Console.WriteLine($@"I'm an ancient evil that will haunt for your dreams. 
Behold my terrifying necklace with {random.Next(4, 10)} or my last victim's fingers.

            Oh, also, before I forget...");
            ScareLittleChildren();
        }
    }
}
