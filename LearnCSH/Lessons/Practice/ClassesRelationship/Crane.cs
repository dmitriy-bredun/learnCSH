using System;

namespace Lessons.Practice.ClassesRelationship
{
    class Crane
    {
        public Ball[] CreateBalls(int count)
        {
            Ball[] createdBalls = new Ball[count];
            
            int countOfColors = Enum.GetValues(typeof(Colors)).Length;
            Random generator = new Random();

            for (int indx = 0; indx < count; indx++)
            {
                Colors randomColor = (Colors)generator.Next(countOfColors);

                createdBalls[indx] = new Ball(randomColor);
            }
            
            return createdBalls;
        }

        public void ThrowBallsToStorage(int count, Ball[] balls, Storage storage)
        {
            storage.SaveBalls(count, balls);
        }

        public int TakeBallsFromStorage(int count, Colors color, Storage storage)
        {
            storage.GiveBalls(count, color);
            return 0;
        }
    }
}
