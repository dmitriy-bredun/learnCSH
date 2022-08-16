using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSerg.OOP.HW_AccountManager
{
    
    class Person
    {
        public string Name;
        public int Age;
        public Profession Prof;
        Person MyFather;
        Person MyMather;
        List<Person> Friends = new List<Person>();

        public Person (string name, int age, Profession prof)
        {
            Name = name;
            Age = age;
            Prof = prof;
        }
    }
}
