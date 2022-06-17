using System;

using static System.Console;

namespace Lessons.OOP.Lesson2_Methods
{
    class Lesson2_Methods
    {
        public static void Start()
        {
            Random rand = new Random();

            int h = rand.Next(10, 100);
            int w = rand.Next(10, 100);
            int l = rand.Next(10, 100);

            Box box1 = new Box(h, w, l);
            box1.ShowBoxInfo();
            int area = box1.GetSquare();
            WriteLine($"Square of box = {area}");


            Box box2 = new Box(3, 5, 8);
            box2.ShowBoxInfo();
            WriteLine($"Square of box = {box2.GetSquare()}");
        }
    }
}
