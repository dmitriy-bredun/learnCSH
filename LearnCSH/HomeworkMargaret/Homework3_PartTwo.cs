using System;
using static System.Console;

namespace HomeworkMargaret
{
    class Homework3_PartTwo
    {
        public static void Start()
        {
            int usersChoice;
            do
            {
                WriteLine("Homework 3. Part II. START");
                WriteLine("TASK 1 ----- quantity of even numbers");
                WriteLine("TASK 2 ----- fisrt three multiples of 3");
                WriteLine("TASK 3 ----- a heart");
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

                    case 0:
                        break;

                    default:
                        WriteLine("pls, don't be stupid");
                        break;
                }
            }while (usersChoice != 0);
            WriteLine();
            WriteLine();
        }

        public static void Task1()
        {
            Write("pls, enter your number: ");
            
            int number = Convert.ToInt32(ReadLine());
            int counter = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0 && digit != 0)
                {
                    counter++; 
                }
                number = number / 10;                   
            }     
            
            WriteLine("Result = " + counter);
            
            WriteLine();
            WriteLine();
        }
        public static void Task2()
        {
            Write("pls, write first number: ");
            int num1 = Convert.ToInt32(ReadLine());

            Write("pls, write second number: ");
            int num2 = Convert.ToInt32(ReadLine());
                        
            int counter = 0;
            while (counter != 3)
            {                
                if (num1 % 3 == 0)
                {               
                   WriteLine($"First three multiples are: " + num1);                                       
                   counter++;                
                }
                num1++;
            } 

            WriteLine();
            WriteLine();
        }

        public static void Task3()
        {
            int sizeLines = 11;
            int sizeColumns = 11;

            int counterL = 0;
            while (counterL < sizeLines)
            {
                int counterC = 0;
                while (counterC < sizeColumns)
                { 
                    if ((counterC == 1) && (counterL > 1) && (counterL <= 5) || (counterC == 9) && (counterL > 1) && (counterL <= 5))
                    {
                        Write("*");
                    }    
                    else if ((counterL > 0) && (counterL <= 2) && (counterC > 1) && (counterC <=2) || (counterL > 0) && (counterL <=2) && (counterC < 9) && (counterC >=8))
                    {
                        Write("*");
                    }
                    else if ((counterL >= 2 && counterL <=4) && (counterL + 1 == counterC || counterL + counterC == 9))
                    {
                        Write("*");
                    }
                    else if ( (counterL >=6 && counterL <=9) && (counterL - 4 == counterC || counterL + counterC == 14))
                    {
                        Write("*");
                    }
                    else if ((counterL >= 6 && counterL <= 9) && (counterL - 4 <
                        counterC && counterL + counterC < 14))
                    {
                        Write(" ");
                    }
                    else
                    {
                        Write("0");
                    }

                    
                    counterC++;                      
                }
                
               counterL++;
               WriteLine();
            }

            WriteLine();
            WriteLine();
        }
    }
}
