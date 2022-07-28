using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMargaret.Tools
{
    enum ArithmeticOperation
    {
        Add,
        Substract,
        Multiply,
        Divide
    }
    class Calculator
    {
        public static double ArithOperation(int numb, int numb2, ArithmeticOperation operation)
        {
            int sum = 0;
            switch (operation)
            {
                case ArithmeticOperation.Add:
                    sum = numb + numb2;
                    break;

                case ArithmeticOperation.Substract:
                    sum = numb - numb2;
                    break;

                case ArithmeticOperation.Multiply:
                    sum = numb * numb2;
                    break;

                case ArithmeticOperation.Divide:
                    if (numb2 == 0)
                    {
                        CT.ErrorMsg("wrong operation");
                        return 0;
                    }

                    sum = numb / numb2;
                    break;

                default:
                    break;
            }
            return sum;
        }
    }
}
