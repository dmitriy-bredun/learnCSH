using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.OOP.HW1_Classes
{
    internal class HW1_Classes
    {
        public static void Start()
        {
            int userChoice = 0;

            do
            {
                WriteLine();
                WriteLine("     Make a choice:");
                WriteLine();
                WriteLine("     1)  Well characteristics;");
                WriteLine("     2)  Field characteristics;");
                WriteLine();
                WriteLine("     Your choice  --->   ");
                userChoice = Convert.ToInt32(ReadLine());
                WriteLine();

                switch (userChoice)
                {
                    case 1:
                        WriteLine();
                        WriteLine("    Please enter well characteristics.");
                        WriteLine();

                        WriteLine("     Enter well Number:");
                        int number = Convert.ToInt32(ReadLine());
                        WriteLine();

                        WriteLine("     Enter well Type:");
                        string type = (ReadLine());
                        WriteLine();

                        WriteLine("     Enter well Diameter:");
                        int diameter = Convert.ToInt32(ReadLine());
                        WriteLine();

                        WriteLine("     Enter well Depth:");
                        int depth = Convert.ToInt32(ReadLine());
                        WriteLine();

                        WriteLine("     Enter well Numb Of Rings:");
                        int numbRings = Convert.ToInt32(ReadLine());
                        WriteLine();

                        WriteLine("     Enter well Volume:");
                        int volume = Convert.ToInt32(ReadLine());
                        WriteLine();

                        WriteLine("     Enter well Equipment:");
                        string equipment = (ReadLine());
                        WriteLine();

                        Well well = new Well(number, type, diameter, depth, numbRings, volume, equipment);

                        ShowWell(well);
                        break;

                    case 2:
                        WriteLine();
                        WriteLine("    Please enter field characteristics.");
                        WriteLine();

                        WriteLine("     Enter field number:");
                        int number1 = Convert.ToInt32(ReadLine());
                        WriteLine();

                        WriteLine("     Enter field crop:");
                        string crop = (ReadLine());
                        WriteLine();

                        WriteLine("     Enter field length:");
                        int length = Convert.ToInt32(ReadLine());
                        WriteLine();

                        WriteLine("     Enter field width:");
                        int width = Convert.ToInt32(ReadLine());
                        WriteLine();

                        WriteLine("     Enter field area:");
                        int area = Convert.ToInt32(ReadLine());
                        WriteLine();

                        WriteLine("     Enter field watering:");
                        string watering = (ReadLine());
                        WriteLine();


                        Field field = new Field(number1, crop, length, width, area, watering);

                        ShowField(field);
                        break;
                    
                    default:
                        WriteLine("    Invalid input.");
                        break;
                }
            } while (userChoice != 0);
        }

        public static void ShowWell(Well showWell)
        {
            WriteLine();
            WriteLine($"    Well Number: {showWell.Number}:");
            WriteLine();
            WriteLine($"    Well Type: {showWell.Type}");
            WriteLine();
            WriteLine($"    Well Diameter: {showWell.Diameter}");
            WriteLine();
            WriteLine($"    Well Depth: {showWell.Depth}");
            WriteLine();
            WriteLine($"    Well Numb Of Rings: {showWell.NumbOfRings}");
            WriteLine();
            WriteLine($"    Well Volume: {showWell.Volume}");
            WriteLine();
            WriteLine($"    Well Equipment: {showWell.Equipment}");
            WriteLine();
        }
        public static void ShowField(Field showField)
        {
            WriteLine();
            WriteLine($"    Field Number: {showField.Number}:");
            WriteLine();
            WriteLine($"    Field Crop: {showField.Crop}");
            WriteLine();
            WriteLine($"    Field Length: {showField.Length}");
            WriteLine();
            WriteLine($"    Field Width: {showField.Width}");
            WriteLine();
            WriteLine($"    Field Area: {showField.Area}");
            WriteLine();
            WriteLine($"    Field Watering: {showField.Watering}");
            WriteLine();
        }
    }
}
