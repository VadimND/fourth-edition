namespace MagnetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twopointtwo = "2.2";

            List<string> a = new List<string>();

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);
            a.RemoveAt(2);            
            
            if(a.Contains("two"))
            {
                a.Add(twopointtwo);
            }
            if (a.Contains("three"))
            {
                a.Add("four");
            }
            if (a.IndexOf("four") != 4)
            {
                a.Add(fourth);
            }
            
            PppPppL(a);
            
            Console.ReadKey();
        }
        static void PppPppL(List<string> a)
        {
            foreach (string element in a)
            {
                Console.WriteLine(element);
            }
        }
    }
}