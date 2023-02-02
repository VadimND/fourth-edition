using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimApp
{
    internal class ClassCoins
    {
        private int gumballs;
        private int price;
        public int Price { get { return price; } }

        public ClassCoins(int gumballs, int price)
        {
            gumballs = this.gumballs;
            price = Price;
        }

        private string DispenseOneGumballs(int price, int coinsInserted)
        {   
            if(this.coinsInserted >= price)
            {
                gumballs -= 1;
                return "Here's your gumballs";
            } else 
            {
                return "Insert more coins";
            }
        }
    }
}
