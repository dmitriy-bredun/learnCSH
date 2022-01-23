﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.Tools
{
    internal class MT
    {
        public static double VolumeСylinder(double R,  double H)
        {
            Write("V = ");
            return Math.Pow(R, 2) * 3.14 * H;
        }
        public static double AreaСylinder(double R, double H)
        {
            Write("P = ");
            return 2 * 3.14 * R * H;
        }
        public static double WaterСonsumption(double D, double W)
        {
            Write("Q = ");
            return (3.14 * Math.Pow(D, 2) / 4) * W;
        }
        public static double WaterSpeed(double D, double Q)
        {
            Write("W = ");
            return (4 * Q) / (3.14 * Math.Pow(D, 2));
        }
    }
}
