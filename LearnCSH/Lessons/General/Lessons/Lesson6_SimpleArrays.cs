﻿using System;

using static System.Console;

namespace Lessons.General.Lessons
{
    class Lesson6_SimpleArrays
    {
        public  static void Start()
        {
            /*
             *  ДОПОЛНИТЕЛЬНЫЕ ПРИМЕРЫ КОДА, РАБОТАЮЩЕГО С МАССИВОМ, 
             *  МОЖЕТЕ ГЛЯНУТЬ В КЛАССЕ ---> Practice4_SimpleArrays
             */

            // Обьевление ссылки и инициализация массива
            // При создании массива - все элементы = 0 (стандартному для int значению)
            int[] array = new int[10];


            // ------- Доступ к ячейкам массива осуществляется через [индекс]
            // нумерация ячеек начинается с 0. Для того, что бы
            // записать значение в 3-ю ячейку, нужно указать в 
            // качестве индекса [2]
            array[0] = 33;
            array[2] = 8;


            // ------- Размер массива
            // можно получить с помощью его свойства Length
            int size = array.Length;


            // ------- Вывод массива в консоль
            // удобно организовать через любой цикл, к примеру - for
            for (int indx = 0; indx < array.Length; indx++)
            {
                WriteLine($"array[{indx}] = {array[indx]}");
            }

            // --- ПРИМЕРЫ ИНИЦИАЛИЗАЦИИ МАССИВА ЧЕРЕЗ КОД
            int[] a = new int[5] { 2, 2, 5, 1, 5 };
            int[] b = { 1, 2, 3, 4, 5, 5, 5 };
        }
    }
}
