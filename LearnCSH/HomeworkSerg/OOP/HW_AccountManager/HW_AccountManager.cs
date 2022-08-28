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
                    WriteLine("    Friends:");
                    WriteLine("    [");
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
            for(int i = 0; i<profession.Length;i++)
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

            Person accaunt = ProfileSelection();
            WriteLine();

            // Выбираем отца
            WriteLine("    Who is the father?");

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

            Person accaunt = ProfileSelection();
            WriteLine();

            // Выбираем маму
            WriteLine("    Who is the mather?");

            Person accmather = ProfileSelection();
            WriteLine();

            accaunt.Mather = accmather;
            WriteLine($"     {accmather.Name} is now mother for {accaunt.Name}.");
            WriteLine();
        }
        public static void AddFriendProfile()
        {
            WriteLine("    Add Friend Profile.");
            WriteLine();
            WriteLine("    Who do we add friends to?");
            WriteLine();
            ShouProfile();

            Person accaunt = ProfileSelection();
            WriteLine();

            WriteLine("    Friend Profile.");
            WriteLine();

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
            
            //for (int i = 0; i < accaunt.Friends.Count; i++)
            //{
            //    WriteLine($"     {i} - {accaunt.Friends[i].Name}");
            //}

            int somePersonIndex = 0;
            foreach (Person items in accaunt.Friends)
            {
                WriteLine($"    {somePersonIndex++} - {items.Name}");
            }
            WriteLine("    Who to remove?");

            int delFriend = Convert.ToInt32(ReadLine());

            accaunt.Friends.RemoveAt(delFriend);
            WriteLine();
            WriteLine("    Friend account deleted.");
            WriteLine();
            ShouProfile();
            WriteLine();
        }
    }
}
