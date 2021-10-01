using System;

using static System.Console;

namespace Lessons.Practice
{
    class Practice3_Tasks
    {
        public static void Start()
        {
            // Конвертер температур: Фаренгейт <-----> Цельсий
            // Converter();  

            // Посчитать количество цифр в числе
            // Task2();

            // Рисунок в консоли
            // Task3();
        }

        //************ TASK 1 ****************
        //
        public static void Converter()
        {
            int userChoice;

            do
            {
                WriteLine("Converter Menu:");
                WriteLine("1 --- convert C -> F");
                WriteLine("2 --- convert F -> C");
                WriteLine("0 --- exit");
                Write("---> ");

                userChoice = Convert.ToInt32(ReadLine());
                switch (userChoice)
                {
                    case 1:
                        ConvertCToF();
                        break;
                    case 2:
                        ConvertFToC();
                        break;
                    case 0:
                        WriteLine("Good Bye...");
                        break;
                    default:
                        WriteLine("Incorrect input...");
                        break;
                }

                WriteLine();
                WriteLine();
            } while (userChoice != 0);
        }
        public static void ConvertCToF()
        {
            Write("Please, enter the C value: ");
            int valueInC = Convert.ToInt32(ReadLine());

            int valueInF = (valueInC * 9 / 5) + 32;

            WriteLine($"C: {valueInC} ---> F: {valueInF}");
        }
        public static void ConvertFToC()
        {
            Write("Please, enter the F value: ");
            int valueInF = Convert.ToInt32(ReadLine());

            int valueInC = (valueInF - 32) * 5 / 9;

            WriteLine($"F: {valueInF} ---> C: {valueInC}");
        }


        //************* TASK 2 **************
        public static void Task2()
        {
            Write("Enter the value: ");
            int value = Convert.ToInt32(ReadLine());

            int countOfDigits = 0;
            while (value > 0)
            {
                countOfDigits++;
                value = value / 10;
            }

            WriteLine($"Количество цифр в числе = {countOfDigits}");
        }



        //************* TASK 3 ***************
        public static void Task3()
        {
            Write("Введите высоту (линии): ");
            int sizeLines = Convert.ToInt32(ReadLine());

            Write("Введите ширину (колонки): ");
            int sizeColumns = Convert.ToInt32(ReadLine());

            int counterI = 0;
            while (counterI < sizeLines)
            {
                int counterJ = 0;
                while (counterJ < sizeColumns)
                {
                    if ((counterI == 1) && (counterJ > 1 && counterJ < sizeColumns - 2))
                    {
                        Write("1 ");
                    }
                    else if ((counterI > 1 && counterI < sizeLines - 2) && (counterJ == sizeColumns - 2))
                    {
                        Write("1 ");
                    }
                    else if ((counterI == sizeLines - 2) && (counterJ > 1 && counterJ < sizeColumns - 2))
                    {
                        Write("1 ");
                    }
                    else if ((counterI > 1 && counterI < sizeLines - 2) && (counterJ == 1))
                    {
                        Write("1 ");
                    }
                    else
                    {
                        Write("0 ");
                    }

                    counterJ++;
                }

                WriteLine();
                counterI++;
            }

            WriteLine();
        }
    }
}
