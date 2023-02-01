using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassQ q = new ClassQ(ClassQ.R.Next(2) == 1);
            while (true)
            {
                Console.Write($"{q.N1} {q.Op} {q.N2} = ");
                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }
                if (q.Check(i))
                {
                    Console.WriteLine("Right!");
                    q = new ClassQ(ClassQ.R.Next(2) == 1);
                }
                else Console.WriteLine("Wrong! Try again.");
            }
        }
        
    }
}
