using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSerg.OOP.HW_Factory
{
    enum BallColor
    {
        Purple,
        Yellow,
        Black,
        Turquoise
    }
    class Ball
    {
        public int Diametr;
        public BallColor color;
        
        public Ball(int diametr, BallColor color)
        {
            Diametr = diametr;
            this.color = color;
        }
    }
}

