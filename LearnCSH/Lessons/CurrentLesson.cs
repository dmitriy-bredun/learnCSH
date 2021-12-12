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
            // ForDemo();
            // StringArrayDemo();
            // ArrayWithRandomValuesDemo();
        }

        public static void ForDemo()
        {
            Write("Введите лимит: ");
            int limit = ToInt32(ReadLine());

            int number = 0;
            for (int counter = 1; counter <= limit && counter < 100; counter += 3, number++)
            {
                WriteLine($"Counter = {counter}  ");
                WriteLine($"Number = {number}  ");

                WriteLine();
                WriteLine();
            }
        } 

        public static void StringArrayDemo()
        {
            // создаем массив для хранения набора строк
            string[] text = new string[4];

            // записываем в него значения
            text[0] = "Happy";
            text[1] = "New";
            text[2] = "Year,";
            text[3] = "Cowboys!";

            // мы так же можем считать из массива любое значение и сохранить его в отдельную переменную (если это нужно)
            string str = text[0]; // в переменную string str запишется "Happy"

            //получаем размер массива
            int arraySize = text.Length;

            // выводим значния массива 
            for (int indx = 0; indx < arraySize; indx++)
            {
                Write($"{text[indx]}  ");
            }

            WriteLine();
            WriteLine();

            for (int indx = 0; indx < text.Length; ++indx)
            {
                WriteLine($"В ячейке с индексом [{indx}] хранится: text[{indx}] = {text[indx]}");
            }
        }

        // пример как создать массив и заполнить его случайными числами
        public static void ArrayWithRandomValuesDemo()
        {
            // создаем массив для хранения целых чисел
            int[] arrayWithRandomValues = new int[15];

            // создаем переменную генератора чисел
            Random generator = new Random();

            // инициализируем массив случайными числами в диапазоне от min до max
            const int MIN = -10;
            const int MAX = 10;
            for (int indx = 0; indx < arrayWithRandomValues.Length; indx++)
            {
                arrayWithRandomValues[indx] = generator.Next(MIN, MAX);
            }

            // выводим значния массива 
            for (int indx = 0; indx < arrayWithRandomValues.Length; ++indx)
            {
                WriteLine($"В ячейке с индексом [{indx}] хранится: arrayWithRandomValues[{indx}] = {arrayWithRandomValues[indx]}");
            }
        }
    }
}