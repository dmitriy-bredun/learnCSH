using System;
using System.Threading;

using static System.Console;

namespace Lessons.General.Practice
{
    class Practice2_DoubleCycles
    {
        public static void Start()
        {
            int userChoice;
            do
            {
                Menu();
                userChoice = Convert.ToInt32(ReadLine());
                WriteLine();

                switch (userChoice)
                {
                    case 1:
                        IndexesDemo();
                        break;

                    case 2:
                        GameDemo();
                        break;

                    case 0:
                        WriteLine();
                        WriteLine("Пс... Слышал.. Говорят автор этого проекта большой любитель сладенького ;)");
                        Write("Спасибо за ваше внимание. Завершаю демонстрацию");
                        Ending();
                        break;

                    default:
                        WriteLine("Извините, ввод не распознан. Постарайтесь выбрать один из предложенных вариантов!");
                        break;
                }

                Write("Для продолжения - нажми Enter...");
                ReadLine();
                Console.Clear();

            } while (userChoice != 0);
        }

        private static void IndexesDemo()
        {
            int i = 1;
            while (i <= 5)
            {
                Write("\t");
                int j = 1;
                while (j <= 5)
                {
                    Write($"(i = {i}, j = {j}) \t");
                    Thread.Sleep(100);
                    j++;
                }
                WriteLine();
                WriteLine();
                i++;
            }
        }

        private static void GameDemo()
        {
            WriteLine("Введите размер карты: ");
            Write("Введите ширину (x): ");
            int sizeX = Convert.ToInt32(ReadLine());
            Write("Введите высоту (y): ");
            int sizeY = Convert.ToInt32(ReadLine());

            WriteLine();
            WriteLine("Введите координаты ВДВшников: ");
            Write("X: ");
            int coordX = Convert.ToInt32(ReadLine());
            Write("Y: ");
            int coordY = Convert.ToInt32(ReadLine());

            int counterY = sizeY;
            while (counterY >= 1)
            {
                int counterX = 1;
                Write("\t");
                while (counterX <= sizeX)
                {
                    if (counterX == coordX && counterY == coordY)
                    {
                        Write("ВДВ ");
                    }
                    else if (counterX == coordX + 1 && counterY == coordY + 1)
                    {
                        Write("Кот ");
                    }
                    else
                    {
                        Write(" -  ");
                    }

                    Thread.Sleep(25);
                    counterX++;
                }
                WriteLine();
                counterY--;
            }

            WriteLine();
        }

        private static void Menu()
        {
            WriteLine("\t Добро пожаловать на практическое по двойным циклам!");
            WriteLine();
            WriteLine("Какое демо хотите запустить?");
            WriteLine("1 --- Демка по i, j индексам, демонстрирующая как изменяются координаты");
            WriteLine("2 --- Демка с отрисовкой игровой карты и вдвшниками ()");
            WriteLine("     (Будьте бдительны, в этой демонстрации координаты по Y идут в обратном направлении!)");
            WriteLine("0 --- Закончить демонстрацию");
            Write("---> ");
        }
        private static void Ending()
        {
            int counter = 0;
            while (counter < 20)
            {
                Write('.');
                Thread.Sleep(400);
                counter++;
            }

            WriteLine();
        }
    }
}
