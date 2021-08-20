using System;

using static System.Console;

namespace HomeworkKarina.BasicThings
{
    class HW3_Cycless
    {
		public static void Start()
		{
			int choice = -1;

			do
			{
				WriteLine("-----Меню-----");
				WriteLine("--- 1 - Задача---");
				WriteLine("--- 2 - Задача---");
				WriteLine("--- 3 - Задача---");
				WriteLine("--- 4 - Задача---");
				WriteLine("--- 5 - Задача---");
				WriteLine("--- 6 - Задача---");
				WriteLine("--- 7 - Задача---");
				WriteLine("--- 8 - Задача---");
				WriteLine("--- 9 - Задача---");
				WriteLine("--- 10 - Задача---");
				WriteLine("--- 11 - Задача---");
				WriteLine("--- 12 - Задача---");
				WriteLine("--- 0 - Выход---");
				Write("-->");

				choice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Task1();
						break;
					case 2:
						Task2();
						break;
					case 3:
						Task3();
						break;
					case 4:
						Task4();
						break;
					case 5:
						Task5();
						break;
					case 6:
						Task6();
						break;
					case 7:
						Task7();
						break;
					case 8:
						Task8();
						break;
					case 9:
						Task9();
						break;
					case 10:
						Task10();
						break;
					case 11:
						Task11();
						break;
					case 12:
						Task12();
						break;
					case 0:
						WriteLine("Выход");
						break;
					default:
						WriteLine("Ошибка");
						break;
				}
			} while (choice != 0);
		}

		public static void Task1()
		{
			//Вывести 1010101010101
			int x = 0;
			int num = 13;

			while (x < num)
			{
				if (x % 2 == 0)
				{
					WriteLine("1");
				}
				else
				{
					WriteLine("0");
				}
				x++;
			}
			ReadLine();
		}
		public static void Task2()
		{
			//Вывести 0001000100010
			int x = 1;
			int num = 13;

			while (x <= num)
			{
				if (x % 4 > 0)
				{
					WriteLine("0");
				}
				else
				{
					WriteLine("1");
				}
				x++;
			}

			ReadLine();
		}
		public static void Task3()
		{
			//Вывести 000000011111
			int x = 0;
			int num = 13;

			while (x < num)
			{
				if (x > 6)
				{
					WriteLine("1");
				}
				else
				{
					WriteLine("0");
				}
				x++;
			}

			ReadLine();
		}
		public static void Task4()
		{
			//Вывести 0101010000000
			int x = 0;
			int num = 13;

			while (x < num)
			{
				if (x % 2 == 0)
				{
					WriteLine("0");
				}
				else if (x > 6)
				{
					WriteLine("0");
				}
				else
				{
					WriteLine("1");
				}
				x++;
			}

			ReadLine();
		}
		public static void Task5()
		{
			//Вывести 0000000101010
			int x = 0;
			int num = 13;

			while (x < num)
			{
				if (x < 6)
				{
					WriteLine("0");
				}
				else if (x % 2 == 0)
				{
					WriteLine("0");
				}
				else
				{
					WriteLine("1");
				}
				x++;
			}

			ReadLine();
		}
		public static void Task6()
		{
			//Задача 1
			//1 0 0 0 0 0
			//0 1 0 0 0 0
			//0 0 1 0 0 0
			//0 0 0 1 0 0
			//0 0 0 0 1 0
			//0 0 0 0 0 1

			int width = 6;
			int height = 6;

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if (i == j)
					{
						Write("1");
					}
					else
					{
						Write("0");
					}
				}
				WriteLine();
			}
			ReadLine();
		}
		public static void Task7()
		{
			//Задача 2
			//1 0 0 0 0 0 1
			//0 1 0 0 0 1 0
			//0 0 1 0 1 0 0
			//0 0 0 1 0 0 0

			int width = 7;
			int height = 4;

			int box;

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					box = 6;
					if (j == i || box == i + j)
					{

						Write("1");

					}
					else
					{
						Write("0");
					}
				}

				WriteLine();
			}
			ReadLine();
		}
		public static void Task8()
		{
			//Задача 3
			//1 1 1 1 1 1 1
			//1 0 0 0 0 0 1
			//1 0 0 0 0 0 1
			//1 1 1 1 1 1 1

			int width = 7;
			int height = 4;

			int box;

			for (int i = 0; i < height; i++)
			{

				for (int j = 0; j < width; j++)
				{
					box = 7;
					if (j == j - i || i == i - j || j == box - 1 || i == height - 1)
					{
						Write("1");
					}
					else
					{
						Write("0");
					}

				}
				WriteLine();
			}
			ReadLine();

		}
		public static void Task9()
		{
			//Задача 4
			//0 0 0 0 0 0
			//0 1 1 1 1 0
			//0 1 1 1 1 0
			//0 1 1 1 1 0
			//0 0 0 0 0 0

			int width = 6;
			int height = 5;

			int box, box1;

			for (int i = 0; i < height; i++)
			{

				for (int j = 0; j < width; j++)
				{
					box = 2;
					//box1 = 4;
					if (i == i - j || j == j - i + 1 || j == j - i)
					{
						Write("1");
					}
					else
					{
						Write("0");
					}

				}
				WriteLine();
			}
			ReadLine();
		}
		public static void Task10()
		{
			//Задача 5
			//1 0 0 0 0 0 1
			//0 1 0 0 0 1 0
			//0 0 1 0 1 0 0
			//0 0 0 1 0 0 0
			//0 0 1 0 1 0 0
			//0 1 0 0 0 1 0
			//1 0 0 0 0 0 1

			int width = 7;
			int height = 7;

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if (i == j || width - 1 == i + j)
					{
						Write("1");
					}
					else
					{
						Write("0");
					}
				}
				WriteLine();
			}

			ReadLine();
		}
		public static void Task11()
		{
			//* Задача 6
			//0 0 0 3
			//0 2 3 0
			//0 3 4 0
			//3 0 0 8

			int width = 4;
			int height = 4;


			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if (height - 1 == i + j)
					{
						Write("3");
					}
					else
					{
						Write("0");
					}

				}
				WriteLine();
			}
			ReadLine();
		}
		public static void Task12()
		{
			//* Задача 7
			//0 0 0 1 0 0 0
			//0 0 1 0 1 0 0
			//0 1 0 0 0 1 0
			//1 0 0 0 0 0 1

			int width = 7;
			int height = 4;

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if (i + j == height - 1 || j - i == height - 1)
					{
						Write("1");
					}
					else
					{
						Write("0");
					}
				}
				WriteLine();
			}

			ReadLine();
		}
	}
}
