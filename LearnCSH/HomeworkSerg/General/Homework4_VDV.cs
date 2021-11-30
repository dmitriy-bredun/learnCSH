using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.General
{
    class Homework4_VDV
    {
        public static void Start()
        {
            WriteLine();
            WriteLine("И так Господа ! Наши задачи на сегодня:");
            WriteLine("- определить границы локацию дисантирования;");
            WriteLine("- определить точку выброси наших парней;");
            WriteLine("- проверить точки выброски доп. оборудования (4точки).");
            WriteLine();

            WriteLine("Определяем границы локации десантирования:");

            WriteLine("С запада на восток (ось Х):");
            int xLoс = Convert.ToInt32(ReadLine());

            WriteLine("С юга на север (ось Y):");
            int yLoс = Convert.ToInt32(ReadLine());
            WriteLine();

            WriteLine($"Границы локации десантирования {xLoс} и {yLoс}");
            WriteLine();

            WriteLine("Определяем точку выброси наших парней:");

            WriteLine("С запада на восток (ось Х):");
            int xVdV = Convert.ToInt32(ReadLine());

            WriteLine("С юга на север (ось Y):");
            int yVdV = Convert.ToInt32(ReadLine());
            WriteLine();

            WriteLine($"Пацаны выброшены по координатам {xVdV} и {yVdV}");
            WriteLine();
            WriteLine("Выполняем расчеты:");
            WriteLine();

            if (xLoс > xVdV && xVdV > 0 && yLoс > yVdV && yVdV > 0)
            {
                WriteLine("Парни сброшены успешно !");
                WriteLine();

                WriteLine("Определяем точки выброски доп. оборудования:");

                WriteLine("- Патроны чЕк");
                int xAmmo = xVdV + 0;
                int yAmmo = yVdV + 1;
                WriteLine($"Патроны выброшены по координатам {xAmmo} и {yAmmo}");

                if (xAmmo < xLoс && xAmmo > 0 && yAmmo < yLoс && yAmmo > 0)
                {
                    WriteLine("Патроны получены. Люблю запах напалма по утрам !");
                }
                else
                {
                    WriteLine("Патронов нет. Ищем палки по длинее, а камни по тяжелее господа...");
                }
                WriteLine();

                WriteLine("- Еда чЕк");
                int xFood = xVdV + 1;
                int yFood = yVdV + 0;
                WriteLine($"Еда выброшены по координатам {xFood} и {yFood}");

                if (xFood < xLoс && xFood > 0 && yFood < yLoс && yFood > 0)
                {
                    WriteLine("Еда получена. Вкусна!");
                }
                else
                {
                    WriteLine("Еды нет. Не зря взяли новобранца...");
                }
                WriteLine();

                WriteLine("- Транспорт чЕк");
                int xTr = xVdV + 0;
                int yTr = yVdV - 1;
                WriteLine($"Транспорт выброшены по координатам {xTr} и {yTr}");

                if (xTr < xLoс && xTr > 0 && yTr < yLoс && yTr > 0)
                {
                    WriteLine("Транспорт получен. Запрягай лошадок!");
                }
                else
                {
                    WriteLine("Транспорта нет. Топаем...");
                }
                WriteLine();

                WriteLine("- Боевые подруги чЕк");
                int xBitch = xVdV - 1;
                int yBitch = yVdV + 0;
                WriteLine($"Боевые подруги выброшены по координатам {xBitch} и {yBitch}");

                if (xBitch < xLoс && xBitch > 0 && yBitch < yLoс && yBitch > 0)
                {
                    WriteLine("Боевые подруги получен. Хе Хе:) Уууу ля ля!");
                }
                else
                {
                    WriteLine("Боевых подруг нет. Готовьте кулачки, ну и Не зря взяли новобранца...");
                }
            }
            else
            {
                WriteLine("Парни ... Press F to pay respects...");
            }
        }
    }
}
