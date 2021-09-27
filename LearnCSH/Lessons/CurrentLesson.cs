using System;
using static System.Console;

namespace Lessons
{
    class CurrentLesson
    {
        public static void GoGoGo()
        {
            int a = 15;
            int b = 15;

            int res = MethodSum(a, b);
            res = MethodSum(a, b, true);

        }

        public static int MethodSum(int value1, int value2, bool mustBeShowed = false)
        {
            int result = value1 + value2;
            if (mustBeShowed)
            {
                WriteLine($"Result = {result}");
            }

            return result;
        }
    }
}