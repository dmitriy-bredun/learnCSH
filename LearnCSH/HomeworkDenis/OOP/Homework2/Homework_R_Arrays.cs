using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static HomeworkDenis.Tools.CH;

namespace HomeworkDenis.OOP.Homework2
{
    class Homework_R_Arrays
    {
        public static void Start()
        {
            int choice;
            var arr = new int[30];
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        FillWithRandomNumbers(arr);
                        break;
                    case 2:
                        ShowArray(arr);
                        break;
                    case 3:
                        ChangeOneElement(arr);
                        break;
                    case 4:
                        double average = FindAverage(arr);
                        Write($"Среднее арифметическое всех элементов, которые хранятся в ячейках с чётным индексом: {average}");
                        Print2Space();
                        break;
                    case 5:
                        int limit = EnterInt("Введите лимит суммы элементов, которые хранятся в ячейках с нечётным индексом: ");
                        bool result = CheckForLimit(arr, limit);
                        if (result == true)
                            Write("Сумма элементов, которые хранятся в ячейках с нечетным индексом, превышает заданный лимит.");
                        else
                            Write("Сумма элементов, которые хранятся в ячейках с нечетным индексом, НЕ превышает заданный лимит.");
                        Print2Space();
                        break;
                    case 6:
                        Write($"Сумма значений в массиве между мин. и макс. элементами: {CalculateTheSumOfElementsBetweenMinAndMax(arr)}");
                        Print2Space();
                        break;
                    case 7:
                        SortAnArrayInAscendingOrder(arr);
                        Write("Сортировка массива успешно прошла!");
                        Print2Space();
                        break;
                    case 8:
                        WriteLine("Выбор настоящего мужика! ;)");
                        return;
                    default:
                        ErrorMsg("Baka! Выбери что-то одно из списка! ;N");
                        Print2Space();
                        break;
                }
            } while (choice != 8);
        }
        private static int Menu()
        {
            int choice = 0;
            WriteLine("Меню: ");
            WriteLine("1) Заполнить массив случайными числами");
            WriteLine("2) Вывести значения массива в консоль");
            WriteLine("3) Изменить какой-нибудь элемент массива");
            WriteLine("4) Найти среднее арифм. всех элементов, которые хранятся в ячейках с чётным индексом");
            WriteLine("5) Проверить, не превышает ли сумма элементов, которые находятся в ячейках с нечётным индексом, заданный лимит");
            WriteLine("6) Посчитать сумму всех значений, которые находятся между минимальными и максимальными элементами");
            WriteLine("7) Отсортировать массив в порядке возростания");
            WriteLine("8) Пойти мочить русню :3 ");
            choice = EnterInt("Что бы вы хотели сделать?(думаю, выбор очевиден): ");
            WriteLine();
            return choice;
        }
        private static void FillWithRandomNumbers(int [] arr)
        {
            var random = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = random.Next(0, 101);
            Write("Массив заполнен случайными числами.");
            Print2Space();
        }
        private static void ShowArray(int[] arr)
        {
            WriteLine("Ваш массив:");
            for (int i = 0; i < arr.Length; i++)
                WriteLine(arr[i]);
            WriteLine();
        }
        private static void ChangeOneElement(int[] arr)
        {
            bool checker = false;
            int elementindex;
            do
            {
                elementindex = EnterInt("Элемент под каким номером (1-30) вы хотите изменить?: ");
                if ((elementindex - 1) < 0 || (elementindex - 1) > 29)
                    checker = false;
                else
                    checker = true;
                switch (checker)
                {
                    case true:
                        WriteLine();
                        break;

                    case false:
                        WriteLine();
                        Write("Элемента под таким номером нету в массиве! Введите верное значение!");
                        Print2Space();
                        break;
                }
            } while (checker != true);
            int elementnumber = EnterInt("Какое бы значение вы хотели бы установить данному элементу: ");
            WriteLine();
            arr[elementindex - 1] = elementnumber;
            WriteLine($"Значение элемента №{elementindex} успешно изменено на {elementnumber}!");
            WriteLine();
        }
        private static double FindAverage(int [] arr)
        {
            double counter = 0, 
                sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += arr[i];
                    counter++;
                }
            }
            return sum / counter;
        }
        private static bool CheckForLimit(int [] arr, int limit)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                    sum += arr[i];
            }
            return sum > limit;
        }
        private static int CalculateTheSumOfElementsBetweenMinAndMax(int [] arr)
        {
            int sum = 0;
            SortAnArrayInAscendingOrder(arr);
            for (int i = 1; i < arr.Length - 1; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static void SortAnArrayInAscendingOrder(int [] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    }
                }                                      
                right--;
                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                    }
                }
                left++;
            }
        }
    }
}
