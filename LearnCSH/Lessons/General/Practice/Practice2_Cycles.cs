using static System.Console;

namespace Lessons.General.Practice
{
    class Practice2_Cycles
    {
        public static void Start()
        {
            WriteLine("TASK 1");
            Task1();

            WriteLine();
            WriteLine();

            WriteLine("TASK 2");
            Task2();

            WriteLine();
            WriteLine();
        }

        public static void Task1()
        {
            int counter = 0;
            while (counter < 10)
            {
                if (counter < 5)
                {
                    Write("0 ");
                }
                else
                {
                    Write("1 ");
                }

                counter += 1;
            }
        }

        public static void Task2()
        {
            int counter = 0;

            while (counter < 10)
            {
                if (counter % 4 == 0) // вернет true, если число кратно четырем
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }

                counter++;
            }
        }
    }
}