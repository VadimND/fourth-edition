using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumbleMachine
{
    public class ClassCoins
    {
        private int gumballs;
        private int price;
        public int Price { get { return price; } }

        public ClassCoins(int gumballs, int price)
        {
            this.gumballs = gumballs;
            this.price = price;
        }

        public string DispenseOneGumballs(int Price, int coinsInserted)
        {
            // Check the price field
            if (coinsInserted >= Price)
            {
                gumballs -= 1;
                return "Here's your gumball";
            }
            else
            {
                return "Insert more coins";
            }
        }
    }
}

