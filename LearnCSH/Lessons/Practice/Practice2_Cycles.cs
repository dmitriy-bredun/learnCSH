using static System.Console;

namespace Lessons.Practice
{
    class Practice2_Cycles
    {
        public static void Start()
        {
            Task1();
            Task2();
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
                    WriteLine("1");
                }
                else
                {
                    WriteLine("0");
                }

                counter++;
            }
        }
    }
}