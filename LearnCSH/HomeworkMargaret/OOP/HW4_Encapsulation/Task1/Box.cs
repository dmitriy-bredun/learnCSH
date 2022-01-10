using System;
using System.Collections.Generic;
using System.Text;

using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW4_Encapsulation.Task1
{
    class Box
    {
        private double length;
        private double height;
        private double width;
        private double weight;

        public double Volume
        {
            get
            {
                return length * height * width;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Print("weight cannot be less than 0");
                }
            }
        }
        public Box(double length, double height, double width, double weight)
        {
            this.length = length;
            this.height = height;
            this.width = width;
            this.weight = weight;
        }
        public void Show()
        {
            Print("Box:");
            Print(length, "length");
            Print(height, "height");
            Print(width, "width");
            Space();
        }
    }
    
}
