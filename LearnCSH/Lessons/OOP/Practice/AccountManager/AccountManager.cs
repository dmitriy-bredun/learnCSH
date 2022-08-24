using Lessons.OOP.Lessons.Lesson1_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.OOP.Practice.AccountManager
{
    public class AccountManager
    {

        public static void Start()
        {
            //Person tom = new Person("Tom", 41, Profession.ZSUWarrior);
            //Person martha = new Person("Martha", 39, Profession.Teacher);
            //Person bruce = new Person("Bruce", 19, Profession.Engineer);
            //Person selina = new Person("Selina", 18, Profession.Sniper);
            //bruce.Father = tom;
            //bruce.Mother = martha;
            //bruce.Friends.Add(selina);
            //bruce.PrintToConsole();

            List<Person> profiles = new List<Person>();
            
            int userChoice = -1;
            do
            {
                Menu();
                userChoice =  Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        CreateNewProfile(profiles);
                        break;
                    case 2:
                        ChangeProfession(profiles);
                        break;
                    case 3:
                        SetFatherToProfile(profiles);
                        break;
                    case 4:
                        break;
                    case 5:
                        AddFriendToProfile(profiles);
                        break;
                    case 6:
                        break;
                    case 7:
                        ShowAllProfiles(profiles);
                        break;
                    case 0:
                        break;

                    default:
                        Console.WriteLine("WTF??????");
                        break;
                }

            } while (userChoice != 0);

            Console.WriteLine("Good bye, cowboy");
        }

        public static void Menu()
        {
            Console.WriteLine(" - - - M E N U - - - ");
            Console.WriteLine(" 1 - CreateNewProfile");
            Console.WriteLine(" 2 - ChangeProfession");
            Console.WriteLine(" 3 - SetFatherToProfile");
            Console.WriteLine(" 4 - SetMotherToProfile");
            Console.WriteLine(" 5 - AddFriendToProfile");
            Console.WriteLine(" 6 - RemoveFriendFromProfile");
            Console.WriteLine(" 7 - ShowAllProfiles");   
            Console.WriteLine(" 0 - Exit");   
            Console.Write(" --- >");   

        }

        public static void CreateNewProfile(List<Person> profiles)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Profession prof = ChooseProfession();
            
            Person newProfile = new Person(name, age, prof);

            profiles.Add(newProfile);
        }

        public static void ChangeProfession(List<Person> profiles)
        {
            // 1 - вывести все профили
            ShowAllProfiles(profiles);

            // 2 - выбрать 1
            Console.Write("Выберите какой нибудь профиль --> ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Person account = profiles[userChoice];
            Console.WriteLine("Профиль успешно выбран! ");

            // 3 - показать все профессии
            // 4 - выбрать какую то одну профессию\
            Profession prof = ChooseProfession();

            // Для профиля, который выбрал пользователь - изменить профессию
            account.Profession = prof;
        }

        public static void SetFatherToProfile(List<Person> profiles)
        {
            // 1 - вывести все профили
            ShowAllProfiles(profiles);

            // 2 - выбрать 1-й, для кого устанавливаем отца
            Console.Write("Выберите профиль, которому установится отец --> ");
            int accountIndx = Convert.ToInt32(Console.ReadLine());
            Person account = profiles[accountIndx];
            Console.WriteLine("Профиль успешно выбран! ");

            // 3 - выбрать профиль отца
            Console.Write("Выберите профиль отца --> ");
            int fatherIndex = Convert.ToInt32(Console.ReadLine());
            Person fatherAccount = profiles[fatherIndex];
            Console.WriteLine("Профиль отца успешно выбран! ");

            account.Father = fatherAccount;
            Console.WriteLine($"{fatherAccount.Name}, теперь является отцом {account.Name}");
        }

        public static void SetMotherToProfile()
        {

        }

        public static void AddFriendToProfile(List<Person> profiles)
        {
            // 1 - отобразить профили
            ShowAllProfiles(profiles);

            // 2 - выбрать профиль, которому будем добавлять друга
            Console.Write("Выберите профиль, будем добавлять друга --> ");
            int accountIndx = Convert.ToInt32(Console.ReadLine());
            Person account = profiles[accountIndx];
            Console.WriteLine("Профиль успешно выбран! ");


            // 3 - выбрать профиль друга
            Console.Write("Выберите профиль друга --> ");
            int friendAccountIndx = Convert.ToInt32(Console.ReadLine());
            Person friendAccount = profiles[friendAccountIndx];
            Console.WriteLine("Профиль успешно выбран! ");

            account.Friends.Add(friendAccount);
            Console.WriteLine($"{friendAccount.Name}, теперь является другом {account.Name}");

        }

        public static void RemoveFriendFromProfile()
        {
            // 1 - показать все профили
            // 2 - выбрать профиль, у которого хотим удалить друга
            // 3 - показать всех друзей этого профиля
            // 4 - удалить конкретного друга из списка друзей
        }

        public static void ShowAllProfiles(List<Person> profiles)
        {
            int index = 0;
            foreach (Person item in profiles)
            {
                Console.WriteLine();
                Console.WriteLine($" P R O F I L E     #{index++}");
                item.PrintToConsole();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static Profession ChooseProfession()
        {
            Console.WriteLine("Выберите профессию: ");
            string[] professions = Enum.GetNames<Profession>(); // получаем все имена значений перечисления
            for (int i = 0; i < professions.Length; i++)     // проходимся по всем этим именам
            {
                Console.WriteLine($"{i} - {professions[i]}");  // и печатаем каждую профессию в консоль
            }

            Console.Write("---> ");
            int profValue = Convert.ToInt32(Console.ReadLine());
            Profession prof = (Profession)profValue;

            return prof;
        }
    }
}
