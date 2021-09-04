using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.General
{
    class Lesson2_3ConditionalConstructions
    {
        public static void Start()
        {
			//	if (isTrue)
			//	{
			//		// блок кода, который выполняется если условие верно
			//	}
			//	else
			//	{
			//		// блок кода, который выполняется если условие не верно
			//	}


			int num1 = 8;
			int num2 = 6;

			//-----------------------------------------------------------------
			// укороченная версия
			if (num1 > num2)
			{
				Console.WriteLine($"Число {num1} больше числа {num2}");
			}

			//-----------------------------------------------------------------
			// полная версия
			if (num1 > num2)
			{
				Console.WriteLine($"Число {num1} больше числа {num2}");
			}
			else
			{
				Console.WriteLine($"Число {num1} меньше числа {num2}");
			}

			//-----------------------------------------------------------------
			// полная версия + дополнительное условие (так можно до бесконечности)
			if (num1 > num2)
			{
				Console.WriteLine($"Число {num1} больше числа {num2}");
			}
			else if (num1 < num2)
			{
				Console.WriteLine($"Число {num1} меньше числа {num2}");
			}
			else
			{
				Console.WriteLine("Число num1 равно числу num2");
			}
		}
    }
}
