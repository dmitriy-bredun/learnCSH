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
            double frequency = ToDouble(ReadLine());

            CT.Print("Введите нужное количество ядер: ");
            int cores = ToInt32(ReadLine());

            CT.Print("Введите размер кеша L3: ");
            int cache = ToInt32(ReadLine());

            Processor processor = new Processor(companyN, frequency, cores, cache);

            ShowProcessor(processor);
        }
        public static void ShowProcessor(Processor processorInfo)
        {
            WriteLine();
            WriteLine($"- - - - - Выбранный процессор- - - - - - -");
            WriteLine($"Модель процессора: {processorInfo.companyName}:");
            WriteLine($"Частота: {processorInfo.frequency}");
            WriteLine($"Количество ядер: {processorInfo.countOfCores}");
            WriteLine($"Кеш L3: {processorInfo.cache}");
            WriteLine($"- - - - - - - - - - - - - - - - - - - - - -");
            WriteLine($"Ищем выбранный процессор в базе данных магазина...");
            WriteLine();
        }
    }
}