using System;

using static System.Console;

namespace Lessons.General
{
    class Lesson2_Operations
    {
        public static void Start()
        {
            /////////////////////////////////////////////////////////////////////////
            ///        ОПЕРАЦИИ
            ///        
            /// Существует 3 вида операций:
            /// 
            /// 1) унарные (в операции участвует одна переменная)
            ///    1.1 Операция инкремента
            ///    1.2 Операция декремента
            ///    
            /// 2) бинарные (в операции участвуют две переменных)
            ///    2.1 Математические операции
            ///    2.2 Операции сравнения
            ///    2.3 Логический операции
            ///    
            /// 3) тернарный оператор (будет рассмотрен в следующем уроке)
            ///

            // 1.1 Инкремент / Декремент: бывают 2-х видов. Пре и Пост.
            // --- Пре - сначала происходит увеличение/уменьшение, 
            //      а потом возвращается значение числа.
            // --- Пост - сначала возвращает текущее значение числа,
            //      а потом проводит увеличение/уменьшение значения.
            int intVal = 5;
            WriteLine("intVal = 5");
            WriteLine("WriteLine(++intVal) = {0}", ++intVal);
            WriteLine("WriteLine(intVal++) = {0}", intVal++);
            WriteLine("WriteLine(intVal) = {0}", intVal);
            WriteLine();

            // 2.1 Математические операции
            double x = 5.0;
            double y = 2.5;
            double res = x + y;
            res = x - y;
            res = x * y;
            res = x / y;

            // 2.2 Операции сравнения
            bool isTrue;
            isTrue = 5 == 7; WriteLine("5 == 7: {0}", isTrue);
            isTrue = 5 != 7; WriteLine("5 != 7: {0}", isTrue);
            isTrue = 5 > 7; WriteLine("5 >  7: {0}", isTrue);
            isTrue = 5 >= 7; WriteLine("5 >= 7: {0}", isTrue);
            isTrue = 5 < 7; WriteLine("5 <  7: {0}", isTrue);
            isTrue = 5 <= 7; WriteLine("5 <= 7: {0}", isTrue);
            WriteLine();

            // 2.3 Логические операции
            // Операция ИЛИ - ||  возвращает true если хотя бы один из
            //                    операндов равен true.
            // Операция  И  - &&  возвращает true, когда оба операнда 
            //                    равны true.
            // Операция  НЕ - !   возвращает обратное значение. 
            //
            // Операция ИСКЛЮЧАЮЩЕЕ ИЛИ -   ^   возвращает true, если только один из операндов == true, 
            //                                  (но не одновременно!), в иных случаях возвращает false.
            WriteLine($"false || false = {false || false}");
            WriteLine($"false || true = {false || true}");
            WriteLine($"true || false = {true || false}");
            WriteLine($"true || true = {true || true}");
            WriteLine();

            WriteLine($"false && false = {false && false}");
            WriteLine($"false && true = {false && true}");
            WriteLine($"true && false = {true && false}");
            WriteLine($"true && true = {true && true}");
            WriteLine();

            WriteLine($"false ^ false = {false ^ false}");
            WriteLine($"false ^ true = {false ^ true}");
            WriteLine($"true ^ false = {true ^ false}");
            WriteLine($"true ^ true = {true ^ true}");
            WriteLine();

            bool trueBool = true;
            WriteLine($"  !true: {!true}");
            WriteLine($"  !false: {!false}");
            WriteLine($" bool isTrue = {trueBool}");
            WriteLine($"     !isTrue = {!trueBool}");
            WriteLine();

            // Операции имеют приоритет:
            // 1 - математические
            // 2 - сравнения
            // 3 - логические
            // 4 - присваивание
        }
    }
}
