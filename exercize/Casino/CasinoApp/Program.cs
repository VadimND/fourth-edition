using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The Player", Cash = 100 };

            Console.WriteLine("Welcome " + player.Name + "! Your odds equils " + odds);

            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.WriteLine("How much do you want to spend?");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {                        
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You win! You have " + winnings);
                            player.ReceiveCash(winnings);                            
                        }
                        else
                        {                            
                            Console.WriteLine("You lose! You have " + player.Cash);
                        }
                    }                   
                    
                } else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            Console.WriteLine("The house always wins!");
        }
    }
}
