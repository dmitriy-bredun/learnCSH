using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.OOP.Practice.AccountManager
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
            Console.WriteLine($" Profile info - - - - -");
            Console.WriteLine($" Name: {Name}");
            Console.WriteLine($" Age: {Age}");
            Console.WriteLine($" Profession: {Profession}");

            if (Father != null)
            {
                Console.WriteLine($" Father's name: {Father.Name}");
            }

            if (Mother != null)
            {
                Console.WriteLine($" Mother's name: {Mother.Name}");
            }
            
            if (Friends.Count > 0)
            {
                Console.Write($" Friends: [");
                foreach (Person item in Friends)
                {
                    Console.Write($" {item.Name} ");
                }
                Console.WriteLine($"]");
            }
        }
    }
}
