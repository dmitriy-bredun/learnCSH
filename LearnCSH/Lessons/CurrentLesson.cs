using System;
using System.Threading;
using Lessons.Tools;

using static System.Console;
using static System.Convert;

namespace Lessons
{
    class CurrentLesson
    {
        public static void Start()
        {
            // string txt = "Happy New Year 2222 :)";

            // string message = "�������, ���� ��� �������, ����� ������ ������������ � ������.";


            // Min = minVal;
            // int minVal = 0;
            // WriteLine($"min = {minVal}");
            // ����� �������� �� �����
            // Print("min", minVal);

            // ������ � ���������� ��������� ����
            char x = 'a';
            ChangeValue(x);
            Print("x", x);

            // ������ � ���������� ���������� ����
            int[] arr = new int[10];
            int[] arr222 = new int[10];

            ChangeArrayValue(arr222);
            ChangeArrayValue(arr);


            int kkk = GetRandomValue();
            WriteLine($"kkk = {kkk}");


            ////////////////////////////////////////////////////////
            /// ������ ����������� �������� �� ������

            Write("������� ������ ����������: ");
            int newVal1 = Convert.ToInt32(ReadLine());

            int newVal2 = EnterInt("������� ������ ����������");
        }

        public static void Demo( /*��, ��� �������� �� ���� � �����*/ )
        {

        }
        public static void Print(string msg, char value)
        {
            WriteLine($"{msg} = {value}");
            WriteLine();
        }
        public static void ChangeValue(char val)
        {
            val = 'b';
        }
        public static void ChangeArrayValue(int[] array)
        {
            array[0] = 100500;
        }
        public static int GetRandomValue()
        {
            Random rand = new Random();
            int newValue = rand.Next(0, 100);
            return newValue;
        }
        public static int EnterInt(string txt)
        {
            Write($"{txt}: ");
            int val = Convert.ToInt32(ReadLine());
            return val;
        }
    }
}