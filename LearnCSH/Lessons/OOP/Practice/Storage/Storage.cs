namespace Lessons.OOP.Practice.Storage
{
    class Storage
    {
        public Ball[] StoragedBalls;

        public Storage()
        {

        }

        public void KeepBallsInStorage(Ball[] newBalls)
        {
            if (StoragedBalls == null)
            {
                StoragedBalls = newBalls;
            }
            else
            {
                int countOfStoraged = StoragedBalls.Length;
                int countOfNew = newBalls.Length;
                int amount = countOfStoraged + countOfNew;
                Ball[] common = new Ball[amount];
                
                for (int i = 0; i < StoragedBalls.Length; i++)
                {
                    common[i] = StoragedBalls[i];
                }

                int currentCommonIndx = StoragedBalls.Length;
                for (int i = 0; i < newBalls.Length; i++)
                {
                    common[currentCommonIndx++] = newBalls[i];
                }
            }


        }

        public Ball[] GetBallsFromStorage(int count)
        {
            return null;
        }
    }
}
