using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderingVars
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Pizza foxtrot = new Pizza() { Zippo = 2 };
            foxtrot.Bamboo(foxtrot.Zippo);
            Pizza november = new Pizza() { Zippo = 3 };
            Abra tango = new Abra() { Vavavoom = 4 };
            int count = 0;
            while (tango.Lala(november.Zippo))
            {
                count++;
                november.Zippo *= -1;
                november.Bamboo(tango.Vavavoom);
                foxtrot.Bamboo(november.Zippo);
                tango.Vavavoom -= foxtrot.Zippo;
            }
            Console.WriteLine("november.Zippo = " + november.Zippo);
            //Console.WriteLine("foxtrot.Zippo = " + foxtrot.Zippo);
            //Console.WriteLine("tango.Vavavoom = " + tango.Vavavoom);
            //Console.WriteLine("count = " + count);
            Console.ReadLine();
        }
    }
}
