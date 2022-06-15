using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDmitriy.OOP.HW1_Classes
{
    class Processor
    {
        public double frequency;
        public string companyName;
        public int countOfCores;
        public int cache;

        public Processor(double frequency, string companyN, int cores, int cache)
        {
            this.frequency = frequency;
            companyName = companyN;
            countOfCores = cores;
            this.cache = cache;
        }
    }
}
