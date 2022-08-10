using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW_AccountManager
{
    class HW_AccountManager
    {
        List<Person> friends = new List<Person>();
        List<Person> people = new List<Person>();
        public static void Start()
        {
            int userChoice;
            do
            {
                Space();
                userChoice = Menu(
                    " Add new profile ",
                    " Change profession ",
                    " Choose a father ",
                    " Choose a mother ",
                    " Add a friend ",
                    " Remove a friend ");

                switch (userChoice)
                {
                    case 1:
                        AddNewProfile();
                        break;

                    case 2:
                        ChangeProfession();
                        break;

                    case 3:
                        ChooseAFather();
                        break;

                    case 4:
                        ChooseAMother();
                        break;

                    case 5:
                        AddAFriend();
                        break;

                    case 6:
                        RemoveAFriend();
                        break;

                    default:
                        Print("Oops, smth went wrong");
                        break;
                }

            } while (userChoice != 0);
        }

        public static void AddNewProfile()
        {
            string name = EnterString("Name: ");
            int age = EnterInt("Age: ");
            Profession prof = (Profession)EnterInt("Choose a profession: ");
            Person person = new Person(name, age, prof);
            people.Add(1);
        }

        public static void ChangeProfession()
        {
            
        }

        public static void ChooseAFather()
        {

        }

        public static void ChooseAMother()
        {

        }

        public static void AddAFriend()
        {

        }

        public static void RemoveAFriend()
        {

        }
    }
}
