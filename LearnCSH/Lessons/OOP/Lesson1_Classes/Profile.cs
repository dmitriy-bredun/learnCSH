using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.OOP.Lesson1_Classes
{
    class Profile
    {
        public string login;
        public string password;

        public string firstName;
        public string lastName;
        public int age;

        public Profile()
        {
            login = "login";
            password = "password";
        }

        public Profile(string login, string pass, string firstN, string lastN, int age)
        {
            this.login = login;
            password = pass;
            firstName = firstN;
            lastName = lastN;
            this.age = age;
        }
    }
}
