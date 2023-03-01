using LumberJackApp;
using System.Collections;

namespace LumberJackApp
{
    class Lumberjack
    {
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        public string Name { get; private set; }

        public Lumberjack(string name)
        {
            Name = name;
        }

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while (flapjackStack.Count > 0)
            {
                Console.WriteLine(
                    $"{Name} ate a {flapjackStack.Pop().ToString().ToLower()} flapjack");
            }
        }
    }

    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();

            string name;
            Console.Write("First lumberjack's name: ");
            while ((name = Console.ReadLine()) != "")
            {
                Console.Write("Number of flapjacks: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Lumberjack lumberjack = new Lumberjack(name);
                    for (int i = 0; i < number; i++)
                    {
                        lumberjack.TakeFlapjack((Flapjack)random.Next(0, 4));
                    }
                    lumberjacks.Enqueue(lumberjack);
                }
                Console.Write("Next lumberjack's name (blank to end): ");
            }

            while (lumberjacks.Count > 0)
            {
                Lumberjack next = lumberjacks.Dequeue();
                next.EatFlapjacks();
            }
        }
    }

}