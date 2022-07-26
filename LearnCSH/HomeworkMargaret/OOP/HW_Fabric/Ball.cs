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
        private int _diameter;
        private BallColor _color;

        public int Diameter
        {
            get { return _diameter; }
        }

        public BallColor Color 
        {  
            get { return _color; }
        }


        public Ball(int diameter, BallColor color)
        {
            _diameter = diameter;
            _color = color;
        }
    }
}
