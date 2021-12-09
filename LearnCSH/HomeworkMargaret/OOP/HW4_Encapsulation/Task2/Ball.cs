namespace HomeworkMargaret.OOP.HW4_Encapsulation.Task2
{
    enum Colors
    {
       Yellow, 
       Green,
       Red,
       Blue,
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
