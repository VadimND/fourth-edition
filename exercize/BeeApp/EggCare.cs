using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeApp
{
    internal class EggCare : Bee
    {
        public EggCare(string name) : base(Queen)
        {
            Queen queen = new Queen();
        }
        new readonly float CostPerShift = 1.35f;

        public const float CARE_PROGRESS_PER_SHIFT = 0.15f;

        public override void WorkTheNextShift(float HoneyConsumed)
        {
            base.WorkTheNextShift(HoneyConsumed);
        }

        protected override string DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
            return base.DoJob();
        }
    }
}
