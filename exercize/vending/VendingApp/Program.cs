using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new AnimalFeedVendingMachine();
            //vendingMachine.CheckAmount(1F);
            Console.WriteLine(vendingMachine.Dispense(2.00M));
            Console.ReadKey();
        }
    }
}
