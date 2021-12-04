using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.General
{
    internal class Homework4_VDV
    {
        internal static void Start()
        {
            WriteLine("Введите размеры карты:");

            Write("xLimMap = ");
            int xLimMap = ToInt32(ReadLine());

            Write("yLimMap = ");
            int yLimMap = ToInt32(ReadLine());

            WriteLine($"Карта создана с заданными размерами {xLimMap} на {yLimMap}");
            WriteLine();


            WriteLine("Введите координаты пацанов:");

            Write("xChel = ");
            int xChel = ToInt32(ReadLine());

            Write("yChel = ");
            int yChel = ToInt32(ReadLine());
            WriteLine($"Пацаны выброшены по координатам {xChel} на {yChel}");
            WriteLine();


            Write("Выполняем сравнение координат: ");
            if (xChel < xLimMap && xChel > 0 && yChel < yLimMap && yChel > 0)
            {
                WriteLine("Пацаны на месте");
                WriteLine();

                // Точка сверху
                int xUp = xChel;
                int yUp = yChel + 1;
                if (yUp < yLimMap)
                {
                    WriteLine($"(сверху) Патроны на месте по {xUp} {yUp}");
                    WriteLine();
                }

                // Точка снизу
                int xDow = xChel;
                int yDow = yChel - 1;
                if (yDow > 0)
                {
                    WriteLine($"(снизу) Патроны на месте по {xDow} {yDow}");
                    WriteLine();
                }

                // Точка слева
                int xLef = xChel - 1;
                int yLef = yChel;
                if (yLef > 0)
                {
                    WriteLine($"(слева) Патроны на месте по {xLef} {yLef}");
                    WriteLine();
                }

                // Точка справа
                int xRt = xChel + 1;
                int yRt = yChel;
                if (yRt < yLimMap)
                {
                    WriteLine($"(справа) Патроны на месте по {xRt} {yRt}");
                    WriteLine();
                }
            }
            else
            {
                WriteLine("Пацаны в жопе");
            }
        }
    }
}
