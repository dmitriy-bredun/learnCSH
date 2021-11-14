using static System.Console;
using System;
using Lessons.Tools;

namespace Lessons
{
    class CurrentLesson
    {
        public static void GoGoGo()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            string age = Console.ReadLine();



            Console.WriteLine($" Р Е З У Л Ь Т А Т");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
        }
    }
}