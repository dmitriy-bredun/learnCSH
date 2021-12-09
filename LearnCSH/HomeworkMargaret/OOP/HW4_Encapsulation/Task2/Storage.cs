using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW4_Encapsulation.Task2
{
    class Storage
    {
        private int _yellowBallCount;
        private int _greenBallCount;
        private int _redBallCount;
        private int _blueBallCount;

        public int YellowBallCount
        {
            get { return _yellowBallCount; }
        }

        public int GreenBallCount
        {
            get { return _greenBallCount; }
        }

        public int RedBallCount
        {
            get { return _redBallCount; }
        }

        public int BlueBallCount
        {
            get { return _blueBallCount; }
        }

        public Ball[] SaveBalls(int count, Ball[] balls)
        {
            for (int indx = 0; indx < count; indx++)
            {
                Colors currentBoxColor = balls[indx].Color;
                switch(currentBoxColor)
                {
                    case Colors.Blue:
                        _blueBallCount++;
                        break;

                    case Colors.Green:
                        _greenBallCount++;
                        break;

                    case Colors.Red:
                        _redBallCount++;
                        break;

                    case Colors.Yellow:
                        _yellowBallCount++;
                        break;

                    default:
                        ErrorMsg("Unknown color");
                        break;
                }

                balls[indx] = null;
            }

            Ball[] leftBalls = RemoveStoragedBalls(count, balls);
            return leftBalls;
        }

        public Ball[] GiveBalls(int count, Colors color)
        {
            switch (color)
            {
                case Colors.Yellow:
                    _yellowBallCount -= count;
                    break;

                case Colors.Green:
                    _greenBallCount -= count;
                    break;

                case Colors.Red:
                    _redBallCount -= count;
                    break;

                case Colors.Blue:
                    _blueBallCount -= count;
                    break;
            }

            Ball[] storagedBalls = new Ball[count];

            for (int indx = 0; indx < storagedBalls.Length; indx++)
            {
                storagedBalls[indx] = new Ball(color);
            }

            return storagedBalls;
        }

        public string GetStorageInfo()
        {
            string info = "\n";
            info += $"  Count of yellow balls = {_yellowBallCount} \n";
            info += $"  Count of green balls = {_greenBallCount} \n";
            info += $"  Count of red balls = {_redBallCount} \n";
            info += $"  Count of blue balls = {_blueBallCount} ";
            
            return info;
        }

        private Ball[] RemoveStoragedBalls(int count, Ball[] balls)
        {
            int counterOfLeftBalls = 0;
            for (int indx = 0; indx < balls.Length; indx++)
            {
                if (balls[indx] != null)
                {
                    counterOfLeftBalls++;
                }
            }

            if (counterOfLeftBalls == 0)
            {
                return null;
            }

            Ball[] leftBalls = new Ball[counterOfLeftBalls];

            int actualIndx = balls.Length - counterOfLeftBalls;
            for (int indx = 0; indx < leftBalls.Length; indx++, actualIndx++)
            {
                leftBalls[indx] = balls[actualIndx];
            }

            return leftBalls;
        }
    }
}
