using System;
using System.Collections.Generic;

namespace BeeKeeping
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

       
    }
    public class BeeHive
    {
        public List<Bee> Bees = new List<Bee>();
        public int MaxAmount;
        public double CollectHoney(int days)
        {
            double Amount = 0;
            foreach (Bee bee in Bees)
            {
                var A = days * bee.Size * 0.2;
                Amount = Amount + A;
            }
            return Amount;
        }
    }

    public class Bee
    {
        public string Name;
        public float Size;

        public Bee(string name, float size)
        {
            Name = name;
            Size = size;
        }
    }
}
