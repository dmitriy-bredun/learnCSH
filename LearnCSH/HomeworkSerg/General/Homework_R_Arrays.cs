using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using HomeworkSerg.Tools;

namespace HomeworkSerg.General
{
    internal class Homework_R_Arrays
    {
        public static void Start()
        {
            WriteLine();
            Write(" Укажите размер масива:");
            int size = Convert.ToInt32(ReadLine());
            WriteLine();

            int[] array = new int[size];

            int userChoice = 0;
            do
            {
                WriteLine("     1)  Заполнить массив случайными числами");
                WriteLine("     2)  Вывести значения массива в консоль");
                WriteLine("     3)  Изменить какой-нибудь элемент массива");
                WriteLine("     4)  Написать статический метод, который будет считатьсреднее арифм");
                WriteLine("     5)  Написать статический метод, который будет проверять");
                WriteLine("     6)  Написать статический метод, который будет считать сумму");
                WriteLine("     7)  Написать статический метод, который будет сортировать массив");
                WriteLine();
                WriteLine("     Your choice  --->   ");
                userChoice = Convert.ToInt32(ReadLine());
                WriteLine();

                switch (userChoice)
                {
                    case 1:
                        WriteLine("     1)  Заполняем массив случайными числами");
                        WriteLine();
                        int volmin = Convert.ToInt32(ReadLine());
                        int volmax = Convert.ToInt32(ReadLine());
                        AT.FillingRandom(array, volmin, volmax);
                        WriteLine();
                        break;

                    case 2:
                        WriteLine("     2)  Выводим значения массива в консоль");
                        WriteLine();
                        AT.ShowArray(array);
                        WriteLine();
                        break;
                    
                    case 3:
                        WriteLine("     3)  Изменить какой-нибудь элемент массива");
                        WriteLine();

                        Write("     Введите номер ячейки которую хотите изменить:  ");
                        int box = Convert.ToInt32(ReadLine());
                        WriteLine();

                        Write("     Новое значение в ячейке:    ");
                        int change = Convert.ToInt32(ReadLine());
                        WriteLine();

                        array[box] = change;

                        WriteLine($"Ячейка [{box}] изменена на: {change}");
                        WriteLine();
                        break;

                    default:
                        WriteLine("    Неверный ввод");
                        break;
                }
                WriteLine();
            } while (userChoice != 0);
        }
        
    }
}
