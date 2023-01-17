using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clown oneClown = new Clown();
            oneClown.Name = "Boffo";
            oneClown.Height = 14;
            oneClown.TalkAboutYourself();

            Clown anotheClown = new Clown();
            anotheClown.Name = "Biff";
            anotheClown.Height = 16;
            anotheClown.TalkAboutYourself();

            Clown clown3 = new Clown();
            clown3.Name = oneClown.Name;
            clown3.Height = oneClown.Height - 3;
            clown3.TalkAboutYourself();

            anotheClown.Height *= 2;
            anotheClown.TalkAboutYourself();
        }
    }
}
