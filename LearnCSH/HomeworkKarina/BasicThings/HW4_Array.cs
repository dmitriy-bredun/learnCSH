using static System.Console;

namespace HomeworkKarina.BasicThings
{
    class HW4_Array
    {
        public static void Start()
        {
            Array_Sorting_Task();
        }

        public static void Array_Sorting_Task()
        {
            int[] num = new int[15];

            num[0] = 9;
            num[1] = 6;
            num[2] = 7;
            num[3] = 8;
            num[4] = 1;
            num[5] = 2;
            num[6] = 4;
            num[7] = -5;
            num[8] = 3;
            num[9] = 5;
            num[10] = 5;
            num[11] = -6;
            num[12] = 1;
            num[13] = 0;
            num[14] = 44;

            for (int indx = 0; indx < num.Length; indx++)
            {
                WriteLine($"num ({indx}) = {num[indx]}");
            }

            WriteLine();

            Sort(num);

            ReadLine();
        }
        public static void Sort(int[] arr)
        {
            int box;
            bool check = true;
            int countOfIterations = 0;

            while (check)
            {
                check = false;
                countOfIterations++;
                for (int indx = 0; indx < (arr.Length - 1); indx++)
                {
                    if (arr[indx] > arr[indx + 1])
                    {
                        box = arr[indx];
                        arr[indx] = arr[indx + 1];
                        arr[indx + 1] = box;

                        check = true;
                    }
                }
            }

            WriteLine($"Количество итераций цикла, сделанных во время сортировки: {countOfIterations}");

            for (int indx = 0; indx < arr.Length; indx++)
            {
                WriteLine(arr[indx]);
            }

            ReadLine();
        }
    }
}
