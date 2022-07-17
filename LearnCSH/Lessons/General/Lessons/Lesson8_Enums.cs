using System;
using static System.Console;

namespace Lessons.General.Lessons
{
    public enum Colors
    {
        Blue,
        Red,
        Green
    }

    [Flags]
    enum BorderSides
    {
        None = 0,
        Left = 2,
        Right = 4,
        Top = 8,
        Bottom = 16,
        TopBottom = Top | Bottom,
        LeftRight = Left | Right,
        All = TopBottom | LeftRight
    }

    class Box
    {
        public int Width;
        public int Height;
        public Colors Color;
        public BorderSides Sides;

        public Box(int width, int height, Colors color, BorderSides sides)
        {
            Width = width;
            Height = height;
            Color = color;
            Sides = sides;
        }
    }

    class Lesson8_Enums
    {
        public static void Start()
        {
            int boxWidth = 5;
            int boxHeight = 10;
            BorderSides sides = BorderSides.Top | BorderSides.Left;
            
            Box box = new Box(boxWidth, boxHeight, Colors.Blue, sides);

            Paiting(box);
        }

        // Красит нужные стороны коробки в нужный цвет
        public static void Paiting(Box box)
        {
            BorderSides sides = box.Sides;
            WriteLine($"Нужно покрасить: {sides} стороны.");

            if (sides.HasFlag(BorderSides.Left))
            {
                WriteLine($"Paint Left side to {box.Color} color");
            }

            if (sides.HasFlag(BorderSides.Right))
            {
                WriteLine($"Paint Right side to {box.Color} color");
            }

            if (sides.HasFlag(BorderSides.Top))
            {
                WriteLine($"Paint Top side to {box.Color} color");
            }

            if (sides.HasFlag(BorderSides.Bottom))
            {
                WriteLine($"Paint Bottom side to {box.Color} color");
            }
        }
    }
}
