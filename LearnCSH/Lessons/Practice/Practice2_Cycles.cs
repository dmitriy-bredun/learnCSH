using static System.Console;

namespace Lessons.Practice
{
    class Practice2_Cycles
    {
        public static void Start()
        {

        }

        public static void Task1()
        {

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