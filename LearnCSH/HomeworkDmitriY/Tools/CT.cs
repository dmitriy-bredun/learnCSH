using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.Tools
{
    public static class CT
    {
        public static void Space()
        {
            WriteLine();
        }

        public static void Space2()
        {
            WriteLine();
            WriteLine();
        }

        public static void Space4()
        {
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
        }

        public static void Space8()
        {
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine();
        }

        public static void Print(string text)
        {
            Write(text);
        }

        public static void PrintL(string text)
        {
            WriteLine(text);
        }

        public static void EnterInt(string text, int value)
        {
            WriteLine($"{text} = {value}");
        }

        public static int Int(string text)
        {
            Write($"{text}: ");
            int val = ToInt32(ReadLine());
            return val;
        }

        public static int Menu(params string[] masiv)
        {
            WriteLine("   ///   Выбери Таску   ///   ");
            WriteLine();
            for (int i = 0; i < masiv.Length; i++)
            {
                WriteLine($"         {i + 1} - {masiv[i]}");
            }
            WriteLine("         0 - Жмакни что б выйти");
            WriteLine();
            Write("         ");
            return ToInt32(ReadLine());
        }

        public static int RandomVal()
        {
            Random random = new Random();

            Write($"Введи минимальное значение: ");
            int min = ToInt32(ReadLine());

            Write($"Введи максимальное значение: ");
            int max = ToInt32(ReadLine());

            int val = random.Next(min, max);
            return val;
        }

        public static int[] CreateArray(int size)
        {
            if (size <= 0)
            {
                WriteLine("Масив не может быть равен 0.");
                return null;
            }
            int[] newMasiv = new int[size];
            return newMasiv;
        }

        //public static int[] CreateArray(int[] nums)
        //{
        //    CT.PrintL("Создадим новый массив");
        //    CT.Space();

        //    CT.Print("Введите размер массива: ");
        //    int size = ToInt32(ReadLine());

        //    if (size <= 0)
        //    {
        //        WriteLine("Масив не может быть равен 0.");
        //        return null;
        //    }
        //    int[] nums = new int[size];
        //    return nums;
        //}

        public static void MasivManual(int[] kkk)
        {
            WriteLine("Введите значения массива: ");
            for (int i = 0; i < kkk.Length; i++)
            {
                Write($"[{i}] = ");
                kkk[i] = ToInt32(ReadLine());
            }
            WriteLine();
            WriteLine("Масив заполнен!");
        }
        public static void MasivRandom(int[] masiv)
        {
            Random random = new Random();

            Write("Введи минимальное значение: ");
            int min = ToInt32(ReadLine());

            Write("Введи максимальное значение: ");
            int max = ToInt32(ReadLine());

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                masiv[indx] = random.Next(min, max);
            }
            WriteLine($"Массив рандомизирован :О");
        }
    }
}
