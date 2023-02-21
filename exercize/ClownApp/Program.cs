using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown fingersTheClown = new ScaryScary("big red noise", 14);
            fingersTheClown.Honk();
            IScaryClown iScaryClownRef = fingersTheClown;
            iScaryClownRef.ScareLittleChildren();
        }
    }
}
