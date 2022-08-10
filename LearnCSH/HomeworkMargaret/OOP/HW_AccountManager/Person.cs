using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMargaret.OOP.HW_AccountManager
{
    class Person
    {
        private string Name;
        private int Age;
        Profession Prof;
        Person MyFather;
        Person MyMother;
        List<Person> friends;

        public Person(string name, int age, Profession prof)
        {
            name = Name;
            age = Age;
            prof = Prof;
        }
    }
}
