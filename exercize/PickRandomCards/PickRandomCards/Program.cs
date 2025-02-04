﻿using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько карт? ");
            string line = Console.ReadLine();
            int count = 1;
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(count++ + ". " + card);
                }
            }
            else
            {
                Console.WriteLine("Число не определено");
            }
        }
    }
}