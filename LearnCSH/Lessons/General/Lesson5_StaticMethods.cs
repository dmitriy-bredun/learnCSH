using System;

using static System.Console;

namespace Lessons.General
{
    /*
     *           ----- CONSOLE HELPER CLASS ----- 
     *  Главная задача: упрощать работу с консолью.
     *  Должен иметь методы, позволящие осуществлять в консоль ввод/вывод.
     */
    class CH
    {
        public static void PrintInt(string txt, int value)
        {
            WriteLine($"{txt} = {value}");
        }

        public static int EnterInt(string txt)
        {
            Write($"{txt}: ");
            int value = Convert.ToInt32(ReadLine());
            return value;
        }
    }

    class Lesson5_StaticMethods
    {
        public static void Start()
        {
            ////////////////////////////////////////////////////////////
            // ПРИМЕР МЕТОДА С ПЕРЕДАЧЕЙ ДАННЫХ ------------------------
            //
            int x = 5;
            int y = 8;
            bool result = Method(x, y);

            if (result)
            {
                WriteLine($"Result = {result}, Сумма х + у больше 0!");
            }
            else
            {
                WriteLine($"Result = {result}, Сумма х + у меньше 0!");
            }

            ////////////////////////////////////////////////////////////
            // ПРИМЕР РАБОТЫ С CONSOLE HELPER --------------------------
            // Пример с выводом данных: output
            //
            int summ = 12345;
            WriteLine($"Sum = {summ}");
            // Используя ConsoleHelper можно упростить до:
            CH.PrintInt("Sum", summ);


            // Пример с вводом данных: input
            //
            Write("Введите координату Х: ");
            int coordX = Convert.ToInt32(Console.ReadLine());
            // Используя ConsoleHelper можно упростить до:
            int val = CH.EnterInt("Введите координату Х морпехов");
        }

        public static bool Method(int value1, int value2)
        {
            bool moreThenZero = value1 + value2 > 0;
            return moreThenZero;
        }
    }
}
