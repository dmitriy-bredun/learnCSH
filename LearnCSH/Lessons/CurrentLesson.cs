using System;
using System.Threading;
using Lessons.Tools;

using static System.Console;
using static System.Convert;

namespace Lessons
{
    class CurrentLesson
    {
        public static void GoGoGo()
        {
            // ForDemo();
            // StringArrayDemo();
            // ArrayWithRandomValuesDemo();

            // ��� �������� ������ � ������ ����� ?
            int[] arr = new int[5];
            arr[0] = 3;
            arr[1] = 7;
            arr[2] = 4;
            arr[3] = 2;
            arr[4] = 1;

            int[] arr2 = new int[5];

            Task1(arr);

            WTF("alalal");
        }

        public static void ForDemo()
        {
            Write("������� �����: ");
            int limit = ToInt32(ReadLine());

            int number = 0;
            for (int counter = 1; counter <= limit && counter < 100; counter += 3, number++)
            {
                WriteLine($"Counter = {counter}  ");
                WriteLine($"Number = {number}  ");

                WriteLine();
                WriteLine();
            }
        } 

        public static void StringArrayDemo()
        {
            // ������� ������ ��� �������� ������ �����
            string[] text = new string[4];

            // ���������� � ���� ��������
            text[0] = "Happy";
            text[1] = "New";
            text[2] = "Year,";
            text[3] = "Cowboys!";

            // �� ��� �� ����� ������� �� ������� ����� �������� � ��������� ��� � ��������� ���������� (���� ��� �����)
            string str = text[0]; // � ���������� string str ��������� "Happy"

            //�������� ������ �������
            int arraySize = text.Length;

            // ������� ������� ������� 
            for (int indx = 0; indx < arraySize; indx++)
            {
                Write($"{text[indx]}  ");
            }

            WriteLine();
            WriteLine();

            for (int indx = 0; indx < text.Length; ++indx)
            {
                WriteLine($"� ������ � �������� [{indx}] ��������: text[{indx}] = {text[indx]}");
            }
        }

        // ������ ��� ������� ������ � ��������� ��� ���������� �������
        public static void ArrayWithRandomValuesDemo()
        {
            // ������� ������ ��� �������� ����� �����
            int[] arrayWithRandomValues = new int[15];

            // ������� ���������� ���������� �����
            Random generator = new Random();

            // �������������� ������ ���������� ������� � ��������� �� min �� max
            const int MIN = -10;
            const int MAX = 10;
            for (int indx = 0; indx < arrayWithRandomValues.Length; indx++)
            {
                arrayWithRandomValues[indx] = generator.Next(MIN, MAX);
            }

            // ������� ������� ������� 
            for (int indx = 0; indx < arrayWithRandomValues.Length; ++indx)
            {
                WriteLine($"� ������ � �������� [{indx}] ��������: arrayWithRandomValues[{indx}] = {arrayWithRandomValues[indx]}");
            }
        }

        public static void Task1(int[] numbers1)
        {
            for (int indx = 0; indx < numbers1.Length; indx++)
            {
                WriteLine($"numbers[{indx}] = {numbers1[indx]}");
            }
        }

        public static void WTF(string text)
        {
            WriteLine($"��� �� ����� �� ��� �������? {text}");
        }
    }
}