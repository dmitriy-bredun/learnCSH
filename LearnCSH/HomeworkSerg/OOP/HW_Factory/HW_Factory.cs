using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.OOP.HW_Factory
{
    internal class HW_Factory
    {
        public static void Start()
        {
            Ball ball = new Ball(5, BallColor.Purple);
            Ball ball1 = new Ball(10, BallColor.Yellow);
            Ball ball2 = new Ball(15, BallColor.Black);
            Ball ball3 = new Ball(20, BallColor.Turquoise);

            Storage storage = new Storage();
            storage.KeepBallsInStorage(ball, ball1, ball2, ball3);
            Ball[] balls = storage.GetBallsFromStorage(2, BallColor.Yellow);
        }
    }
}
