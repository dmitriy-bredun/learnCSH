using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.OOP.HW_AccountManager
{
    public class HW_AccountManager
    {
        public static void Start()
        {
            int userChoice = 0;
            do
            {
                WriteLine();
                WriteLine("     WELCOME TO THE SOCIAL NETWORK <DEATH TO mOSKAL> !");
                WriteLine();
                WriteLine("     Please register to confirm that you and your loved ones are not moskaly.");
                WriteLine();
                WriteLine("     1)  Add a new profile; ");
                WriteLine();
                WriteLine("     2)  Change profession; ");
                WriteLine();
                WriteLine("     3)  Indicate Father; ");
                WriteLine();
                WriteLine("     4)  Indicate Mother; ");
                WriteLine();
                WriteLine("     5)  Add friend (friend not from moskal); ");
                WriteLine();
                WriteLine("     6)  Delete a friend (Good moskal - is a dead moskal). ");
                WriteLine();
                WriteLine("     Your choice  --->   ");
                userChoice = Convert.ToInt32(ReadLine());
                WriteLine();

                switch (userChoice)
                {
                    case 1:
                        WriteLine();
                        WriteLine("     1)  Add a new profile; ");
                        WriteLine();
                        WriteLine("    Please enter name.");
                        WriteLine();
                        string name = (ReadLine());
                        WriteLine();
                        WriteLine("    Please enter age.");
                        WriteLine();
                        int age = Convert.ToInt32(ReadLine());
                        WriteLine();
                        WriteLine("    Please enter profession.");
                        WriteLine();

                        break;
                        
                    case 2:
                        break;

                    default:
                        WriteLine("    Invalid input.");
                        break;
                }
            }while (true);
        }
    }
}
