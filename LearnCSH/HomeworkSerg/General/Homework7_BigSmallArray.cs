using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using HomeworkSerg.Tools;



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

            Write("Ente size of big array:    ");
            int sizeBigArray = Convert.ToInt32(ReadLine());
            int[] bigArray = AT.CreateSimplArray(sizeBigArray);

            AT.FillingRandom(bigArray, 1, 100);

            int[] smallArray = null;

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
                        Write("Ente size of small array:    ");
                        int sizeSmallArray = Convert.ToInt32(ReadLine());
                        smallArray = AT.CreateSimplArray(sizeSmallArray);
                        AT.FillingManuall(smallArray);
                        break;

                    case 3:
                        AT.ShowArray(smallArray);
                        break;

                    case 4:
                        Сhapter4(bigArray, smallArray);
                        break;

                    case 0:
                        WriteLine("Сладких снов, котик ;)");
                        break;

                    default:
                        WriteLine("     You missed. Try again ;)");
                        break;
                }
            } while (userChoice != 0);
        }

        public static void Сhapter4(int[] bigArray, int[] smallArray)
        {
            //for (int indx = 0; indx < bigArray.Length; indx++)
            //{
            //    if (bigArray[indx] == smallArray[0])
            //    {
            //        int newInt = indx++;
            //        WriteLine($"{newInt}");
            //    }
            //    if (bigArray[indx] == smallArray[1])
            //    {
            //        int newInt = indx++;
            //        WriteLine($"{newInt}");
            //    }
            //    if (bigArray[indx] == smallArray[2])
            //    {
            //        int newInt = indx++;
            //        WriteLine($"{newInt}");
            //    }
            //}

            //                 [5]
            // big:   5 4 3 2 5 7 8 5   size: 8
            // small: 7 8 5             size: 3     8 - 3 = limitIndx = 5

            bool result = false;
            int limitIndx = bigArray.Length - smallArray.Length;

            for (int bigIndx = 0; bigIndx <= limitIndx; bigIndx++)
            {
                int smallIndx = 0;

                if (bigArray[bigIndx] == smallArray[smallIndx])
                {
                    result = true;
                    while (smallIndx < smallArray.Length)
                    {
                        if (smallArray[smallIndx] != bigArray[bigIndx + smallIndx])
                        {
                            result = false;
                            break;
                        }

                        smallIndx++;
                    }
                }

                if (result == true)
                {
                    // если мы нашли кусочек, который совпал, дальнейшее сравнение уже не нужно
                    // выходим из цикла for
                    break;
                }
            }


            WriteLine($"Найдено ли совпадение? Ответ - {result}");
        }
    }
}
