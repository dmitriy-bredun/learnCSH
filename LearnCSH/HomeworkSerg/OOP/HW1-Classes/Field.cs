using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSerg.OOP.HW1_Classes
{
    class Field
    {
        public int Number;
        public string Crop;
        public int Length;
        public int Width;
        public int Area;
        public string Watering;

        public Field(int number1, string crop, int length, int width, int area, string watering)
        {
            Number = number1;
            Crop = crop;
            Length = length;
            Width = width;
            Area = area;
            Watering = watering;
        }
    }
}
