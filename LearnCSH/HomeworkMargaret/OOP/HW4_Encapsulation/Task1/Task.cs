using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static HomeworkMargaret.Tools.CT;


namespace HomeworkMargaret.OOP.HW4_Encapsulation.Task1
{
    class Task
    {
        private static Box box1;
        private static Box box2;
        
        public static void Start()
        {
            Clear();
            int userChoice;
            do
            {
                userChoice = Menu(
                    "Initialize box(-es)",
                    "Compare boxes");
                Space();

                switch (userChoice)
                {
                    case 1:
                        InitializeBoxes();
                        break;

                    case 2:
                        Clear();
                        CompareBoxes();
                        break;

                    case 0:
                        Print("Goodbye!");
                        break;

                    default:
                        ErrorMsg("Incorrent choice");
                        break;
                }                
            } while (userChoice != 0);
        }
                
        public static void InitializeBoxes()
        {
            Clear();
            int userChoice;
            do
            {
                userChoice = Menu(
                    "Initialize  1st box",
                    "Initialize  2nd box",
                    "Go back to the main menu");
                Space();

                switch (userChoice)
                {
                    case 1:
                        box1 = InitializeNewBox();
                        break;

                    case 2:
                        box2 = InitializeNewBox();
                        break;

                    case 3:
                        break;
                    case 0:
                        break;
                    default:
                        ErrorMsg("Incorrent choice");
                        break;
                }
            } while (userChoice != 0 && userChoice != 3);
        }

        public static Box InitializeNewBox()
        {
            double length = EnterDouble("Length: ");
            double heigth = EnterDouble("Height: ");
            double width = EnterDouble("Width: ");
            double weight = EnterDouble("Weight: ");
            return new Box(length, heigth, width, weight);
        }

        public static void CompareBoxes()
        {
            Clear();
            if (box1 != null && box2 != null)
            {
                ShowBoxes();
                if (box1.Volume > box2.Volume)
                {
                    Print("1st box has bigger volume than 2nd box.");
                }
                else if (box1.Volume == box2.Volume)
                {
                    Print("Boxes are equal.");
                }
                else
                {
                    Print("2nd box has bigger volume than 1st box.");
                }

            }
            else
            {
                Print("Comparing cannot be done. Not all boxes were initialized.");
            }
        }

        public static void ShowBoxes()
        {
           if (box1 != null)
           {
                box1.Show();
           }

           if (box2 != null)
           {
                box2.Show();
           }
        }
    }
}
