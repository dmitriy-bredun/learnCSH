using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.General
{
    internal class Homework5_Cycles
    {
        public static void Start()
        {
            WriteLine();
            WriteLine("     Homework5_Cycles (a.k.a ПРЕВОЗМОГАНИЕ И СТРАДАНИЕ)");
            WriteLine();

            int useChoice = 0;
            do
            {
                WriteLine("     1)  Task 1 - press '1' ");
                WriteLine("     2)  Task 2 - press '2' ");
                WriteLine("     3)  Task 3 - press '3' ");
                WriteLine("     4)  Task 4 - press '4' ");
                WriteLine("     5)  Task 5 - press '5' ");
                WriteLine("     6)  Task 6 - press '6' ");
                WriteLine("     7)  Task 7 - press '7' ");
                WriteLine("     8)  Task 8 - press '8' ");
                WriteLine("     9)  TestBox - press '9' ");
                WriteLine("     10) Exit - press '0' ");
                WriteLine();

                Write("     Your choice  --->   ");
                useChoice = Convert.ToInt32(ReadLine());
                WriteLine();

                switch (useChoice)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
                        break;

                    case 5:
                        Task5();
                        break;

                    case 6:
                        Task6();
                        break;

                    case 7:
                        Task7();
                        break;

                    case 8:
                        Task8();
                        break;

                    case 9:
                        Test();
                        break;

                    case 0:
                        break;

                    default:
                        WriteLine("     You missed. Try again ;)");
                        break;
                }
                WriteLine();
            } while( useChoice != 0);
        }
        public static void Task1()
        {
            WriteLine(" Task 1 - С помощью цикла вывести в консоль 15 символов:");
            WriteLine("          0 1 0 1 0 1 0 1 0 1 0 1 0 1 0");
            WriteLine();

            WriteLine("Solution:");
            WriteLine();
            
            int val = 1;
           
            while (val <= 15)
            {
                if (val % 2 == 0)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                val += 1;
            }    
            WriteLine();
        }
        public static void Task2()
        {
            WriteLine(" Task 2 - С помощью цикла вывести к консоль 15 символов:");
            WriteLine("          0 0 0 0 5 0 0 0 0 10 0 0 0 0 15");
            WriteLine();

            WriteLine("Solution:");
            WriteLine();

            int val2 = 1;
            while(val2 <= 15)
            {
                if (val2 % 5 != 0)
                {
                    Write("0 ");
                }
                if (val2 % 5 == 0)
                {
                    Write($"{val2} ");
                }
                val2 += 1;
            }
            WriteLine();
        }
        public static void Task3()
        {
            WriteLine(" Task 3 - С помощью цикла вывести в консоль 15 символов:");
            WriteLine("          0 0 0 0 5 1 0 1 0 10 0 0 0 0 15");
            WriteLine();

            WriteLine("Solution:");
            WriteLine();

            int val3 = 1;
            while (val3 < 16)
            {
                if (val3 % 5 == 0)
                {
                    Write($"{val3} ");
                }
                else if (val3 % 2 == 0 && val3 > 5 && val3 < 9)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                //if (val3 % 2 == 0 && val3 > 5 && val3 < 9)
                //{
                //    Write("1 ");
                //}
                //if (val3 % 5 != 0)
                //{
                //    Write("0 ");
                //}
                //if (val3 % 5 == 0)
                //{
                //    Write($"{val3} ");
                //}
                val3 += 1;
            }
            WriteLine();

        }
        public static void Task4()
        {
            WriteLine(" Task 4 - С помощью цикла вывести в консоль 10 символов:");
            WriteLine("          1 2 3 4 5 10 9 8 7 6");
            WriteLine();

            WriteLine("Solution:");
            WriteLine();

            int val4 = 1;
            while (val4 <= 5)
            {
                Write($"{val4} ");
                val4 += 1;
            }

            int val41 = 10;
            while (val41 >= 6 )
            {
                Write($"{val41} ");
                val41 -= 1;
            }

            WriteLine();
        }
        public static void Task5()
        {
            WriteLine(" Task 5 - С помощью цикла вывести к консоль 10 символов:");
            WriteLine("          [ + + + + + + + + - - ]");
            WriteLine();

            WriteLine("Solution:");
            WriteLine();

            int lim = 12;
            int val5 = 0;
            while (val5 < lim)
            {
                if (val5 < 1)
                {
                    Write("[");
                }
                else if (val5 <= 8)
                {
                    Write("+ ");
                }
                else if (val5 <= 10)
                {
                    Write("- ");
                }
                else
                {
                    Write("]");
                }
                val5 += 1;
            }

            WriteLine();
        }
        public static void Task6()
        {
            
            WriteLine(" Task 6");
            WriteLine();

            WriteLine(" Numb 1:");
            int a = Convert.ToInt32(ReadLine());
            WriteLine();

            WriteLine(" Numb 2:");
            int b = Convert.ToInt32(ReadLine());
            WriteLine();

            int range = 0;

            if (a <= b)
            {
                while (a <= b)
                {
                    if (a % 7 == 0 || a % 13 == 0 && a > 0)
                    {
                        range += a;
                    }
                    a += 1;
                }
            }
            else
            {
                while (b <= a)
                {
                    if (b % 7 == 0 || b % 13 == 0 && b > 0)
                    {
                        range += b;
                    }
                    b += 1;
                }
                
            }

            Write($"   Solution:  {range}");
            WriteLine();
        }
        public static void Task7()
        {
            WriteLine(" Task 7");
            WriteLine();

            WriteLine("Numb 1:");
            int a = Convert.ToInt32(ReadLine());
            WriteLine();

            WriteLine("Numb 2:");
            int b = Convert.ToInt32(ReadLine());
            WriteLine();

            int range = 0;

            if (a <= b)
            {
                while (a <= b)
                {
                    if (a % 5 == 0)
                    {
                        range++;
                    }
                    a += 1;
                }
            }
            else
            {
                while (b <= a)
                {
                    if (b % 5 == 0)
                    {
                        range++;
                    }
                    b += 1;
                }
            }

            Write($"   Solution:  {range}");
            WriteLine();
        }
        public static void Task8()
        {
            WriteLine(" Task 8");
            WriteLine();

            WriteLine("Numb 1:");
            int a = Convert.ToInt32(ReadLine());
            WriteLine();

            WriteLine("Numb 2:");
            int b = Convert.ToInt32(ReadLine());
            WriteLine();

            int range = 0;

            if (a <= b)
            {
                while (a <= b)
                {
                    if (a % 3 == 0 && a % 4 == 0 && a < 0)
                    {
                        range += a;
                    }
                    a += 1;
                }
            }
            else
            {
                while (b <= a)
                {
                    if (b % 3 == 0 && b % 4 == 0 && b < 0)
                    {
                        range += b;
                    }
                    b += 1;
                }
            }

            Write($"   Solution:  {range}");
            WriteLine();
        }
        public static void Test()
        {
            int lim = 10;
            int cont = 0;
            while (cont < lim)
            {
                if (cont < 5)
                {
                    Write("*");
                }
                else
                {
                    Write("-");
                }
                cont+=1;
            }

            WriteLine();

            int lim1 = 50;
            int cont1 = 1;
            do
            {
                if(cont1 < 25)
                {
                    Write('*');
                }
                else
                {
                    Write("-");
                }
                cont1 += 1;
            } while (cont1 < lim1);
            WriteLine();
        }
    }
}
