using System;
using System.Collections.Generic;
using System.Linq;


namespace TaskBlock4
{
    public class Employee : Person
    {
        public Employee(SalaryRate rate) : base(rate) { }
        public override double hoursRateEployee => Rate.EmployeeRate;
        public override string Department => "Employee";
    }
}

