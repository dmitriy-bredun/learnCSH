using static System.Console;


namespace HomeworkOleg.General
{
    class Homework3_Cycles
    {
        public static void Start()
        {
            {
                WriteLine("ДОМАШКА");
                WriteLine("1 - Задача 1 ");
                WriteLine("2 - Задача 2 - ");
                WriteLine("3 - Задача 3 - ");
                WriteLine("4 - Задача 4 - ");
                WriteLine("5 - Задача 5 - ");
                WriteLine("6 - Задача 6 - ");
                WriteLine("7 - Задача 7 - ");
                Write("---> ");
                string usersChoice = ReadLine();

                switch (usersChoice)
                {
                    case "1":
                        Start1();
                        break;
                    case "2":
                        Start2();
                        break;
                    case "3":
                        Start3();
                        break;
                    case "4":
                        Start4();
                        break;
                    case "5":
                        //Start5();
                        break;
                    case "6":
                        //Start6();
                        break;
                    case "7":
                        //Start7();
                        break;
                    default:
                        WriteLine("/////////////////");
                        break;
                }
            }
        }
        public static void Start1()
        {
            int counter = 1;

            while (counter < 13)
            {
                if (counter % 2 == 0)
                {
                    Write("0 ");
                }
                else
                {
                    Write("1 ");
                }
                counter += 1;
            }
        }
        public static void Start2()
        {
            int counter = 1;

            while (counter < 13)
            {
                if (counter % 3 == 0)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                counter += 1;
            }
        }
        public static void Start3()
        {
            int counter = 1;

            while (counter < 13)
            {
                if (counter % 2 == 0 && counter < 7)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                counter += 1;
            }
        }
        public static void Start4()
        {
            int counter = 1;
            while (counter < 14)
            {
                if (counter % 2 == 0 && counter > 6)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                counter += 1;
            }
        }
    }
}

