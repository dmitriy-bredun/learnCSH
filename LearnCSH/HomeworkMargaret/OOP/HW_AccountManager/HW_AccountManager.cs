using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW_AccountManager
{
    class HW_AccountManager
    {
        public enum Parent
        {
            Father,
            Mother
        }

        private static List<Person> profile = new List<Person>();
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
                    " Remove a friend ",
                    " Show all profiles");

                switch (userChoice)
                {
                    case 1:
                        AddNewProfile();
                        break;

                    case 2:
                        ChangeProfession();
                        break;

                    case 3:
                        AddParent(Parent.Father);
                        break;

                    case 4:
                        AddParent(Parent.Mother);
                        break;

                    case 5:
                        AddAFriend();
                        break;

                    case 6:
                        RemoveAFriend();
                        break;

                    case 7:
                        ShowProfiles();
                        break;

                    default:
                        Print("Oops, smth went wrong");
                        break;
                }

            } while (userChoice != 0);
        }

        public static void AddNewProfile()
        {
            Print("Please, fill next fields to create new profile.");
            string name = EnterString("Name: ");
            int age = EnterInt("Age: ");
            Print("Choose your profession: ");
            Profession prof = (Profession)EnumMenu(typeof(Profession));
            Person person = new Person(name, age, prof);
            profile.Add(person);
            Print("Profile has been created.");
            /*person.Profession = (Profession)153*/;
        }

        public static void ChangeProfession()
        {
            Person person = ChooseAProfile();
            Print("Choose another profession: ");
            Profession newProf = (Profession)EnumMenu(typeof(Profession));
            person.Profession = newProf;
        }

        public static void AddParent(Parent parent)
        {
            Print("Choose a profile to change: ");
            Person person = ChooseAProfile();
            Space();

            Print($"Please, choose a {parent}:");
            Person parentProfile = ChooseAProfile(person);
            Space();

            switch (parent)
            {
                case Parent.Father:
                    person.AddFather(parentProfile);
                    break;

                case Parent.Mother:
                    person.AddMother(parentProfile);
                    break;
                
                default:
                    break;
            }

            Print($"{parent} {parentProfile._name} was added to the profile.");
        }

        public static void AddAFriend()
        {
            Print("Choose a profile to change: ");
            Person person = ChooseAProfile();
            Space();

            Print("Choose a friend profile: ");
            Person friend = ChooseAProfile(person);
            Space();

            person.AddAFriend(friend);

            Print($"{friend._name} was added to the profile's friends.");
        }

        public static void RemoveAFriend()
        {
            Print("Choose a profile to change: ");
            Person person = ChooseAProfile();
            Space();           

            for(int i = 0; i < person._friends.Count; i++)
            {
                Print($"Profile № {i + 1} ");
                profile[i].ShowInfo();
            }

            int indx = EnterInt("Choose a friend to delete: ");
            person.RemoveFriend(indx - 1);
            Print("A friend has been removed.");
        }

        public static void ShowProfiles(Person excludeProfile = null)
        {
            for (int i = 0; i < profile.Count; i++)
            {
                if (profile[i] == excludeProfile)
                {
                    continue;
                }
                else
                {
                    Print($"Profile № {i + 1} ");
                    profile[i].ShowInfo();
                }
            }
        }

        private static Person ChooseAProfile(Person excludeProfile = null)
        {
            ShowProfiles(excludeProfile);
            int choice = EnterInt("Choose a profile: ");
            return profile[choice - 1];
        }
    }
}
