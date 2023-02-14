using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeApp
{
    internal class Bee
    {        
        public Bee(string name) {
            name = Job;
        }
        public readonly float CostPerShift;
        public string Job;

        protected virtual string DoJob() {
            
        }
        
        public virtual void WorkTheNextShift(float HoneyConsumed)
        {
            if (HoneyVault.ConsumeHoney(HoneyConsumed))
            {
                DoJob();
            }
        }

    }
}
