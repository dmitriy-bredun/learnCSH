using System;
using static System.Console;

using HomeworkSerg.General;
using HomeworkSerg.Tools;
using HomeworkSerg.OOP.HW1_Classes;
using HomeworkSerg.OOP.HW_Factory;
using HomeworkSerg.Test;

namespace HomeworkSerg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework1_Variables.Start();
            //Homework2_Convert.Start();
            //Homework3_Operation.Start();
            //Homework4_VDV.Start();
            //Homework5_Cycles.Start();
            //Homework6_1_SimpleArrays.Start();
            //Homework6_2_BigSmallArray.Start();
            //Homework_R_Arrays.Start();
            //HW1_Classes.Start();
            //HW_Factory.Start();
            //Test.Start();

            
            int[] arr = new int[] { 8, 11, 5, 3, 8, 9, 11, 4 };

            int resCount = 0;  //кол-во индексов итог
            int resStartIndx = 0;  //начальный индекс
            int resEndIndex = 0;  //конечный индекс

            int count = 1;  //колличество елементов
            int startI = 0;  //временный начальный индекс
            int endI = 0;  //временный конечный индекс

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    count++;
                    endI = i;
                }
                else
                {
                    if (count > resCount)
                    {
                        resCount = count;
                        resEndIndex = endI;
                        resStartIndx = startI;
                    }
                    count = 1;
                    startI = i;
                    endI = i;
                }
            }
            WriteLine($"result = {resCount}; first element = {resStartIndx}; last element = {resEndIndex}");

            //int startI = 0; //временный начальный индекс
            //int endI = 0; //временный конечный индекс

            //int count = 1; //колличество елементов
            //int box = 0; //временное хранение числа внутри ячейки

            //int resultIndexStart = 0;
            //int resultIndexEnd = 0;

            //int resultCount = 0;

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (box < arr[i])
            //    {
            //        count++; endI = i; box = arr[i];
            //    }
            //    else
            //    {
            //        if (count > resultCount)
            //        {
            //            resultCount = count;
            //            resultIndexStart = startI;
            //            resultIndexEnd = endI;
            //        }
            //        count = 1;
            //        startI = i;
            //        endI = i;
            //        box = arr[i];
            //    }
            //}
            //Console.WriteLine($"StartIndx{resultIndexStart} EndIndx{resultIndexEnd} Result={resultCount}");
        }

    }
}
