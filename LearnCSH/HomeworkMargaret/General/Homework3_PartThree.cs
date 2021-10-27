using System;
using System.Collections.Generic;
using System.Text;
using HomeworkMargaret.Tools;

namespace HomeworkMargaret.General
{
    class Homework3_PartThree
    {
        public static void Start()
        {
            int usersChoice;
            do
            {
                CT.Print("HOMEWORK III, PART III");
                CT.Print("1 ---- Picture 1");
                CT.Print("2 ---- Picture 2");
                CT.Print("0 ---- exit");

                usersChoice = CT.EnterInt("your choice");

                switch (usersChoice)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 0:
                        break;

                    default:
                        CT.Print("seems that you're stupid");
                        break;
                }
            } while (usersChoice != 0);

            CT.Space();
        }

        public static void Task1()
        {

            //for (int num1 = 0; num1 < 10; num1++)
            //{
            //   if (num1 < 5)
            //   {
            //     CT.Print("0", false);
            //   }
            //   else
            //   {
            //      CT.Print("1", false);
            //     }
            // }
            int sizeL = 4;
            int sizeC = 8;

            for (int l = 0; l < sizeL; l++)
            {
                for (int c = 0; c < sizeC; c++)
                {
                    if (l == c)
                    {
                        CT.Print("*", false);
                    }
                    else if (l + c == 7)
                    {
                        CT.Print("*", false);
                    }
                    else if (c > l && c < sizeC - (l + 1))
                    {
                        CT.Print(" ", false);
                    }
                    else
                    {
                        CT.Print("|", false);
                    }
                }
                System.Console.WriteLine();
            }

            CT.Space();
        }

        public static void Task2()
        {
            int line = CT.EnterInt("number of lines");
            int columns = CT.EnterInt("number of columns");

            

        }
    }
}
