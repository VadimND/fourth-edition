using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ElephantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 5 for speakTo (Lucinda), 6 for speakto (lloyd)");

            while(true)
            {
                char keyChar = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + keyChar);
                if (keyChar == '1')
                {
                    Console.WriteLine("Callind lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (keyChar == '2')
                {
                    Console.WriteLine("Callind lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (keyChar == '3')
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("References have been swapped.");
                }
                else if (keyChar == '4')
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if(keyChar == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                }
                else if(keyChar == '6')
                {
                    lloyd.SpeakTo(lucinda, "Hi, Lucinda!");
                }
                else return;               
            }          
            
        }
        
    }
}
