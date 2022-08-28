using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.OOP.HW_AccountManager
{
    public class HW_AccountManager
    {
        public static List<Person> Accounts = new List <Person>();

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
                WriteLine("     2)  Shou all profile; ");
                WriteLine();
                WriteLine("     3)  Change profession; ");
                WriteLine();
                WriteLine("     4)  Indicate Father; ");
                WriteLine();
                WriteLine("     5)  Indicate Mother; ");
                WriteLine();
                WriteLine("     6)  Add friend (friend not from moskal); ");
                WriteLine();
                WriteLine("     7)  Delete a friend (Good moskal - is a dead moskal). ");
                WriteLine();
                WriteLine("     Your choice  --->   ");
                userChoice = Convert.ToInt32(ReadLine());
                WriteLine();

                switch (userChoice)
                {
                    case 1:
                        AddNewProfile();
                        break;
                    case 2:
                        ShouProfile();
                        break;
                    case 3:
                        ChangeProfession();
                        break;
                    case 4:
                        IndicateFather();
                        break;
                    case 5:
                        IndicateMother();
                        break;
                    case 6:
                        AddFriendProfile();
                        break;
                    case 7:
                        DeleteFriend();
                        break;

                    default:
                        WriteLine("    You wrong. Are you stupid as a moskal?");
                        break;
                }
            }while (true);
        }
        public static void AddNewProfile()
        {
            int userChoice2 = 0;
            WriteLine();
            WriteLine("     1)  Add a new profile; ");
            WriteLine();
            WriteLine("     Please enter name.");
            WriteLine();
            string name = ReadLine();
            WriteLine();
            WriteLine("     Please enter age.");
            WriteLine();
            int age = Convert.ToInt32(ReadLine());
            WriteLine();
            //WriteLine("    Please choice profession:");
            //WriteLine();
            //WriteLine("    1 - Soldier VSU,");
            //WriteLine("    2 - Musician,");
            //WriteLine("    3 - Killer,");
            //WriteLine("    4 - Cook,");
            //WriteLine("    5 - Assasin,");
            //WriteLine("    6 - Teacher,");
            //WriteLine("    7 - Ninja,");
            //WriteLine("    8 - Painter,");
            //WriteLine("    9 - Police,");
            //WriteLine("    10 - Mechanic.");

            //userChoice2 = Convert.ToInt32(ReadLine());

            //Profession prof;

            //switch (userChoice2)
            //{
            //    case 1:
            //        prof = Profession.Soldier_VSU;
            //        break;
            //    case 2:
            //        prof = Profession.Musician;
            //        break;
            //    case 3:
            //        prof = Profession.Killer;
            //        break;
            //    case 4:
            //        prof = Profession.Cook;
            //        break;
            //    case 5:
            //        prof = Profession.Assasin;
            //        break;
            //    case 6:
            //        prof = Profession.Teacher;
            //        break;
            //    case 7:
            //        prof = Profession.Ninja;
            //        break;
            //    case 8:
            //        prof = Profession.Painter;
            //        break;
            //    case 9:
            //        prof = Profession.Police;
            //        break;
            //    case 10:
            //        prof = Profession.Mechanic;
            //        break;
            //    default:
            //        WriteLine("    You wrong. Are you stupid as a moskal?");
            //        prof = Profession.Soldier_VSU;
            //        break;
            //}
            Profession prof = ChooseProfession();
            Person acc = new Person(name, age, prof);
            Accounts.Add(acc);
            WriteLine();
            WriteLine($"    Congratulations ! Account created. Welcome {acc.Name}");
        }
        public static void ShouProfile()
        {
            int index = 0;
            foreach (Person acc in Accounts)
            {
                WriteLine();
                WriteLine($" Profile #{index++}");
                WriteLine($" Name: {acc.Name};");
                WriteLine($" Age: {acc.Age};");
                WriteLine($" Profession: {acc.Prof}.");
                WriteLine();
                
                if(acc.Father != null)
                {
                    WriteLine($"    Father's name {acc.Father.Name}");
                }

                if (acc.Mather != null)
                {
                    WriteLine($"    Mather's name {acc.Mather.Name}");
                }

                if (acc.Friends.Count > 0)
                {
                    WriteLine("    Friends: [");
                    foreach (Person items in acc.Friends)
                    {
                        WriteLine($"    {items.Name}");
                    }
                    WriteLine("    ]");
                }
            }
            WriteLine();
        }
        public static Profession ChooseProfession()
        {
            WriteLine("    Please choice profession:");
            WriteLine();
            string[] profession = Enum.GetNames(typeof(Profession));
            for(int i = 1; i<profession.Length;i++)
            {
                WriteLine($"     {i} - {profession[i]}");
            }
            WriteLine("     Your choice  --->   ");
            WriteLine();
            int profValue = Convert.ToInt32(ReadLine());
            Profession prof = (Profession)profValue;
            WriteLine("    Profession selected successfully");
            return prof;
        }
        public static void ChangeProfession()
        {

            ShouProfile();
            Person acc = ProfileSelection();
            //WriteLine("    Please choice Profile:");
            //WriteLine();
            //int userChoice = Convert.ToInt32(ReadLine());
            //Person account = Accounts[userChoice];
            //WriteLine();
            //WriteLine("    Profile selected successfully");
            Profession prof = ChooseProfession();
            acc.Prof = prof;
        }
        public static Person ProfileSelection()
        {
            WriteLine("    Please choice Profile:");
            WriteLine();
            int userChoice = Convert.ToInt32(ReadLine());
            Person account = Accounts [userChoice];
            WriteLine();
            WriteLine("    Profile selected successfully");
            return account;
        }
        public static void IndicateFather()
        {
            WriteLine("    For whom do we choose a father?");
            // Выыодим профили
            WriteLine();
            ShouProfile();
            WriteLine();

            // Выбираем кому указываем отца
            //WriteLine("     Your choice  --->   ");
            //int accIndx = Convert.ToInt32(ReadLine());
            //Person accaunt = Accounts[accIndx];
            //WriteLine("     Profile selected.");
            Person accaunt = ProfileSelection();
            WriteLine();

            // Выбираем отца
            WriteLine("    Who is the father?");
            //WriteLine("     Your choice  --->   ");
            //int fatherIndx = Convert.ToInt32(ReadLine());
            //Person accfather = Accounts[fatherIndx];
            //WriteLine("     Profile selected.");
            Person accfather = ProfileSelection();
            WriteLine();

            accaunt.Father = accfather;
            WriteLine($"     {accfather.Name} is now father for {accaunt.Name}.");
            WriteLine();
        }
        public static void IndicateMother()
        {
            WriteLine("    For whom do we choose a mather?");
            // Выыодим профили
            WriteLine();

            ShouProfile();
            WriteLine();

            // Выбираем кому указываем маму
            //WriteLine("     Your choice  --->   ");
            //int accIndx = Convert.ToInt32(ReadLine());
            //Person accaunt = Accounts[accIndx];
            //WriteLine("     Profile selected.");
            Person accaunt = ProfileSelection();
            WriteLine();

            // Выбираем маму
            WriteLine("    Who is the mather?");
            //WriteLine("     Your choice  --->   ");
            //int motherIndx = Convert.ToInt32(ReadLine());
            //Person accmather = Accounts[motherIndx];
            //WriteLine("     Profile selected.");
            Person accmather = ProfileSelection();
            WriteLine();

            accaunt.Mather = accmather;
            WriteLine($"     {accmather.Name} is now father for {accaunt.Name}.");
            WriteLine();
        }
        public static void AddFriendProfile()
        {
            WriteLine("    Add Friend Profile.");
            WriteLine();
            WriteLine("    Who do we add friends to?");
            WriteLine();
            ShouProfile();
            //WriteLine("    Please choice Profile:");
            //WriteLine();
            //int userChoice = Convert.ToInt32(ReadLine());
            //Person account = Accounts[userChoice];
            //WriteLine();
            //WriteLine("    Profile selected successfully");
            Person accaunt = ProfileSelection();
            WriteLine();
            WriteLine("    Friend Profile.");
            WriteLine();
            //WriteLine("    Please choice Profile:");
            //WriteLine();
            //int userChoiceFr = Convert.ToInt32(ReadLine());
            //Person accFriend = Accounts[userChoiceFr];
            //WriteLine();
            //WriteLine("    Profile selected successfully");
            Person accFriend = ProfileSelection();
            accaunt.Friends.Add(accFriend);
            WriteLine();
            WriteLine("    Friend profile added.");
        }
        public static void DeleteFriend()
        {
            WriteLine("    Delete Friend Profile.");
            WriteLine();
            WriteLine("    Who are we deleting a friend ?");
            WriteLine();
            ShouProfile();
            Person accaunt = ProfileSelection();
            WriteLine();
            WriteLine("    Friend Profile.");
            WriteLine(); 
            //string[] friends = List.GetNames(typeof(Friends));
            //for (int i = 0; i < friends.Length; i++)
            //{
            //    WriteLine($"     {i} - {friends[i]}");
            //}
            //WriteLine("     Your choice  --->   ");
            //WriteLine();
            for(int i = 1; i < accaunt.Friends.Count; i++)
            {
                WriteLine($"     {i} - {accaunt}");
            }
            //foreach (Person items in accaunt.Friends)
            //{
            //    WriteLine($"    {items.Name}");
            //}
            int delFriend = Convert.ToInt32(ReadLine());

            accaunt.Friends.RemoveAt(delFriend);
            WriteLine();
            WriteLine("    Friend account deleted.");
        }
    }
}
