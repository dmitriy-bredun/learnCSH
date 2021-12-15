using Lessons.Tools;

namespace Lessons.Practice.ClassesRelationship
{
    class Storage
    {
        private int _yellowBallCount;
        private int _greenBallCount;
        private int _blueBallCount;
        private int _redBallCount;


        public void SaveBalls(int count, Ball[] balls )
        {
            if (count > balls.Length)
            {
                CT.ErrorMsg("Вы пытаетесь сохранить в хранилище больше мячей, чем у вас есть!!!");
                return;
            }

            for (int indx = 0; indx < count; indx++)
            {
                Colors currentBoxColor = balls[indx].Color;
                switch (currentBoxColor)
                {
                    case Colors.Yellow:
                        _yellowBallCount++;
                        break;

                    case Colors.Green:
                        _greenBallCount++;
                        break;

                    case Colors.Blue:
                        _blueBallCount++;
                        break;

                    case Colors.Red:
                        _redBallCount++;
                        break;
                    default:
                        CT.ErrorMsg("Вы пытаетесь сохранить шарик с неизвестным цветом!!!");
                        break;
                }

                balls[indx] = null;
            }
        }

        public Ball[] GiveBalls(int count, Colors color)
        {
            return null;
        }
    }
}
