using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeApp
{
    internal class HoneyManufacturer : Bee
    {
        public const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;

        public override void WorkTheNextShift(float HoneyConsumed)
        {
            base.WorkTheNextShift(HoneyConsumed);
        }

        protected override string DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
            return base.DoJob();
        }

        public HoneyManufacturer(string name) : base(name)
        {
        }
    }
}
