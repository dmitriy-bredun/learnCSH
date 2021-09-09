using System;

namespace HomeworkMargaret.General
{
    class Homework2_Operations
    {
        public static void Start()
        {
            Console.WriteLine("Homework START");
            Console.WriteLine("1 - Task 1");
            Console.WriteLine("2 - Task 2");
            Console.WriteLine("3 - Task 3");
            Console.WriteLine("4 - Task 4");
            Console.WriteLine("5 - Task 5");
            Console.Write("---> ");
            string usersChoice = Console.ReadLine();

            switch (usersChoice)
            {
                case "1":                    
                    Console.WriteLine("you chose task 1");
                    Task1();
                    break;
                case "2":                    
                    Console.WriteLine("you chose task 2");
                    Task2();
                    break;
                case "3":                    
                    Console.WriteLine("you chose task 3");
                    Task3();
                    break;
                case "4":
                    Console.WriteLine("you chose task 4");
                    Task4();
                    break;
                case "5":
                    Console.WriteLine("you chose task 5");
                    Task5();
                    break;
                default:                               
                Console.WriteLine("you're stupid");
                    break;
            }
        } 
        public static void Task1()
        {
            Console.Write("Введите число №1: ");
            string val1 = Console.ReadLine();

            Console.Write("Введите число №2: ");
            string val2 = Console.ReadLine();

            int x = Convert.ToInt32(val1);
            int y = Convert.ToInt32(val2);

            if (x == y)
            {
                Console.WriteLine($"Число {x} равно числу {y}");
            }
            else if (x > y)
            {
                Console.WriteLine($"Число {x} больше");
            }
            else
            {
                Console.WriteLine($"Число {y} больше");
            }
        }
        public static void Task2()
        {
            Console.WriteLine("TASK №2");

            Console.Write("Введите целое число: ");
            string val = Console.ReadLine();

            int number = Convert.ToInt32(val);

            if (number > 0 && number < 100)
            {
                Console.WriteLine("Число находится в диапазоне от 0 до 100");
            }
            else
            {
                Console.WriteLine("Число не находится в диапазоне от 0 до 100");
            }
        }
        public static void Task3()
        {
            Console.WriteLine("TASK №3");
            Console.Write("Введите число 1: ");
            string coordXSrt = Console.ReadLine();

            Console.Write("Введите число 2: ");
            string coordYStr = Console.ReadLine();

            int coordX = Convert.ToInt32(coordXSrt);
            int coordY = Convert.ToInt32(coordYStr);

            if (coordX > 0 && coordY > 0)
            {
                Console.WriteLine("Точка пренадлежит к I координатной четверти");
            }
            else if (coordX > 0 && coordY < 0)
            {
                Console.WriteLine("Точка пренадлежит к IV координатной четверти");
            }
            else if (coordX < 0 && coordY < 0)
            {
                Console.WriteLine("Точка пренадлежит к III координатной четверти");
            }
            else
            {
                Console.WriteLine("Точка пренадлежит к II координатной четверти");
            }
        }
        public static void Task4()
        {
            Console.WriteLine("ЗАДАЧА НА ПЯТЬ ЧИСЕЛ");

            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите четвёртое число: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите пятое число: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int max;

            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }

            if (max < num3)
            {
                max = num3;
            }
            
            if (max < num4)
            {
                max = num4;
            }
            
            if (max < num5)
            {
                max = num5;              
            } 
            
            Console.WriteLine($"максимальное число: {max}");         
        }
        public static void Task5()
        {
            Console.WriteLine("Задача с доставкой припасок ВДВ-шникам");

            string sizeXStr;
            string sizeYStr;
            string coordXStr;
            string coordYStr;

            Console.WriteLine("Введите границы карты...");
            Console.Write("введите размер х: ");
            sizeXStr = Console.ReadLine();

            Console.Write("введите размер у: ");
            sizeYStr = Console.ReadLine();

            Console.WriteLine("Введите координаты десантников: ");
            Console.Write("введите координату х: ");
            coordXStr = Console.ReadLine();

            Console.Write("введите кординаты у: ");
            coordYStr = Console.ReadLine();

            int coordX = Convert.ToInt32(coordXStr);
            int coordY = Convert.ToInt32(coordYStr);

            int sizeX = Convert.ToInt32(sizeXStr);
            int sizeY = Convert.ToInt32(sizeYStr);

            if ((coordX + 1) < sizeX  && (coordX +1) > 0)
            {
                Console.WriteLine($"На позицию с координатами x = {coordX + 1}, y = {coordY}, можно скинуть припасы");
            }

            if ((coordX + 1) == sizeX && (coordX + 1) > 0)
            {
                Console.WriteLine($"На позицию с координатами x = {coordX + 1}, y = {coordY}, можно скинуть припасы");
            }

            if ((coordY + 1) < sizeY && (coordY + 1) > 0)
            {
                Console.WriteLine($"На позицию с координатами x = {coordX}, y = {coordY + 1}, можно скинуть припасы");
            }

            if ((coordY + 1) == sizeY && (coordY + 1) > 0)
            {
                Console.WriteLine($"На позицию с координатами x = {coordX}, y = {coordY + 1}, можно скинуть припасы");
            }

            if ((coordX - 1) < sizeX && (coordX - 1) > 0)
            {
                Console.WriteLine($"На позицию с координатами x = {coordX - 1}, y = {coordY}, можно скинуть припасы");
            }

            if ((coordX - 1) == sizeX && (coordX - 1) > 0)
            {
                Console.WriteLine($"На позицию с координатами x = {coordX - 1}, y = {coordY}, можно скинуть припасы");
            }

            if ((coordY - 1) < sizeY && (coordY - 1) > 0)
            {
                Console.WriteLine($"На позицию с координатами x = {coordX}, y = {coordY - 1}, можно скинуть припасы");
            }

            if ((coordY - 1) == sizeY && (coordY - 1) > 0)
            {
                Console.WriteLine($"На позицию с координатами x = {coordX}, y = {coordY - 1}, можно скинуть припасы");
            }
        }
    }
}
