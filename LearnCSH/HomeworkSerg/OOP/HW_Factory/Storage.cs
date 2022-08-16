using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSerg.OOP.HW_Factory
{
    internal class Storage
    {
        List<Ball> PurpleBalls = new List<Ball>();
        List<Ball> YellowBalls = new List<Ball>();
        List<Ball> BlackBalls = new List<Ball>();
        List<Ball> TurquoiseBalls = new List<Ball>();

        public void KeepBallsInStorage(params Ball[] newBalls)
        {
            for (int i = 0; i < newBalls.Length; i++)
            {
                switch (newBalls[i].color)
                {
                    case BallColor.Purple:
                        PurpleBalls.Add(newBalls[i]);
                        break;

                    case BallColor.Yellow:
                        YellowBalls.Add(newBalls[i]);
                        break;

                    case BallColor.Black:
                        BlackBalls.Add(newBalls[i]);
                        break;

                    case BallColor.Turquoise:
                        TurquoiseBalls.Add(newBalls[i]);
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
                case BallColor.Purple:
                    if (count <= PurpleBalls.Count)
                    {
                        balls = new Ball[count];
                        for(int i = 0; i < count; i++)
                        {
                            balls[i] = PurpleBalls[i];
                            PurpleBalls.RemoveAt(0);
                        }    
                    }
                    break;

                case BallColor.Yellow:
                    if (count <= YellowBalls.Count)
                    {
                        balls = new Ball[count];
                        for (int i = 0; i < count; i++)
                        {
                            balls[i] = YellowBalls[i];
                            YellowBalls.RemoveAt(0);
                        }
                    }
                    break;

                case BallColor.Black:
                    if (count <= BlackBalls.Count)
                    {
                        balls = new Ball[count];
                        for (int i = 0; i < count; i++)
                        {
                            balls[i] = BlackBalls[i];
                            BlackBalls.RemoveAt(0);
                        }
                    }
                    break;

                case BallColor.Turquoise:
                    if (count <= TurquoiseBalls.Count)
                    {
                        balls = new Ball[count];
                        for (int i = 0; i < count; i++)
                        {
                            balls[i] = TurquoiseBalls[i];
                            TurquoiseBalls.RemoveAt(0);
                        }
                    }
                    break;

                default:
                    break;
            }
            return balls;
        }


    }
}