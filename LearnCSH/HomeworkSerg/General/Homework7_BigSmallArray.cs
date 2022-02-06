using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using HomeworkSerg.Tools;
using HomeworkSerg.ToolsArray;
using HomeworkSerg.ToolsConsole;



namespace HomeworkSerg.General
{
    internal class Homework7_BigSmallArray
    {
        public static void Start()
        {
            WriteLine();
            Write("     Welcome to:  Homework7 BigSmallArray");
            WriteLine();
            
            int userChoice = 0;

            Write("Ente size big array:    ");
            int size = Convert.ToInt32(ReadLine());
            int[]bigArray = AT.CreateSimplArray(size);
            
            AT.FillingRandom(bigArray, 1, 100);

            int[] smallArray;

            do
            {
                userChoice = CT.Menu(
                    "Вывести большой масив",
                    "Создать мал мас",
                    "Вывести мал масив",
                    "Выполнить проверку");

                
                
                switch (userChoice)
                {
                    case 1:
                        AT.ShowArray(bigArray);
                        break;

                    case 2:
                        smallArray = AT.CreateSimplArray(size);
                        AT.FillingManuall(smallArray);
                        AT.ShowArray(smallArray);
                        break;

                    case 3:
                        //AT.ShowArray(smallArray);
                        break;
               
                    case 5:
                        Сhapter5();
                        break;

                    default:
                        WriteLine("     You missed. Try again ;)");
                        break;
                }
            }while(userChoice != 0) ;
        }
        public static void Сhapter3()
        {

        }
      
        public static void Сhapter5()
        {
            WriteLine();
            Write("Ente size Big array:    ");
            int size = Convert.ToInt32(ReadLine());
            int[] bigArray = new int[size];
            WriteLine();

            AT.FillingRandom(bigArray, 1, 100);
            WriteLine();

            Write("Manuall filling Small array    ");

            int[] smallArray = new int[3];
            WriteLine();

            AT.FillingManuall(smallArray);
            WriteLine();

            for (int indx = 0; indx < bigArray.Length; indx++)
            {
                if (bigArray[indx] == smallArray[0])
                {
                    int newInt = indx++;
                    WriteLine($"{newInt}");
                }
                if (bigArray[indx] == smallArray[1])
                {
                    int newInt = indx++;
                    WriteLine($"{newInt}");
                }
                if (bigArray[indx] == smallArray[2])
                {
                    int newInt = indx++;
                    WriteLine($"{newInt}");
                }
            }
        }
    }
}
