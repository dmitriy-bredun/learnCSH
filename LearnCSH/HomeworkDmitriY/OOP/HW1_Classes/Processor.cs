using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDmitriy.OOP.HW1_Classes
{
    class Processor
    {
        public string companyName;
        public double frequency;
        public int countOfCores;
        public int cache;

        public Processor(string companyN, double frequency, int cores, int cache)
        {
            companyName = companyN;
            this.frequency = frequency;
            countOfCores = cores;
            this.cache = cache;
        }
    }
}
