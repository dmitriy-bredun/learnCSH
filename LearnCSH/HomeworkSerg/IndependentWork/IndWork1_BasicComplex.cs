using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using HomeworkSerg.Tools;
using System.Linq;

namespace HomeworkSerg.IndependentWork
{
    internal class IndWork1_BasicComplex
    {
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public static void Start()
        {
            int userChoise = 0;
            do
            {
                userChoise = CT.Menu(
                    "ЗАДАЧА 1 (if + операции);",
                    "ЗАДАЧА 2 (switch)",
                    "ЗАДАЧА 3 (for1)",
                    "ЗАДАЧА 4 (for2)",
                    "ЗАДАЧА 5 (for3)",
                    "ЗАДАЧА 6 (for4)");

                switch (userChoise)
                {
                    case 1:
                        If();
                        break;
                    case 2:
                        Switch();
                        break;
                    case 3:
                        For1();
                        break;
                    case 4:
                        For2();
                        break;
                    case 5:
                        For3();
                        break;
                    case 6:
                        For4();
                        break;
                }
            } while (true);
        }
        public static void If()
        {
            WriteLine();
            WriteLine("Введите двузначное число:");
            WriteLine();
            int numb = Convert.ToInt32(ReadLine());

            if (numb < 100)
            {
                if (numb % 2 == 0)
                {
                    WriteLine("Число четное");
                }
                else WriteLine("Число нечетное");
                WriteLine();

                if (numb < 10)
                {
                    if (numb == 7)
                    {
                        WriteLine("Число = 7ми");
                    }
                    else WriteLine("Число != 7ми");
                    WriteLine();
                }

                else if (numb < 100)
                {
                    string str = numb.ToString();
                    char a = str[0];
                    char b = str[1];
                    int aN = int.Parse(a.ToString());  
                    int bN = int.Parse(b.ToString());

                    if (bN == 7)
                    {
                        WriteLine("Последняя цифра = 7ми");
                    }
                    else WriteLine("Последняя цифра != 7ми");
                    WriteLine();

                    int result = aN + bN;
                    WriteLine($"Сумма цифр числа = {result}");

                    if (result >= 10 && result < 100)
                    {
                        WriteLine("Сумма цифр числа является двузначным числом");
                    }
                    else WriteLine("Сумма цифр числа не является двузначным числом");
                }
                WriteLine();
            }
            else WriteLine("Число не двузначное");

            WriteLine();
        }
        public static void Switch()
        {
            WriteLine();
            WriteLine("На Ваш выбор:");
            WriteLine();
            string[] day = Enum.GetNames(typeof(Day));
            for (int i = 0; i < day.Length; i++)
            {
                WriteLine($"     {i + 1} - {day[i]}");
            }
            WriteLine();
            WriteLine("Выберете день недели:");
            WriteLine();
            int userChoise1 = Convert.ToInt32(ReadLine());
            WriteLine();

            switch (userChoise1)
            {
                case 1:
                    WriteLine($"{Day.Monday}");
                    break;
                case 2:
                    WriteLine($"{Day.Tuesday}");
                    break;
                case 3:
                    WriteLine($"{Day.Wednesday}");
                    break;
                case 4:
                    WriteLine($"{Day.Thursday}");
                    break;
                case 5:
                    WriteLine($"{Day.Friday}");
                    break;
                case 6:
                    WriteLine($"{Day.Saturday}");
                    break;
                case 7:
                    WriteLine($"{Day.Sunday}");
                    break;
            }
        }
        public static void For1()
        {
            WriteLine();
            WriteLine("   ---Сумма от 100 до 500---");
            int size = 500-100+1;
            int[] array = AT.CreateSimplArray(size);
            int numb = 100;
            int sum = 0;

            for (int a = 0; a < array.Length; a++)
            {
                array[a] = numb++;
            }

            for (int a = 0; a < array.Length; a++)
            {
                sum += array[a];
            }

            //int sum = array.Sum();
            WriteLine($"Cумма от 100 до 500: {sum} ");
            WriteLine();
        }
        public static void For2()
        {
            WriteLine();
            WriteLine("   ---Сумма от А до 500---");
            WriteLine();
            WriteLine("   А --->");
            int size = 0;
            int a = Convert.ToInt32(ReadLine());
            
            if (a < 500)
            {
                size = 501 - a;
                int[] array1 = AT.CreateSimplArray(size);
                //int sum = 0;
                WriteLine();

                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = a++;
                    //sum += numb;ыы
                }
                WriteLine();
                int sum = array1.Sum();
                WriteLine($"Cумма от A до 500: {sum} ");
                WriteLine();
            }
            else
            {
                WriteLine("   А > 500");
                //break;
            }
        }
        public static void For3()
        {
            WriteLine();
            WriteLine("   ---Сумма от -10 до B---");
            WriteLine();
            WriteLine("   B --->");
            int size = 0;
            int b = Convert.ToInt32(ReadLine());

            if (b > -10)
            {
                size = 11 + b;

                int[] array2 = AT.CreateSimplArray(size);
                //int sum = 0;
                WriteLine();

                int x = -10;

                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = x;
                    WriteLine($"Число для сохранения в ячейку [{i}]: {x++}");
                    //sum += numb;
                }
                WriteLine();

                int sum = array2.Sum();
                WriteLine($"Cумма от -10 до B: {sum} ");
                WriteLine();
            }
            else
            {
                WriteLine("   B < -10");
            }
        }
        public static void For4()
        {
            WriteLine();
            WriteLine("   ---Сумма от А до B---");
            WriteLine();
            WriteLine("   А --->");
            int size = 0;
            int a = Convert.ToInt32(ReadLine());
            WriteLine();
            WriteLine("   B --->");
            int b = Convert.ToInt32(ReadLine());

            if (a <= b)
            {
                size = b - a;
                size += 1;
                int[] array3 = AT.CreateSimplArray(size);
                //int sum = 0;
                WriteLine();

                for (int i = 0; i < array3.Length; i++)
                {
                    WriteLine($"Число для сохранения в ячейку [{i}]: {a}");
                    array3[i] = a++;
                    //sum += numb;ыы
                }
                WriteLine();
                int sum = array3.Sum();
                WriteLine($"Cумма от A до B: {sum} ");
                WriteLine();
            }
            else
            {
                WriteLine("   А > B");
            }
        }
    }
}

