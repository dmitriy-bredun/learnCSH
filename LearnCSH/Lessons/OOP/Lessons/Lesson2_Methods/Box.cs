using static System.Console;

namespace Lessons.OOP.Lessons.Lesson2_Methods
{
    public class Box
    {
        public int Height;
        public int Width;
        public int Length;

        public Box(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public int GetSquare()
        {
            return Height * Width * Length;
        }

        public void ShowBoxInfo()
        {
            WriteLine($"Box info:");
            WriteLine($"height = {Height}");
            WriteLine($"width = {Width}");
            WriteLine($"length = {Length}");
        }
    }
}
