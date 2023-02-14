using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BeeApp
{
    internal class Queen : Bee
    {
        public Queen(string name) : base(name)
        {
            this.name = name;
            AssignBee("Egg Care");
            AssignBee("Nectar Colector");
            AssignBee("Honey Manufacturer");
        }

        new readonly float CostPerShift = 2.15f;

        private Bee[] workers = new Bee[] { };

        private float unassignedWorkers;
        private float eggs;
        private string name;
        public const float EGGS_PER_SHIFT = .45f;
        public const float HONEY_PER_UNASSIGNED_WORKER = .45f;

        private void AddWorker(Bee worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }

        public void AssignBee(string name)
        {
            switch(name)
            {
                case "Egg Care":
                    AddWorker(new EggCare(this.name));
                    break;
                case "Nectar Collector":
                    AddWorker(new NectarCollector(this.name));
                    break;
                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer(this.name));
                    break;
                default: break;
            }
        }
        public virtual void CareForEggs(float eggsToConvert)
        {
            if (eggs >= eggsToConvert)
            {
                eggsToConvert = eggs - eggsToConvert + unassignedWorkers;
            }
        }
        public override void WorkTheNextShift(float HoneyConsumed)
        {
            base.WorkTheNextShift(HoneyConsumed);
        }

        protected override string DoJob()
        {

            return base.DoJob();

        }
        private void UpdateStatusReport() {
            HoneyVault.StatusReport;
        }
        

    }
}
