using static System.Console;

namespace Lessons.General
{
    class Lesson3_SwitchAndTernaryOperation
    {
        public static void Start()
        {
            SwitchDemo();
            TernaryDemo();
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
