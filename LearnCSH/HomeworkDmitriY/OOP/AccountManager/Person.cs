using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.ConsoleColor;
using static System.Convert;

namespace HomeworkDmitriy.OOP.AccountManager
{
    public class Person
    {
        public string Name;
        public int Age;
        public Profession Profession;

        public Person Father;
        public Person Mother;
        public List<Person> Friends;

        public Person(string name, int age, Profession profession)
        {
            Name = name;
            Age = age;
            Profession = profession;

            Friends = new List<Person>();
        }

        public void PrintToConsole()
        {
            WriteLine($" Profile info - - - - -");
            WriteLine($" Name: {Name}");
            WriteLine($" Age: {Age}");
            WriteLine($" Profession: {Profession}");

            if (Father != null)
                WriteLine($" Father's name: {Father.Name}");

            if (Mother != null)
                WriteLine($" Mother's name: {Mother.Name}");
            
            if (Friends.Count > 0)
            {
                Write($" Friends: [");
                foreach (Person item in Friends)
                {
                    Write($" {item.Name} ");
                }
                WriteLine($"]");
            }
        }
    }
}