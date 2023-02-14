using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeApp
{
    internal class NectarCollector : Bee
    {
        public const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;

        public NectarCollector(string name) : base(name)
        {
        }

        new readonly float CostPerShift = 1.95f;

        public override void WorkTheNextShift(float HoneyConsumed)
        {
            base.WorkTheNextShift(HoneyConsumed);
        }

        protected override string DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
            return base.DoJob();
        }
    }
}
