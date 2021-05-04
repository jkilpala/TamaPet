using System;

namespace Tama
{
    public class Creature
    {
        public string Name;
        public int Hunger;
        public int Happines;
        public int Health;


        public void Feed(int value)
        {
            Hunger -= value;
        }

        public void PrintStats()
        {
            Console.WriteLine("Namez: " +Name);
            Console.WriteLine("Hunger: " +Hunger);
            Console.WriteLine("Happines: " +Happines);
            Console.WriteLine("Health: " +Health);
        }

    }
}