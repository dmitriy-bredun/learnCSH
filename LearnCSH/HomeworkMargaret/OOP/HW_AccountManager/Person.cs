using System;
using System.Collections.Generic;
using System.Text;

using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW_AccountManager
{
    class Person
    {
        public string _name;
        public int _age;
        public Profession _prof;
        public Person _myFather;
        public Person _myMother;
        public List<Person> _friends;

        //public int Age
        //{
        //    get { return _age; }
        //    set
        //    {
        //        if (value < 1)
        //        {
        //            Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
        //        }

        //        else
        //        {
        //            _age = value;
        //        }
                    
        //    }
        //}

        //public Profession Profession
        //{
        //    get { return Profession; }
        //    set
        //    {
        //        if (Enum.IsDefined(typeof(Profession), value))
        //        {
        //            Profession = value;
        //        }
        //        else
        //        {
        //            Profession = Profession.Unemployed;
        //        }
        //    }
        //}
        public Person(string name, int age, Profession prof)
        {
            _name = name;
            _age = age;
            _prof = prof;

            _friends = new List<Person>();
        }

        public void ShowInfo()
        {
            Print($"Name: {_name}");
            Print($"Age: {_age}");
            Print($"Profession: {_prof}");

            if (_myFather != null)
            {
                Print($"Father's name: {_myFather._name}");
            }

            if (_myMother != null)
            {
                Print($"Mother's name: {_myMother._name}");
            }

            if (_friends.Count > 0)
            {
                Print($"Has more than 0 friends");
            }
            else
            {
                Print($"Has no friends");
            }
            Space();
        }
    }
}
