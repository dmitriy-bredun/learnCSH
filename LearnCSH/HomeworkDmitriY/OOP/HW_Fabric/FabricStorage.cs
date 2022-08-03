using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDmitriy.OOP.HW_Fabric
{
    internal class FabricStorage
    {
        List<Ball> Red = new List<Ball>();
        List<Ball> Green = new List<Ball>();
        List<Ball> Blue = new List<Ball>();

        public void KeepBallsInStorage(params Ball[] storage)
        {
            for (int i = 0; i < storage.Length; i++)
            {
                switch (storage[i].ballcollor)
                {
                    case Colors.Red:
                        Red.Add(storage[i]);
                        break;

                    case Colors.Green:
                        Green.Add(storage[i]);
                        break;

                    case Colors.Blue:
                        Blue.Add(storage[i]);
                        break;

                    default:
                        break;
                }
            }
        }

        public Ball[] GetBallsFromStorage(int count, Colors ballcollor)
        {
            Ball[] balls = new Ball[count];
            switch (ballcollor)
            {
                case Colors.Red:
                    if (count <= Red.Count)
                    {
                        balls = new Ball[count];
                        for (int i = 0; i < count; i++)
                        {
                            balls[i] = Red[i];
                            Red.RemoveAt(0);
                        }
                    }
                    break;

                case Colors.Green:
                    if (count <= Green.Count)
                    {
                        balls = new Ball[count];
                        for (int i = 0; i < count; i++)
                        {
                            balls[i] = Green[i];
                            Green.RemoveAt(0);
                        }
                    }
                    break;

                case Colors.Blue:
                    if (count <= Blue.Count)
                    {
                        balls = new Ball[count];
                        for (int i = 0; i < count; i++)
                        {
                            balls[i] = Blue[i];
                            Blue.RemoveAt(0);
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
