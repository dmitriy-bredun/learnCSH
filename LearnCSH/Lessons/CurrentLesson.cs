using System;

using Lessons.Tools;

namespace Lessons
{
    class CurrentLesson
    {
        public static void GoGoGo()
        {
            IfDemonstration();
            OperationsDemonstration();
        }

        public static void IfDemonstration()
        {
            int x = 10;
            int y = 10;

            // Сокращеннвая версия if
            // когда нам нужно выполнить дополнительное действие
            if (x > 1000)
            {
                Console.WriteLine("Дополнительное действие:");
                Console.WriteLine("Снижение цен...");
            }

            // Полная версия if
            // когда нужно выполнить разветвление
            if (x > 10)
            {
                Console.WriteLine("Х > чем 10");

            }
            else
            {
                Console.WriteLine("Х < чем 10");
            }


            // Ресширенная версия if, используется когда
            // у нас много сравнений и блоков
            if (x > y)
            {
                Console.WriteLine("Х > чем Y");
            }
            else if (x < y)
            {
                Console.WriteLine("Х < чем Y");
            }
            else
            {
                Console.WriteLine("Х равен Y");
            }
        }
        public static void OperationsDemonstration()
        {
            Console.Write("Введите число 1: ");
            int dVal1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите число 2: ");
            int dVal2 = Convert.ToInt32(Console.ReadLine()); ;

            int res = 0;
            string operation = Console.ReadLine();
            if (operation == "+")
            {
                res = dVal1 + dVal2;
            } 
            else if (operation == "-")
            {
                res = dVal1 - dVal2;
            }


            // ==================================
            if (dVal1 > 0 && dVal2 > 0)
            {
                Console.WriteLine("Оба больше 0");
            }



        }
    }
}