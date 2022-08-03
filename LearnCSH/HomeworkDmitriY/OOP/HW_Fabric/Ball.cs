using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDmitriy.OOP.HW_Fabric
{
    enum Colors
    {
        Red,
        Green,
        Blue,
    }
    class Ball
    {
        public int diametr;
        public Colors ballcollor;

        public Ball (int diametr, Colors ballcollor)
        {
            this.diametr = diametr;
            this.ballcollor = ballcollor;
        }
    }

    //Ball b1 = new Ball(5, Colors.Red);
}
