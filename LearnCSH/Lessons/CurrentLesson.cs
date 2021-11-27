using System;
using Lessons.Tools;

using static System.Console;

namespace Lessons
{
    class CurrentLesson
    {
        public static void GoGoGo()
        {
            //ConsoleDemo();

            SwitchDemo();

        }

        public static void SwitchDemo()
        {
            WriteLine("-- Menu --");
            WriteLine("1 - Калькулятор");
            WriteLine("2 - task2");
            WriteLine("3 - task3");
            Write("enter your choice: ");
            int userChoice = Convert.ToInt32(ReadLine());

            switch (userChoice)
            {
                case 1:
                    WriteLine("Пользователь ввел 1, запущен маленький калькулятор...");
                    SmallCalc();
                    break;

                case 2:
                    Task2();
                    break;

                case 3:
                    Task3();
                    break;

                default:
                    WriteLine("Выбран не сущесвтвующий пункт в меню...");
                    break;
            }
        }


        public static void SmallCalc()
        {
            Write("Введите число 1: ");
            int x = Convert.ToInt32(ReadLine());

            Write("Введите число 2: ");
            int y = Convert.ToInt32(ReadLine());

            Write("Введите знак операции:");
            string operation = ReadLine();

            int result = 0;

            switch (operation)
            {
                case "+":
                    result = x + y;
                    break;

                case "-":
                    result = x - y;
                    break;

                case "*":
                    result = x * y;
                    break;

                case "/":
                    result = x / y;
                    break;

                default:
                    WriteLine("Введен не верный знак операции...");
                    break;
            }

            WriteLine($"Результат операции = {result}");

        }

        public static void Task2()
        {
            WriteLine("Task2");
        }

        public static void Task3()
        {
            WriteLine("Task3");
        }

        private static void ConsoleDemo()
        {
            //Дима, а как писать тест в консоль и в этой же строке в неё вводить что-нибудь?
            
            int dickLength = -10;

            Write("Введите размер вашей достопримечательности: ");
            dickLength = Convert.ToInt32(ReadLine());

            Write($"Размер вашей достопримечательности = {dickLength}");
        }
    }
}