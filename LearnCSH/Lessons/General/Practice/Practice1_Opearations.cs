using System;

namespace Lessons.General.Practice
{
    class Practice1_Opearations
    {
        public static void Start()
        {
            Console.WriteLine("PRACTICE MENU:");
            Console.WriteLine("1 - Задача про ВДВшников");
            Console.WriteLine("2 - Задача про калькулятор");
            Console.Write("---> ");
            string usersChoice = Console.ReadLine();

            if (usersChoice == "1")
            {
                Task1();

            }
            else if (usersChoice == "2")
            {
                Task2();
            }
            else
            {
                Console.WriteLine("Что за херню ты тут ввел ?! О_О");
            }
        }

        public static void Task1()
        {
            Console.WriteLine("Введите границы карты...");
            Console.Write("введите размер х: ");
            string sizeXStr = Console.ReadLine();

            Console.Write("введите размер у: ");
            string sizeYStr = Console.ReadLine();

            Console.WriteLine("Введите координаты десантников: ");
            Console.Write("введите координату х: ");
            string cordXStr = Console.ReadLine();

            Console.Write("введите кординаты у: ");
            string cordYStr = Console.ReadLine();

            int cordX = Convert.ToInt32(cordXStr);
            int cordY = Convert.ToInt32(cordYStr);

            int sizeX = Convert.ToInt32(sizeXStr);
            int sizeY = Convert.ToInt32(sizeYStr);

            if (cordX <= sizeX && cordY <= sizeY && cordX > 0 && cordY > 0)
            {
                Console.WriteLine("ЗА ВДВ");
            }
            else
            {
                Console.WriteLine("Мы в дерьме!");
            }
        }

        public static void Task2()
        {
            Console.WriteLine("Маленький калькулятор");
            Console.Write("Введите число 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите символ арифметической операции: ");
            string operation = Console.ReadLine();

            int result;

            if (operation == "*")
            {
                result = a * b;
                Console.WriteLine($"result of {a} * {b} = {result}");
            }
            else if (operation == "+")
            {
                result = a + b;
                Console.WriteLine($"result of {a} + {b} = {result}");
            }
            else if (operation == "-")
            {
                result = a - b;
                Console.WriteLine($"result of {a} - {b} = {result}");
            }
            else if (operation == "/")
            {
                result = a / b;
                Console.WriteLine($"result of {a} / {b} = {result}");
            }
            else
            {
                Console.WriteLine("Тю... Ты придурок что ли ?");
            }
        }
        
    }
}
