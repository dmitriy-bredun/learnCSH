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
        public BorderSides Sides;

        public Box(int width, int height, BorderSides sides)
        {
            Width = width;
            Height = height;
            Sides = sides;
        }

        public override string ToString()
        {
            return $"Class info: \n" +
                $"Width = {Width}, \n" +
                $"Height = {Height},\n" +
                $"Sides = {Sides}";
        }
    }

    class Lesson8_Enums
    {
        public static void Start()
        {
            Colors col = Colors.Blue;
            Colors col2 = Colors.Red;
            Colors test = col | col2;
           
            BorderSides sides = BorderSides.Top | BorderSides.Left;

            sides = sides ^ BorderSides.Bottom;

            Box box = new Box(5, 5, sides);

            WriteLine(box);
        }

        public static void Paiting(Box box)
        {
            BorderSides sides = box.Sides;

            WriteLine($"Sides = {sides}");

            if (sides.HasFlag(BorderSides.Left))
            {
                WriteLine("Paint Left side");
            }

            if (sides.HasFlag(BorderSides.Right))
            {
                WriteLine("Paint Right side");
            }

            if (sides.HasFlag(BorderSides.Top))
            {
                WriteLine("Paint Top side");
            }

            if (sides.HasFlag(BorderSides.Bottom))
            {
                WriteLine("Paint Bottom side");
            }
        }
    }
}
