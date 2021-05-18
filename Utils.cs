using System;

namespace Utils
{
    public static class TextUtilities
    {
        public static void PrintColoredText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void PrintFestiveText(string text, ConsoleColor color1, ConsoleColor color2)
        {
            for(int i = 0; i < text.Length;i++)
            {
                Console.ForegroundColor = (i % 2) == 1 ? color1 : color2;
                Console.Write(text[i]);
            }
            Console.ResetColor();
        }
    }

}