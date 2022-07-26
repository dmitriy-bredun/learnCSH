using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMargaret.OOP.HW_Fabric
{
    class FabricStorage
    {
        public Ball[] StoragedBalls;
        List<int> redBalls = new List<int>();
        List<int> blueBalls = new List<int>();
        List<int> blackBalls = new List<int>();

        public int color;
        public void KeepBallsInStorage (Ball[] newBalls)
        {
            if (StoragedBalls == null)
            {
                StoragedBalls = newBalls;
            }
            else
            {
                int alreadyStoraged = StoragedBalls.Length;
                int newStoraged = newBalls.Length;
                int allStoraged = alreadyStoraged + newStoraged;
                Ball[] allStoragedBalls = new Ball[allStoraged];

                for (int i = 0; i < StoragedBalls.Length; i++)
                {
                    allStoragedBalls[i] = StoragedBalls[i];
                }

                int indx = StoragedBalls.Length;
                for (int i = 0; i < newBalls.Length; i++)
                {
                    allStoragedBalls[indx++] = newBalls[i];
                }
                
            }
        }

        public Ball[] GetBallsFromStorage(int count, BallColor color)
        {
            int countOfBalls = 0;
            
            if (color == BallColor.Red)
            {
                redBalls.Remove(count);
            }
            else if (color == BallColor.Blue)
            {
                blueBalls.Remove(count);
            }
            else
            {
                blackBalls.Remove(count);
            }
            Ball[] leftBalls = new Ball[countOfBalls];

            return leftBalls;
        }
    }
}
