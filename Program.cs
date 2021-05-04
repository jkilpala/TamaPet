using System;

namespace Tama
{
    class Program
    {
        static int WheelResult;
        static Creature TeachersPet;
        static Creature MirvasPet;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TeachersPet = new Creature();
            TeachersPet.Name = "Pera";

            MirvasPet = new Creature();
            
            while(true)
            {
                PrintMenu();

                Console.ReadKey();
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Pet stats");
            Console.WriteLine("2 - Feed pet");
            Console.WriteLine("3 - Play with pet");
            Console.WriteLine("0 - Quit");
            
            var keyInput = Console.ReadKey();

            switch(keyInput.Key)
            {
                case ConsoleKey.D1:
                TeachersPet.PrintStats();
                break;
                case ConsoleKey.D2:
                TeachersPet.Feed(10);
                break;
                case ConsoleKey.D3:
                break;
                case ConsoleKey.D0:
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
