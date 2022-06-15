using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.OOP.HW1_Classes
{
    internal class HW1_Class1
    {
        public static void Start()
        {
            CT.Print("Введите название модели процессора: ");
            string companyN = (ReadLine());

            CT.Print("Введите частоту процессора: ");
            int frequency = ToInt32(ReadLine());
            
            CT.Print("Введите нужное количество ядер: ");
            int cores = ToInt32(ReadLine());
            
            CT.Print("Введите размер кеша L3: ");
            int cache = ToInt32(ReadLine());

            Processor processor1 = new Processor(companyN, frequency, cores, cache);

            ShowProcessor(Processor);

        }
        public static void ShowProcessor(Processor showProcessor)
        {
            WriteLine();
            WriteLine($"    Well Number: {showProcessor.companyN}:");
            WriteLine();
            WriteLine($"    Well Type: {showProcessor.frequency}");
            WriteLine();
            WriteLine($"    Well Diameter: {showProcessor.cores}");
            WriteLine();
            WriteLine($"    Well Depth: {showProcessor.cache}");
            WriteLine();
        }
    }
