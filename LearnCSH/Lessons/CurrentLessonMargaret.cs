using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

using Lessons.Tools;

namespace Lessons
{
    enum Colors
    {
        Green,
        Blue,
        Red,
        UNKNOWN
    }

    class Box
    {
        public int x;
        public int y;
        public int z;
        public Colors color;

        public Box(int x, int y, int z, Colors color)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.color = color;
        }

        public void ShowBox()
        {
            WriteLine();
            WriteLine($"Box show");
            WriteLine($"x = \t{x}");
            WriteLine($"y = \t{y}");
            WriteLine($"z = \t{z}");
            WriteLine($"color = \t{color}");
            WriteLine();
        }
    }


    class CurrentLessonMargaret
    {
        static Box[] boxes = new Box[10];

        public static void Start()
        {
            DynamicMenu menu = new DynamicMenu();

            int userChoice;
            do
            {
                menu.AddMenuItem("Добавить коробку", AddNewBox);
                menu.AddMenuItem("Отобразить все коробки", ShowAllBoxes);
                menu.AddMenuItem("Отобразить крассные коробки", ShowRedBoxes);

                userChoice = menu.CallMenu();

            } while (userChoice != 0);
        }

        public static void AddNewBox()
        {
            int x = CT.EnterInt("Введите размер по Х: ");
            int y = CT.EnterInt("Введите размер по Y: ");
            int z = CT.EnterInt("Введите размер по Z: ");

            Write("Выберите цвет: (1 зеленый, 2 синий, 3 красный): ");
            int colorChoice = Convert.ToInt32(ReadLine());

            Colors color = colorChoice switch
            {
                1 => Colors.Green,
                2 => Colors.Blue,
                3 => Colors.Red,
                _ => Colors.UNKNOWN
            }; // под кодом - пример этого свитча, описанный классическим способом

            for (int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i] == null)
                {
                    boxes[i] = new Box(x, y, z, color); ;
                    break;
                }
            }
        }

        public static void ShowAllBoxes()
        {
            foreach (var item in boxes)
            {
                if (item != null)
                {
                    item.ShowBox();
                }
            }
        }

        public static void ShowRedBoxes()
        {
            foreach (var item in boxes)
            {
                if (item == null)
                {
                    continue;
                }

                if (item.color == Colors.Red)
                {
                    item.ShowBox();
                }
            }
        }
    }
}

// пример свитча, описанный классическим способом
// switch (colorChoice)
// {
//     case 1:
//         color = Colors.Green;
//         break;
//     case 2:
//         color = Colors.Blue;
//         break;
//     default:
//         color = Colors.UNKNOWN;
//         break;
//         ...
// }

// ??? public static int Counter;
// ??? Default constructor
// ??? constructors chain