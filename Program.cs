using System;
using Utils;

namespace Tama
{
    class Program
    {
        static Creature TeachersPet;
        static Creature MirvasPet;

        static bool IsRunning = true;

        static void Main(string[] args)
        {
            // TeachersPet = new Creature();
            // TeachersPet.Name = "Pera";
            // TeachersPet.Health = 100;
            // TeachersPet.Happines = 100;
            // TeachersPet.Hunger = 0;

            TeachersPet = new Creature() 
            { 
                Name = "Kalle",
                Health = 100,
                Happines = 100,
                Hunger = 0
            };


            MirvasPet = new Creature();
            
            while(IsRunning)
            {
                PrintMenu();

                var isAlive = TeachersPet.AgePet();
                if(!isAlive)
                {
                    Console.WriteLine("Your pet died!");
                    IsRunning = false;
                }
                //Console.ReadKey();
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
        static void PrintPlayMenu()
        {
            Console.WriteLine("1 - Boxing");
            Console.WriteLine("2 - WWE");
            Console.WriteLine("3 - Dance");
            Console.WriteLine("0 - Back");

            var keyInput = Console.ReadKey(true);

            switch(keyInput.Key)
            {
                case ConsoleKey.D1:
                TeachersPet.Play(PlayType.Boxing);
                break;
                case ConsoleKey.D2:
                TeachersPet.Play(PlayType.WWE);
                break;
                case ConsoleKey.D3:
                TeachersPet.Play(PlayType.Dancing);
                break;
                case ConsoleKey.D0:
                PrintMenu();
                break;
            }
        }
        static void PrintFoodMenu()
        {
            Console.WriteLine("1 - Candy");
            Console.WriteLine("2 - Burger");
            Console.WriteLine("3 - Lettuce");
            Console.WriteLine("0 - Back");

            var keyInput = Console.ReadKey(true);

            switch(keyInput.Key)
            {
                case ConsoleKey.D1:
                TeachersPet.Feed(FoodType.Candy);
                break;
                case ConsoleKey.D2:
                TeachersPet.Feed(FoodType.Burger);
                break;
                case ConsoleKey.D3:
                TeachersPet.Feed(FoodType.Lettuce);
                break;
                case ConsoleKey.D0:
                PrintMenu();
                break;
            }
        }
        static void PrintMenu()
        {
            Console.Clear();
            TextUtilities.PrintColoredText("1 - Pet stats\n", ConsoleColor.DarkYellow);
            //Console.WriteLine("1 - Pet stats");
            TextUtilities.PrintFestiveText("2 - Feed pet\n", ConsoleColor.DarkGreen, ConsoleColor.DarkRed);
            Console.WriteLine("3 - Play with pet");
            Console.WriteLine("0 - Quit");
            
            var keyInput = Console.ReadKey(true);

            switch(keyInput.Key)
            {
                case ConsoleKey.D1:
                TeachersPet.PrintStats();
                break;
                case ConsoleKey.D2:
                PrintFoodMenu();
                break;
                case ConsoleKey.D3:
                PrintPlayMenu();
                break;
                case ConsoleKey.D0:
                IsRunning = false;
                break;
            }



            // Console.WriteLine("Namez: " +TeachersPet.Name);
            // Console.WriteLine("Hunger: " +TeachersPet.Hunger);
            // Console.WriteLine("Happines: " +TeachersPet.Happines);
            // Console.WriteLine("Health: " +TeachersPet.Health);

            // Console.WriteLine("Namez: " +MirvasPet.Name);
            // Console.WriteLine("Hunger: " +MirvasPet.Hunger);
            // Console.WriteLine("Happines: " +MirvasPet.Happines);
            // Console.WriteLine("Health: " +MirvasPet.Health);
        }
    }
}
