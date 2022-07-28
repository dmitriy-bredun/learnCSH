using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.General.Practice
{
    enum MathOperations
    {
        Add,
        Minus,
        Multiply,
        Devide
    }


    class MathTool
    {
        public static double MakeSomeOperation(double x, double y, MathOperations o)
        {
            double result = 0;
            switch (o)
            {
                case MathOperations.Add:
                    result = x + y;
                    break;

                case MathOperations.Minus:
                    result = x - y;
                    break;

                case MathOperations.Multiply:
                    result = x * y;
                    break;

                case MathOperations.Devide:
                    if (y == 0)
                    {
                        Console.WriteLine("Ты шо, дибил нама? Делить на ноль ниИзяЯ!");
                    }
                    else
                    {
                        result = x / y;
                    }
                    break;

                default:
                    break;
            }

            return result;
        }
    }



    class Practice6_Enums
    {
        public static void Start()
        {
            double result1 = MathTool.MakeSomeOperation(123.123,    345.345,   MathOperations.Add);
            double result2 = MathTool.MakeSomeOperation(3.24,       8,         MathOperations.Devide);
            double result3 = MathTool.MakeSomeOperation(5,          5,         MathOperations.Minus);
        }
    }
}
