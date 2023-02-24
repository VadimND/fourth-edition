using System.Collections.Generic;

namespace DuckApp
{
    class Duck : IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
            {
                return 1;
            }
            else if (this.Size < duckToCompare.Size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }        
    }
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Loon,
    }
    class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if(x.Size < y.Size)
            {
                return -1;
            }
            if (x.Size > y.Size)
            {
                return 1;
            }
            return 0;
        }
    }
    class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
            {
                return -1;
            }
            if (x.Kind > y.Kind)
            {
                return 1;
            }
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
                new Duck() {Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() {Kind = KindOfDuck.Loon, Size = 15 },
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() {Kind = KindOfDuck.Mallard, Size = 16 },
                new Duck() {Kind = KindOfDuck.Loon, Size = 19 },
                new Duck() {Kind = KindOfDuck.Mallard, Size = 13 },
            };
            IComparer<Duck> sizeComparer = new DuckComparerBySize();
            IComparer<Duck> kindComparer = new DuckComparerByKind();
            ducks.Sort(kindComparer);

            //ducks.Sort(sizeComparer);
            //ducks.Sort();
            PrintDucks(ducks);
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Size} inch {duck.Kind}");
            }
        }
    }
}