﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimPoolApp
{
    interface INose
    {
        int Ear();
        string Face { get; }
    }
    abstract class Picasso : INose
    {
        private string face;
        public virtual string Face
        {
            get { return face; }
        }
        public abstract int Ear();

        public Picasso(string face)
        {
            this.face = face;
        }
    }
    class Clowns : Picasso { 

        public Clowns() : base("Clowns")
        {

        }
        
        public override int Ear()
        {
            return 7;
        }
    }
    class Acts : Picasso
    {
        public Acts() : base("Acts")
        {

        }

        public override int Ear()
        {
            return 5;
        }
    }
    class Of2016 : Clowns
    {
        public override string Face
        {
            get
            {
                return "Of2016";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            INose[] i = new INose[3];
            i[0] = new Acts();
            i[1] = new Clowns();
            i[2] = new Of2016();
            for (int x = 0; x < 3; x++)
            {
                result += $"{i[x].Ear()} {i[x].Face}\n";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
