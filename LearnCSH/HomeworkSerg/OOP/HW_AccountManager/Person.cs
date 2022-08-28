using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.OOP.HW_AccountManager
{
    public class Person
    {
        public string Name;
        public int Age;
        public Profession Prof;
        public Person Father;
        public Person Mather;
        public List<Person> Friends = new List<Person>();

        public Person (string name, int age, Profession prof)
        {
            Name = name;
            Age = age;
            Prof = prof;
        }
        //public void ShouProfile()
        //{
        //    int index = 1;
        //    foreach (Person acc in Accounts)
        //    {
        //        WriteLine();
        //        WriteLine($" Profile #{index++}");
        //        WriteLine();
        //        WriteLine($" Name: {acc.Name};");
        //        WriteLine();
        //        WriteLine($" Age: {acc.Age};");
        //        WriteLine();
        //        WriteLine($" Profession: {acc.Prof}.");
        //        WriteLine();

        //        if (Father != null)
        //        {
        //            WriteLine($"    Father's name {Father.Name}");
        //        }
        //    }
        //}
    }
}
