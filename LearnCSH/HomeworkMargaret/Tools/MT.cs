using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMargaret.Tools
{
    class MT
    {
        public static double Sum(double v1, double v2)
        {
            return v1 + v2;
        }

        public static double Subst(double v1, double v2)
        {
            return v1 - v2;
        }

        public static double Mult(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double Divish(double v1, double v2)
        {
            if (v2 == 0)
            {
                CT.ErrorMsg("wrong operation");
                return 0;
            }

            return v1 / v2;
        }

        public static double Pow(double v, double n)
        {
           return Math.Pow(v, n);
        }

        public static double Sqrt(double v)
        {
            return Math.Sqrt(v);
        }

        public static double Abs(double v)
        {
            return Math.Abs(v);
        }
    }
}
