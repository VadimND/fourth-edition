using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallGame
{
    internal static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        public static int GetPot()
        {
            return pot;
        }
        public static void Guess(bool higher)
        {
            int num = random.Next(1, MAXIMUM + 1);
            if ((higher && num >= currentNumber) || (!higher && num <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            } else
            {
                Console.WriteLine("Bad luck, you guessed wrong");
                pot--;
            }
            currentNumber = pot;
            Console.WriteLine("The current number is " + currentNumber);
        }
        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
            {
                Console.WriteLine($"The number is at least {half}");
            } else
            {
                Console.WriteLine($"The number is at most {half}");
            }           
            pot--;
        }

    }
}
