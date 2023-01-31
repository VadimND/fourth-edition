using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Secret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HasSecret keeper = new HasSecret();
            //Console.WriteLine(keeper.secret);
            FieldInfo[] fields = keeper.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.GetValue(keeper));
            }
            Console.ReadLine();
        }
    }
}
