using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static System.Math;

using static Lessons.Tools.CT;

using Lessons.Tools;

namespace Lessons
{
    enum Food
    {
        Meat,
        Bread = 2,
        Salmon,
        Berry,
        Tea,
        G = 15,
        K,
        L
    }
    //class Box
    //{
    //    private int age;
    //    public int Age
    //    {
    //        get
    //        {
    //            return (int)(age * Math.PI);
    //        }
    //        set
    //        {
    //            age = value;
    //            if(age < 18)
    //            {
    //                Console.WriteLine("Вы ещё не доросли");
    //            }
    //            else if(age > 30)
    //            {
    //                //logic....
    //            }
    //            else
    //            {
    //                //Приемлимый возраст
    //            }
    //        }
    //    }


    //    private int mainValue;

    //    public int MainValue
    //    {
    //        private get
    //        {
    //            return x*y*z;
    //        }
    //        set
    //        {
    //            mainValue = value;
    //        }
    //    }


    //    private int x;
    //    private int y;
    //    private int z;
    //    public Box(int x)
    //    {
    //        this.x = x;
    //    }
    //    public Box(int x, int y) : this(x)
    //    {
    //        this.y = y;
    //    }
    //    public Box(int x, int y, int z) : this(x, y)
    //    {
    //        this.z = z;
    //    }
    //}
    class Box
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        
        public int V
        {
            get
            {
                return x * y * z;
            }
        }
    }
    class CurrentLessonMargaret
    {
        public static void StartMargaretPractice()
        {
            Box box = new Box();
            box.X = 5;
            box.Y = 7;
            box.Z = 6;
            WriteLine(box.V);
        }

        public static void Start()
        {
            //StartMargaretPractice();
            
            //Box box1 = new Box(5, 6, 7);

            Food food = (int)Food.Meat;

            PrintSpace2();
            PrintSpace2(); // CT писать не нужно из-за using static
        }
    }
}