using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMargaret.OOP.HW_Fabric
{
    enum BallColor
    {
        Red = 1,
        Blue = 2,
        Black = 3
    }
    class Ball
    {
        private int Diameter;
        private int Color;

        public Ball(int diameter, int color)
        {
            Diameter = diameter;
            Color = color;
        }
        
    }
}
