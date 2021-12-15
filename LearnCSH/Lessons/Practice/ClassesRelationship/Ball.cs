namespace Lessons.Practice.ClassesRelationship
{
    enum Colors
    {
        Yellow,
        Green,
        Blue,
        Red
    }

    class Ball
    {
        private Colors _color;

        public Colors Color
        {
            get { return _color; }
            private set { _color = value; }
        }

        public Ball(Colors ballColor)
        {
            Color = ballColor;
        }
    }
}