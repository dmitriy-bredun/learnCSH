using System.Collections.Generic;


namespace HomeworkMargaret.OOP.HW_Fabric
{
    class FabricStorage
    {
        List<Ball> redBalls = new List<Ball>();
        List<Ball> blueBalls = new List<Ball>();
        List<Ball> blackBalls = new List<Ball>();

        public void KeepBallsInStorage(params Ball[] newBalls)
        {
            foreach (Ball ball in newBalls)
            {
                switch (ball.Color)
                {
                    case BallColor.Red:
                        redBalls.Add(ball);
                        break;

                    case BallColor.Blue:
                        blueBalls.Add(ball);
                        break;

                    case BallColor.Black:
                        blackBalls.Add(ball);
                        break;

                    default:
                        break;
                }
            }
        }

        public Ball[] GetBallsFromStorage(int count, BallColor color)
        {
            Ball[] balls = null;
            switch (color)
            {
                case BallColor.Red:
                    if (count <= redBalls.Count)
                    {
                        balls = new Ball[count];
                        redBalls.CopyTo(0, balls, 0, count);
                        redBalls.RemoveRange(0, count);
                    }
                    break;

                case BallColor.Blue:
                    if (count <= blueBalls.Count)
                    {
                        balls = new Ball[count];
                        blueBalls.CopyTo(0, balls, 0, count);
                        blueBalls.RemoveRange(0, count);
                    }
                    break;

                case BallColor.Black:
                    if (count <= blackBalls.Count)
                    {
                        balls = new Ball[count];
                        blackBalls.CopyTo(0, balls, 0, count);
                        blackBalls.RemoveRange(0, count);
                    }
                    break;

                default:
                    break;
            }

            return balls;
        }
    }
}
