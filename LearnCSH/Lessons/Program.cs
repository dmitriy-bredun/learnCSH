using System;

using Lessons.General.Lessons;
using Lessons.General.Practice;

using Lessons.OOP.Lessons.Lesson1_Classes;
using Lessons.OOP.Lessons.Lesson2_Methods;

using Lessons.OOP.Practice.Labyrinth;

namespace Lessons
{
    class Program
    {
        public static ConsoleColor AppForegroundColor { get; private set; }
        public static ConsoleColor AppBackgroundColor { get; private set; }

        private static void GothamConsoleTheme()
        {
            Console.ForegroundColor = AppForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = AppBackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        static void Main(string[] args)  
        {
            GothamConsoleTheme();

            // = = = = = = = =   General programming  = = = = = = = = = = = =            
            // Lesson1_Variables.Start();
            // Lesson2_1TypeConversion.Start();
            // Lesson2_2Operations.Start();
            // Lesson2_3ConditionalConstructions.Start();
            // Lesson3_SwitchAndTernaryOperation.Start();
            // Lesson4_Cycles.Start();
            // Lesson5_StaticMethods.Start();
            // Lesson6_SimpleArrays.Start();
            // Lesson7_MultiDimensionalArrays.Start();
            Lesson8_Enums.Start();

            // Practice1_Opearations.Start();
            // Practice2_Cycles.Start();
            // Practice2_DoubleCycles.Start();
            // Practice3_Tasks.Start();
            // Practice4_SimpleArrays.Start();
            // Practice5_VDV.Start();


            // = = = = = = = =   Object oriented programming  = = = = = = = = =   
            // Lesson1_Classes.Start();
            // Lesson2_Methods.Start();

            // Practice1_Labyrinth.StartGame();
        }
    }
}
