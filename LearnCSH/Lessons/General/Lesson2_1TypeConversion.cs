using System;

namespace Lessons.General
{
    class Lesson2_1TypeConversion
    {
        public static void Start()
        {
            TypeConversion();
            Convertations();
        }

        public static void TypeConversion()
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
            /// Например: 

            double doubleVal = 123.456;
            int intVal = (int)doubleVal;
            float floatVal = (float)doubleVal;


            ///     2) НЕ ЯВНОЕ - выполняется автоматически, если сохраняемое значение может уместиться 
            /// в переменной без усечения или округления. НЕ ТРЕБУЕТ ЯВНОГО ПРИВЕДЕНИЯ ТИПА.
            /// Например:
            sbyte sbyteVal = 10;
            int iVal = sbyteVal;
            double dVal = iVal;
        }

        public static void Convertations()
        {
            /////////////////////////////////////////////////////////////////////////////
            ///                     Класс Convert
            ///
            /// При приобразовании числа из строчного представления в переменную целого
            /// типа - необходимо использовать класс Convert
            /// 
            string inputStr = Console.ReadLine();

            sbyte sbyteValue = Convert.ToSByte(inputStr);
            short shortValue = Convert.ToInt16(inputStr);
            int intValue = Convert.ToInt32(inputStr);
            long longValue = Convert.ToInt64(inputStr);


            string inputDecimalStr = Console.ReadLine();

            float floatValue = Convert.ToSingle(inputDecimalStr);
            double doubleValue = Convert.ToDouble(inputDecimalStr);
            decimal decValue = Convert.ToDecimal(inputDecimalStr);

            /// Так же.. класс Convert может использоваться для других видов преобразований.
            /// Например:
            float f = 123.654f;
            int intVal = Convert.ToInt32(f);
        }
    }
}
