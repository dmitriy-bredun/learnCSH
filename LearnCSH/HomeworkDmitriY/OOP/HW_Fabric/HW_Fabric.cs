using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDmitriy.OOP.HW_Fabric
{
    internal class HW_Fabric
    {
        public static void Start()
        {
            Ball ball1 = new Ball(3, Colors.Red);
            Ball ball2 = new Ball(7, Colors.Red);
            Ball ball3 = new Ball(1, Colors.Blue);

            FabricStorage storage = new FabricStorage();
            storage.KeepBallsInStorage(ball1, ball2, ball3);

            Ball[] balls4 = storage.GetBallsFromStorage(10, Colors.Red);
            Ball[] balls5 = storage.GetBallsFromStorage(12, Colors.Blue);
            Ball[] balls6 = storage.GetBallsFromStorage(5, Colors.Blue);
        }
    }
}
