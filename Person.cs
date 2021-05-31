using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBlock4
{
    public abstract class Person
    {
        public Person(SalaryRate rate)
        {
            Rate = rate;
        }
        protected SalaryRate Rate { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public double Hours { get; set; }
        public abstract string Department { get; }
        public abstract double hoursRateEployee { get; }
        public double Salary => hoursRateEployee * Hours;
    }
}
