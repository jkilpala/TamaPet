using System;

namespace Tama
{
    public class Creature
    {
        public string Name;
        public int Hunger;
        public int Happines;
        public int Health;
        int Age = 0;

        public void AgePet()
        {
            Age++;
            CalculateAgeingAffects();
        }

        void CalculateAgeingAffects()
        {
            Happines -= Age;
            Hunger += 5;
            Health -= Hunger;
        }

        public void Feed(int value)
        {
            Hunger -= value;
        }

        public void Play(int value)
        {
            Happines += value;
        }
        public void PrintStats()
        {
            Console.WriteLine("Age: " +Age);
            Console.WriteLine("Namez: " +Name);
            Console.WriteLine("Hunger: " +Hunger);
            Console.WriteLine("Happines: " +Happines);
            Console.WriteLine("Health: " +Health);

            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }

    }
}