using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.ConsoleColor;
using static System.Convert;

namespace HomeworkDmitriy.IndependentWork
{
    internal class IndWork1_BasicComplex
    {
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        public static void Start()
        {

            do
            {
                WriteLine("   ///   Ввод и вывод числовых данных   ///   ");
                WriteLine();

                WriteLine("     (if + операции)");
                WriteLine("         1 - Дано натуральное число. Определить:");
                WriteLine("               а) является ли оно четным,");
                WriteLine("               б) оканчивается ли оно цифрой 7");
                WriteLine("         2 - Дано двузначное число. Определить:");
                WriteLine("               а) является ли сумма его цифр двузначным числом,");
                WriteLine("               б) больше ли числа а сумма его цифр");
                WriteLine("     (switch)");
                WriteLine("         3 - Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, …, 7) " +
                    "                   выводит на экран его название (Monday, Tuesday, …, Sanday)");
                WriteLine("     (for)");
                WriteLine("         4 - Найти: ");
                WriteLine("               а) сумму всех целых чисел от 100 до 500");
                WriteLine("               б) сумму всех целых чисел от a до 500 (значение a вводится с клавиатуры; a<500)");
                WriteLine("               в) сумму всех целых чисел от –10 до b (значение b вводится с клавиатуры; b>–10)");
                WriteLine("               г) сумму всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a)");

                WriteLine("         0 - Выход");
                WriteLine();

                Write("         ");
                int Choice = ToInt32(ReadLine());
                CT.Space2();
                switch (Choice)
                {
                    case 1: Task1(); break;
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;

                    default:
                        Write("Ты не то жмакнул :О");
                        WriteLine();
                        WriteLine();
                        break;
                }
            } while (true);
        }

        public static void Task1()
        {
            WriteLine("1");
            Write("Введите натуральное число: ");
            int number = ToInt32(ReadLine());
            CT.Space();

            if (number % 2 == 0)
                WriteLine("а) Число чётное");
            else
                WriteLine("а) Число не чётное");

            if (number % 10 == 7)
                WriteLine("б) Число оканчивается цифрой 7");
            else
                WriteLine("б) Число не оканчивается цифрой 7");

            CT.Space2();
        }
        public static void Task2()
        {
            WriteLine("2");
            Write("Введите двузначное число: ");
            Write("         ");
            int number = ToInt32(ReadLine());
            CT.Space();



            CT.Space2();
        }
        public static void Task3()
        {
            WriteLine("3");
            Write("Введите номер дня недели: ");
            int Choice = ToInt32(ReadLine());
            CT.Space2();
            switch (Choice)
            {
                case 1: WriteLine($"{Day.Monday}"); break;
                case 2: WriteLine($"{Day.Tuesday}"); break;
                case 3: WriteLine($"{Day.Wednesday}"); break;
                case 4: WriteLine($"{Day.Thursday}"); break;
                case 5: WriteLine($"{Day.Friday}"); break;
                case 6: WriteLine($"{Day.Saturday}"); break;
                case 7: WriteLine($"{Day.Sunday}"); break;
            }
            CT.Space2();
        }
        public static void Task4()
        {
            WriteLine("4");
            WriteLine("а)");
            int i;
            int result = 0;


            for (i = 100; i <= 500; i++)
            {
                result += i;
            }
            WriteLine($"сумма всех целых чисел от 100 до 500 равна: {result}");
            CT.Space();

            WriteLine("б)");
            int result2 = 0;
            Write($"Введите число меньше 500:");
            int choise = ToInt32(ReadLine());

            for (; choise <= 500; choise++)
            {
                result2 += choise;
            }
            WriteLine($"сумма всех целых чисел от {choise} до 500 равна: {result2}");
            CT.Space();

            WriteLine("в)");
            int a = 0;
            int result3 = 0;
            Write($"Введите число больше -10:");
            int choise2 = ToInt32(ReadLine());

            for (a = -10; a <= choise2; a++)
            {
                result3 += a;
            }
            WriteLine($"сумма всех целых чисел от -10 до {choise2} равна: {result3}");
            CT.Space2();

            WriteLine("г)");
            int result4 = 0;

            Write($"Введите первое число:");
            int x = ToInt32(ReadLine());
            Write($"Введите второе число:");
            int y = ToInt32(ReadLine());

            for (; x <= y; x++)
            {
                result4 += x;
            }
            WriteLine($"сумма всех целых чисел от {x} до {y} равна: {result4}");
            CT.Space2();

        }
    }
}
