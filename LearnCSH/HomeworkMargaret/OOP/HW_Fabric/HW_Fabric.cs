using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMargaret.OOP.HW_Fabric
{
    class HW_Fabric
    {
        public static void Start()
        {
            Ball ball = new Ball(3, BallColor.Red);
            Ball ball2 = new Ball(5, BallColor.Red);
            Ball ball3 = new Ball(4, BallColor.Red);
            Ball ball4 = new Ball(38, BallColor.Blue);
            Ball ball5 = new Ball(36, BallColor.Blue);
            Ball ball6 = new Ball(37, BallColor.Blue);

            FabricStorage storage = new FabricStorage();
            storage.KeepBallsInStorage(ball, ball2, ball3, ball4, ball5, ball6);
            Ball[] balls = storage.GetBallsFromStorage(2, BallColor.Red);
        }
    }
}
