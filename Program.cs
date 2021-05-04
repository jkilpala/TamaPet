using System;

namespace Tama
{
    class Program
    {
        static int WheelResult;
        static Creature TeachersPet;
        static Creature MirvasPet;

        static bool IsRunning = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TeachersPet = new Creature();
            TeachersPet.Name = "Pera";

            MirvasPet = new Creature();
            
            while(IsRunning)
            {
                PrintMenu();

                TeachersPet.AgePet();
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
                TeachersPet.Play(5);
                break;
                case ConsoleKey.D2:
                TeachersPet.Play(30);
                break;
                case ConsoleKey.D3:
                TeachersPet.Play(1);
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
                TeachersPet.Feed(5);
                break;
                case ConsoleKey.D2:
                TeachersPet.Feed(30);
                break;
                case ConsoleKey.D3:
                TeachersPet.Feed(1);
                break;
                case ConsoleKey.D0:
                PrintMenu();
                break;
            }
        }
        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Pet stats");
            Console.WriteLine("2 - Feed pet");
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
