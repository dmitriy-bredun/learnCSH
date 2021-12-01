using System;

namespace Lessons.General
{
    class Lesson1_Variables
    {
        public static void Start()
        {
            //////////////////////////////////////////////////////////////////////////1
            /// Существующие примитивные типы:

            
            Console.WriteLine($"sbyteVal -> MIN = {sbyte.MinValue},  MAX = {sbyte.MaxValue}");
            Console.WriteLine($"short    -> MIN = {short.MinValue}, MAX = {short.MaxValue}");
            Console.WriteLine($"int      -> MIN = {int.MinValue}, MAX = {int.MaxValue}");
            Console.WriteLine($"long     -> MIN = {long.MinValue}, MAX = {long.MaxValue}");
            Console.WriteLine();

            Console.WriteLine($"float     -> MIN = {float.MinValue}, MAX = {float.MaxValue}");
            Console.WriteLine($"double    -> MIN = {double.MinValue}, MAX = {double.MaxValue}");
            Console.WriteLine($"decimal   -> MIN = {decimal.MinValue}, MAX = {decimal.MaxValue}");
            Console.WriteLine();

            Console.WriteLine($"Char      -> MIN = {Convert.ToInt32(char.MinValue)}, MAX = {Convert.ToInt32(char.MaxValue)}");
        }
    }
}
