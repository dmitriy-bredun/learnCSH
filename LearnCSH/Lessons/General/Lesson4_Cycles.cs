using static System.Console;

namespace Lessons.General
{
    class Lesson4_Cycles
    {
        public static void Start()
        {
            WhileDemo();
            DoWhileDemo();
        }

        /// <summary>
        /// Цикл While сначала проверяет условие,
        /// и если оно - true,  выполняет итерацию.
        /// </summary>
        public static void WhileDemo()
        {
            int counter = 0;
            int sum = 0;

            // Считает сумму всех чисел от 1 до 10
            while (counter < 10)
            {
                sum = sum + counter;
                WriteLine($"Counter = {counter}");
                counter = counter + 1;
            }

            WriteLine("The end!");
        }

        /// <summary>
        /// Цикл Do-While сначала выполняет итерацию,
        /// а потом уже проверяет условие.
        /// </summary>
        public static void DoWhileDemo()
        {
            int counter = 0;

            do
            {
                WriteLine($"Counter = {counter}");
                counter += 1; //counter = counter + 1;

            } while (counter < 10);
        }
    }
}
