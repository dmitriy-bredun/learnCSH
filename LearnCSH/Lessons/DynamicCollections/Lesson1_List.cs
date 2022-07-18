using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace Lessons.DynamicCollections
{
    class Lesson1_List
    {
        public static void Start()
        {
        
            List<int> values = new List<int>();

            // Добавить элемент
            values.Add(4);
            values.Add(5);
            values.Add(6);
            values.Add(7);
            
            // Добавить в список элементы из другой коллекции
            int[] integers = new int[5] { 9, 8, 9, 8, 10 };
            values.AddRange(integers);


            // Добавляет значение (value) в выбранную позицию (index)
            // Insert(index, value)
            values.Insert(0, 100500);


            // Пройтись по списку и вывести в консоль
            foreach (int value in values)
            {
                WriteLine($"value = {value}");
            }

            // Получить значение по определенному индексу
            int someValue = values[3];

            // Полный размер всей коллекции (для скольких ячеек выделилась память)
            WriteLine(values.Capacity);

            // Сколько реально в списке хранится элементов
            WriteLine(values.Count);

            // Удалить элемент
            values.Remove(7);

            // Удалить элемент по конкретному индексу
            values.RemoveAt(7);

            // Удалить все элементы списка
            values.Clear();

            // Проверить содержит ли список указанный элемент
            // (возвращает true, если элемент item есть в списке)
            bool result = values.Contains(100500);

            // Возвращает индекст конкретного элемента, если он есть
            // В противном случае возвращает -1
            int indx = values.IndexOf(100500);
        }
    }
}
