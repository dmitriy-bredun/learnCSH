using System;
using System.Threading;
using Lessons.Tools;

using static System.Console;
using static System.Convert;

namespace Lessons
{
    class CurrentLesson
    {
        public static void GoGoGo()
        {
            // Cycles

            // WhileDemo();
            // DoWhileDemo();
            // MenuDemo();

            CryBitch();

            //int value1 = 3;
            //int value2 = 6;

            ////--------------------------------------------------
            //if (value1 % 2 == 0)
            //{
            //    WriteLine($"Число {value1} - кратное 2-м");
            //}
            //else
            //{
            //    WriteLine($"Число {value1} - не четное");

            //}
            ////--------------------------------------------------
            //if (value2 % 2 == 0)
            //{
            //    WriteLine($"Число {value2} - кратное 2-м");
            //}
            //else
            //{
            //    WriteLine($"Число {value2} - не четное");
            //}
            ////--------------------------------------------------
            //if (value2 % 3 == 0)
            //{
            //    WriteLine($"Число {value2} - кратное 3-м");
            //}
            ////--------------------------------------------------
        }

        public static void WhileDemo()
        {
            int limit = 10;
            int counter = 0;

            while (counter < limit)
            {
                if (counter < 5)
                {
                    Write("*");
                }
                else
                {
                    Write("-");
                }

                counter += 1;
                // counter = counter + 1;
                // counter = counter * 3; counter *= 3;
            }

            WriteLine("Finish");
        }
        public static void DoWhileDemo()
        {
            int limit = 10;
            int counter = 100;

            do
            {
                if (counter < 5)
                {
                    Write("*");
                }
                else
                {
                    Write("-");
                }

                counter += 1;
            } while (counter < limit);
            WriteLine("Finish");
        }
        public static void MenuDemo()
        {
            int userChoice = 0;

            do
            {
                WriteLine("Menu");
                WriteLine("1 --- First");
                WriteLine("2 --- Second");
                WriteLine("3 --- .....");
                WriteLine("0 --- Exit");
                userChoice = ToInt32(ReadLine());

                switch (userChoice)
                {
                    case 1:
                        WriteLine("1 task");
                        break;
                    case 2:
                        WriteLine("2 task");
                        break;
                    case 3:
                        WriteLine("3 task");
                        break;
                    case 0:
                        WriteLine("Exit...");
                        break;
                    default:
                        WriteLine("WTF?! O_o?");
                        break;
                }

                WriteLine();
                WriteLine();

            } while (userChoice != 0);
        }

        public static void CryBitch()
        {
            // TASK 1
            // 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 
            int lim = 15;
            int count1 = 1;
            while (count1 <= lim)
            {
                Write($"{count1} ");
                count1 += 1;
            }

            WriteLine("Finish");
            WriteLine();


            // TASK 2
            // 2) 0 1 * 1 0 * 0 1 * 1 0 * 0 1 * 1 0 * 0 1 
            int count2 = 1;
            while(count2 <= 20)
            {
                if (count2 % 3 == 0)
                {
                    Write("* ");
                }
                else if (count2 % 2 == 0)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                count2 += 1;
            }

            WriteLine("Finish");
            WriteLine();


            // TASK 3
            // 3) 0 0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 1 1 1
            WriteLine();
            WriteLine();

            int count3 = 0;

            while (count3 < 20)
            {
                if (count3 < 10)
                {
                    Write("0 ");
                }
                else
                {
                    Write("1 ");
                }
                count3 += 1;
            }
        }
    }
}