using Lessons.Tools;
using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace Lessons.OOP.Lesson1_Classes
{
    class Lesson1_Classes
    {
        public static void Start()
        {
            // - - - - -   № 1   - - - - -
            Write("Введите логин: ");
            string login = Console.ReadLine();

            Write("Введите пароль: ");
            string pass = Console.ReadLine();

            Write("Введите имя: ");
            string name = Console.ReadLine();
            
            Write("Введите фамилия: ");
            string lastName = Console.ReadLine();
            
            Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Profile user = new Profile(login, pass, name, lastName, age);


            // - - - - -   № 2   - - - - -
            Profile user2 = new Profile();
            user2.login = "zloyder";
            user2.password = "299950";
            user2.firstName = "Dimka";
            user2.lastName = "Peters";
            user2.age = 29;


            ShowInfo(user);

            ShowInfo(user2);
        }

        public static void ShowInfo(Profile userInfo)
        {
            WriteLine();
            WriteLine($"- - - - - - - - - - - - - - - - - - - - - -");
            WriteLine($"Информация о пользователе {userInfo.login}:");
            WriteLine($"Имя: \t\t {userInfo.firstName}");
            WriteLine($"Фамилия: \t {userInfo.lastName}");
            WriteLine($"Возраст: \t {userInfo.age}");
            WriteLine($"- - - - - - - - - - - - - - - - - - - - - -");
            WriteLine();

        }
    }
}
