using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumbleMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassCoins coins = new ClassCoins(1, 7);
            Console.Write(coins.DispenseOneGumballs(14, 15));
            Console.ReadKey();
        }
    }
}
