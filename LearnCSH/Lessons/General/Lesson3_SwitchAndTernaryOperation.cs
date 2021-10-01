using System;
using static System.Console;

namespace Lessons.General
{
    class Lesson3_SwitchAndTernaryOperation
    {
        public static void Start()
        {
            SwitchDemo();
            TernaryDemo();

            // Specific Switch example
            TellMeType(28);
            TellMeType(101);
            TellMeType("just a string");
            TellMeType("just a string converted to array".ToCharArray());
            TellMeType('4');
        }

        private static void TellMeType(object varialbe)
        {
            switch (varialbe)
            {
                case int num when ((0 < num) && (num < 10)):
                    WriteLine("Зачем в свитч добавили возможности if ?! ");
                    break;

                case int num when ((10 < num) && (num < 20)):
                    WriteLine("Зачем в свитч добавили возможности if ?! ");
                    break;

                case int num when ((20 < num) && (num < 30)):
                    WriteLine("Зачем в свитч добавили возможности if ?! ");
                    break;

                case int num when ((30 < num) && (num < 40)):
                    WriteLine("Зачем в свитч добавили возможности if ?! ");
                    break;

                case int num:
                    WriteLine("it is integer!");
                    break;

                case char[] array:
                    WriteLine("it is char array!");
                    break;

                case string str:
                    WriteLine("it is string!");
                    break;

                default:
                    break;
            }
        }

        public static void SwitchDemo()
        {
            WriteLine("МЕНЮ");
            WriteLine("1 - asdasdasd");
            WriteLine("2 - asdasdasd");
            WriteLine("3 - asdasdasd");
            string choice = ReadLine();

            switch (choice)
            {
                case "1":
                    WriteLine("Вы выбрали 1");
                    break;

                case "2":
                    WriteLine("Вы выбрали 2");
                    break;

                case "3":
                    WriteLine("Вы выбрали 3");
                    break;

                default:   // Сработает тогда, когда введенно что-то иное
                    WriteLine("WTF? O_O");
                    break;
            }
        }

        public static void TernaryDemo()
        {
            int result;
            int a = 2;
            int b = 3;

            // if (a < b)
            // {
            //     result = a + b;
            // }
            // else
            // {
            //     result = a - b;
            // }

            // тернарный оператор эквивалентный if написанному выше
            // ... = (условие) ? true : false;
            result = (a < b) ? a + b : a - b;
            WriteLine($"Result = {result}");
        }
    }
}
