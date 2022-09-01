using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.ConsoleColor;
using static System.Convert;

namespace HomeworkDmitriy.OOP.AccountManager
{
    public class SocialMenu
    {
        public static void Start()
        {
            List<Person> Accounts = new List<Person>();

            do
            {
                WriteLine("   ///   Социальная сеть <Glooda>   ///   ");
                WriteLine();

                WriteLine("         1 - Добавить новый профиль");
                WriteLine("         2 - Изменить профессию");
                WriteLine("         3 - Указать отца");
                WriteLine("         4 - Указать маму");
                WriteLine("         5 - Добавить друга");
                WriteLine("         6 - Убрать друга");
                WriteLine("         0 - Жмакни что б выйти");
                WriteLine();
                Write("         ");


                WriteLine();

                int Choice = ToInt32(ReadLine());
                switch (Choice)
                {
                    case 1: AddProfile(Accounts); break;
                    case 2: ChangeProfesion(Accounts); break;
                    case 3: Father(Accounts); break;
                    case 4: Mother(Accounts); break;
                    case 5: AddFriend(Accounts); break;
                    case 6: DeleteFriend(Accounts); break;

                    default:
                        Write("Ты не то жмакнул :О");
                        WriteLine();
                        WriteLine();
                        break;
                }
            } while (true);
        }

        public static void AddProfile(List<Person> Accounts)
        {
            Write("Имя: ");
            string name = ReadLine();

            Write("Возраст: ");
            int age = ToInt32(ReadLine());

            Profession prof = ChooseProfession();
            Person newProfile = new Person(name, age, prof);

            Accounts.Add(newProfile);
            WriteLine($"Профиль {newProfile.Name} создан");
        }

        public static void ChangeProfesion(List<Person> Accounts)
        {
            // вывести все профили
            ShowProfiles(Accounts);

            // выбрать 1
            Write("Выберите 1 профиль: ");
            Person account = SelectProfile(Accounts);

            // показать все профессии
            // выбрать какую то одну профессию\
            Profession prof = ChooseProfession();

            // Для профиля, который выбрал пользователь - изменить профессию
            account.Profession = prof;
        }
        
        public static void Father(List<Person> Accounts)
        {
            // 1 - вывести все профили
            ShowProfiles(Accounts);

            // выбираем 1-й, для кого устанавливаем отца

            Write("Выберите профиль, которому установится отец --> ");
            Person account = SelectProfile(Accounts);

            // выбираем профиль отца
            Write("Выберите профиль отца --> ");
            Person fatherAccount = SelectProfile(Accounts);

            account.Father = fatherAccount;
            WriteLine($"{fatherAccount.Name}, теперь является отцом {account.Name}");
        }

        

        public static void Mother(List<Person> Accounts)
        {
            // показать все профили
            ShowProfiles(Accounts);

            // выбираем 1-й, для кого устанавливаем мать
            Write("Выберите профиль, которому установится мать --> ");
            Person account = SelectProfile(Accounts);

            // выбираем профиль матери
            Write("Выберите профиль матери --> ");
            Person motherAccount = SelectProfile(Accounts);

            account.Mother = motherAccount;
            WriteLine($"{motherAccount.Name}, теперь является мамой {account.Name}");
        }

        public static void AddFriend(List<Person> Accounts)
        {
            // 1 - отобразить профили
            ShowProfiles(Accounts);

            // 2 - выбрать профиль, которому будем добавлять друга
            Write("Выберите профиль, будем добавлять друга --> ");
            Person account = SelectProfile(Accounts);


            // 3 - выбрать профиль друга
            Write("Выберите профиль друга --> ");
            Person friendAccount = SelectProfile(Accounts);

            account.Friends.Add(friendAccount);
            WriteLine($"{friendAccount.Name}, теперь является другом {account.Name}");
        }

        public static void DeleteFriend(List<Person> Accounts)
        {
            // 1 - показать все профили
            ShowProfiles(Accounts);

            // 2 - выбрать профиль, у которого хотим удалить друга
            Write("Выберите профиль, в которо мбудем удалять друга --> ");
            Person account = SelectProfile(Accounts);

            // 3 - показать всех друзей этого профиля
            int personFr = 0;
            foreach (Person ident in account.Friends)
            {
                WriteLine($"{personFr++} - {ident.Name}");
            }
            
            WriteLine("Кого удаляем?");
            int friendDelIndex = ToInt32(ReadLine());
            account.Friends.RemoveAt(friendDelIndex);

            WriteLine();
            WriteLine("Друг удалён");
            WriteLine();

            // 4 - удалить конкретного друга из списка друзей
        }

        public static void ShowProfiles(List<Person> profiles)
        {
            int index = 0;
            foreach (Person i in profiles)
            {
                WriteLine();
                WriteLine($" P R O F I L E     #{index++}");
                i.PrintToConsole();
                WriteLine();
                WriteLine();
            }
        }
        public static Profession ChooseProfession()
        {
            WriteLine("Выберите профессию: ");
            string[] professions = Enum.GetNames(typeof(Profession)); // получаем все имена значений перечисления
            for (int i = 0; i < professions.Length; i++)     // проходимся по всем этим именам
            {
                WriteLine($"{i} - {professions[i]}");  // и печатаем каждую профессию в консоль
            }

            Write("---> ");
            int profValue = ToInt32(ReadLine());
            Profession prof = (Profession)profValue;

            return prof;
        }
        public static Person SelectProfile(List<Person> accounts)
        {
            int accountIndx = ToInt32(ReadLine());
            Person account = accounts[accountIndx];
            WriteLine("Профиль успешно выбран! ");
            return account;
        }
    }
}