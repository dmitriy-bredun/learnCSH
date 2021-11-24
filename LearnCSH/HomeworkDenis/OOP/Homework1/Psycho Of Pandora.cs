using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDenis.OOP.Homework1
{
    enum Status
    {
        DEAD,
        ALIVE
    }
    internal class Psycho_Of_Pandora
    {
        public string Name { get; }
        public int Reward { get; }
        public int ID { get; } = _counter;
        private static int _counter = 0;
        public string Location { get; }
        public string Profession { get; }
        public Status Status { get; set; }

        public Psycho_Of_Pandora(string name, int reward, string location, string profession, Status status)
        {
            Name = name;
            Reward = reward;
            Location = location;
            Profession = profession;
            Status = status;
            _counter++;
        }
    }
}