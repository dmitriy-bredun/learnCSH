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
            WriteLine("Введите размеры карты");

            int xLimMap = ToInt32(ReadLine());
            int yLimMap = ToInt32(ReadLine());

            WriteLine($"Карта создана с заданными размерами {xLimMap} на {yLimMap}");

            WriteLine("Введите координаты пацанов");

            int xChel = ToInt32(ReadLine());
            int yChel = ToInt32(ReadLine());

            WriteLine($"Пацаны выброшены по координатам {xChel} на {yChel}");

            WriteLine("Выполняем сравнение координат");

            if (xChel < xLimMap && xChel > 0 && yChel < yLimMap && yChel > 0)
            {
                WriteLine("Пацаны на месте");

                int xUp = xChel;
                int yUp = yChel + 1;

                if (yUp < yLimMap)
                {
                    WriteLine($"Патроны на месте по {xUp} {yUp}");
                }
                int xDow = xChel;
                int yDow = yChel - 1;

                if (yDow > 0)
                {
                    WriteLine($"Патроны на месте по {xDow} {yDow}");
                }

                int xLef = xChel - 1;
                int yLef = yChel;

                if (yLef > 0)
                {
                    WriteLine($"Патроны на месте по {xLef} {yLef}");
                }

                int xRt = xChel + 1;
                int yRt = yChel;

                if (yRt < yLimMap)
                {
                    WriteLine($"Патроны на месте по {xRt} {yRt}");
                }
            }
            else
            {
                WriteLine("Пацаны в жопе");
            }
        }
    }
}
