using System;
using System.Collections.Generic;
using System.Text;

using Lessons.Tools;

namespace Lessons
{
    class Account
    {
        public string login;
        public string password;

        public string _name;
        public string _surname;
        public int age;
        public string email;

        public static int counter;

        public Account(string login = null, string password = null, string name = null, string surname = null, int age = 0, string email = null)
        {
            this.login = login;
            this.password = password;

            _name = name;
            _surname = surname;

            this.age = age;
            this.email = email;

            counter++;
        }
    }


    class CurrentLessonMargaret
    {
        public static void Start()
        {
            Account user1 = new Account("dbre", "12345", "Dmitriy", "Bredun", 27, "dbre@isd.dp.ua");
            Account user2 = new Account("msol", "54321", "Margaret", "Sologub", 23, "sologubmargaret@gmail.com");



            int countOfObjects = Account.counter;

            Account acc = new Account(name: "name", age: 12);
            Show(1, 2, z3: 3);
        }

        public static void Show(int x, int y, int z1 = 0, int z2 = 0, int z3 = 0)
        {

        }
    }
}
