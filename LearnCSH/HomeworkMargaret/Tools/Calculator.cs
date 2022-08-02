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
            int mathOperation = operation switch
            {
                ArithmeticOperation.Add => numb + numb2,
                ArithmeticOperation.Substract => numb - numb2,
                ArithmeticOperation.Multiply => numb * numb2,
                ArithmeticOperation.Divide => numb / numb2,
                _ => 0,
            };

            return mathOperation;
        }
    }
}
