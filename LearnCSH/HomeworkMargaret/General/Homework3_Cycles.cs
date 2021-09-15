using System;
using static System.Console;

namespace HomeworkMargaret.General
{
    class Homework3_Cycles
    {
        public static void Start()
        {

            int usersChoice;

            do
            {
                WriteLine("Homework 3 START");
                WriteLine("TASK 1 ----- 13 symbols (1)");
                WriteLine("TASK 2 ----- 13 symbols (2)");
                WriteLine("TASK 3 ----- 13 symbols (3)");
                WriteLine("TASK 4 ----- 13 symblos (4)");
                WriteLine("TASK 5 ----- multiples of 5");
                WriteLine("TASK 6 ----- negative multilples of 2");
                WriteLine("TASK 7 ----- sum of multiples of 3");
                WriteLine("TASK 8 ----- drawing");
                WriteLine("to exit ---- press 0");
                Write("----> ");

                usersChoice = Convert.ToInt32(ReadLine());

                switch (usersChoice)
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

                    case 0:
                        break;

                    default:
                        WriteLine("you're stupid");
                        break;
                }
            } while (usersChoice != 0);
        }
        public static void Task1()
        {
            int count = 1;            
            while (count < 14)
            {
                if (count % 2 == 0)
                {
                    Write("0");
                }
                else
                {
                    Write("1");
                }
                
                count++;
            }
            WriteLine();
            WriteLine();
        }
            
        public static void Task2()
        {
            int count = 1;
            while (count < 14)
            {
                if (count % 3 == 0)
                {
                    Write("1");
                }
                else
                {
                    Write("0");
                }

                count++;
            }
            WriteLine();
            WriteLine();
        }

        public static void Task3()
        {
            int count = 1;
            while (count < 14)
            {
                if (count % 2 == 0 && count <= 6)
                {
                    Write("1");
                }
                else
                {
                    Write("0");
                }

                count++;
            }
            WriteLine();
            WriteLine();
        }

        public static void Task4()
        {
            int count = 1;
            while (count < 14)
            {
                if (count % 2 == 0 && count > 7)
                {
                    Write("1");
                }
                else
                {
                    Write("0");
                }

                count++;
            }
            WriteLine();
            WriteLine();
        }

        public static void Task5()
        {
            WriteLine("Write first number: ");
            int a = Convert.ToInt32(ReadLine());
            WriteLine("Write second number: ");
            int b = Convert.ToInt32(ReadLine());

            int count = a;
            int result = 0;
            int operation;

            if (a < b)
            {
                operation = 1;
            }
            else
            {
                operation = -1;
            }

            do
            {
                if (count % 5 == 0)
                {
                    result = result + 1;
                }
                count = count + operation;

            } while (count != b);
            WriteLine($"Found {result} numbers");
            WriteLine();
            WriteLine();
        }

        public static void Task6()
        {
            WriteLine("Write first number: ");
            int a = Convert.ToInt32(ReadLine());
            WriteLine("Write second number: ");
            int b = Convert.ToInt32(ReadLine());

            int count = a;
            int result = 0;
            int operation;

            if (a < b)
            {
                operation = 1;
            }
            else
            {
                operation = -1;
            }

            do
            {
                if (count % 2 == 0 && count < 0)
                {
                    result = result + 1;
                }
                count = count + operation;

            } while (count != b);
            WriteLine($"Found {result} numbers");
            WriteLine();
            WriteLine();
        }

        public static void Task7()
        {
            WriteLine("Write first number: ");
            int a = Convert.ToInt32(ReadLine());
            WriteLine("Write second number: ");
            int b = Convert.ToInt32(ReadLine());

            int count = a;
            int result = 0;
            int operation;

            if (a < b)
            {
                operation = 1;
            }
            else
            {
                operation = -1;
            }

            do
            {
                if (count % 3 == 0 && count > 0)
                {
                    result = result + count;
                }
                count = count + operation;

            } while (count != b);
            WriteLine($"Sum of multiples = {result}");
            WriteLine();
            WriteLine();
        }

        public static void Task8()
        {
            int counterLine = 1;
            int counterRow = 1;
            while (counterLine <= 5)
            {
                counterRow = 1;
               while (counterRow <= 5)
               {                  
                    if (counterLine == 5)
                    {
                        Write("1");
                    }                    
                    else if (counterRow != 1 && counterRow !=5 && counterLine != 1)
                    {
                        Write("1");
                    }         
                    else  
                    {
                        Write("0");
                    }      
                    counterRow++;                    
                }
                
                WriteLine();                                
                counterLine++;
            }
            WriteLine();
            WriteLine();
        }
    }
}

