using System;

using Lessons.Tools;

namespace Lessons
{
    class CurrentLesson
    {
        public static void GoGoGo()
        {
            /////////////////////////////////////////////////////////////////////////////1 
            ///                     ПРЕОБРАЗОВАНИЕ ТИПОВ
            /// 
            /// Бывает 2-х видов:   
            /// 
            ///     1) ЯВНОЕ - используется когда при преобразовании типов может быть утрачена 
            /// часть информации. Например: при приобразовании float в int обрезается 
            /// вся дробная часть числа. ТРЕБУЕТ ЯВНОГО ПРИВЕДЕНИЯ ТИПА.
            /// 
            /// Необходимо ЯВНО указывать тип, к которому выполняется преобразование:
            /// 
            ///     2) НЕ ЯВНОЕ - выполняется автоматически, если сохраняемое значение может уместиться 
            /// в переменной без усечения или округления. НЕ ТРЕБУЕТ ЯВНОГО ПРИВЕДЕНИЯ ТИПА.
            /// 

            // 1 Явное ----------------------------
            int intVal = 123;
            sbyte sbVal = (sbyte)intVal;
            short shshshVal = (short)intVal;

            double dVal = 123.4565789;
            long lVal = (long)dVal;

            float f = 123.654f;
            int intValffff = (int)f;


            // 2 Не явное ----------------------------
            short shVal = short.MaxValue;
            int iVAl = shVal;

            long iiVAL = 123123123;
            float fval = iiVAL;

            
            // ------------------------------- C O N V E R T I N G 

            // Пример полного сценария
            string strValue1 = Console.ReadLine();
            string strValue2 = Console.ReadLine();

            Console.WriteLine($"val1 = {strValue1}, val2 = {strValue2}");
            Console.WriteLine($"str: str + str -> {strValue1 + strValue2}");

            int val1 = Convert.ToInt32(strValue1);
            int val2 = Convert.ToInt32(strValue2);
            Console.WriteLine($"int: int + int -> {val1 + val2}");


            // Пример короткого сценария
            int shte = Convert.ToInt32(Console.ReadLine());


            // Как превратить переменную примитивного типа в тип string
            float cheZaHernya = 123.456f;
            string cheZaHernyaString1 = cheZaHernya.ToString();

        }
    }
}