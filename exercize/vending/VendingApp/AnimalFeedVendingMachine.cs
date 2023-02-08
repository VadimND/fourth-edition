using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    internal class AnimalFeedVendingMachine : VendingMachine
    {
        public override string Item { 
            get
            {
                return "a handful of animal feed";
            }
        }
        protected override bool CheckAmount(decimal money)
        {
            return money >= 1.25M;
        }
    }

}
