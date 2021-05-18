using System;

namespace Tama
{
    public enum PlayType
    {
        Boxing, 
        WWE,
        Dancing
    }
    public enum FoodType
    {
        Candy,
        Burger,
        Lettuce
    }
    public class Creature
    {
        public string Name;
        public int Hunger;
        public int Happines;
        public int Health;

        public int LettuceLimit = 5;
        int Age = 0;

        public bool AgePet()
        {
            Age++;
            CalculateAgeingAffects();

            if(Health > 0)
                return true;
                
            return false;

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
        public void Feed(FoodType foodType)
        {
            if(foodType == FoodType.Candy)
            {
                Health -= 5;
                Happines += 15;
                Hunger -= 5;
            }
            else if(foodType == FoodType.Burger)
            {
                Health -= 10;
                Happines += 15;
                Hunger -= 20;
            }
            else if(foodType == FoodType.Lettuce)
            {
                if(LettuceLimit > 0)
                {
                    Health += 5;
                    Happines -= 15;
                    Hunger -= 5;
                    LettuceLimit -=1;
                }
                else
                {
                    Health -= 5;
                    Happines -= 30;
                    Hunger -= 5;                    
                }

            }
        }
        public void Play(PlayType playType)
        {
            switch(playType)
            {
                case PlayType.Boxing:
                Health -= 20;
                Happines += 20;
                Hunger += 20;
                break;
                case PlayType.WWE:
                Health -= 40;
                Happines += 40;
                Hunger += 10;
                break;
                case PlayType.Dancing:
                Health += 10;
                Happines += 20;
                Hunger += 20;
                break;
            }
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