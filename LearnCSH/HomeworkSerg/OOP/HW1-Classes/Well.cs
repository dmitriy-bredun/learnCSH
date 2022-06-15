using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSerg.OOP.HW1_Classes
{
    class Well
    {
        public int Number;
        public string Type;
        public int Diameter;
        public int Depth;
        public int NumbOfRings;
        public int Volume;
        public string Equipment;


        public Well (int number, string type, int diameter, int depth, int numbRings, int volume, string equipment)
        {
            Number = number;
            Type = type;
            Diameter = diameter;
            Depth = depth;
            NumbOfRings = numbRings;
            Volume = volume;
            Equipment = equipment;
        }
    }
}
