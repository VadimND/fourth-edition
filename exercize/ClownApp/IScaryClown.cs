using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownApp
{
    internal interface IScaryClown : IClown
    {
        string ScaryThingHave { get; }
        void ScareLittleChildren();
    }
}
