using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBlock4
{
    public class SalaryRate
    {
        public double BossRate { get; set; }
        public double EmployeeRate { get; set; }
        public double AcountantRate { get; set; }

        public SalaryRate()
        {
            BossRate = 100;
            EmployeeRate = 15;
            AcountantRate = 40;
        }
    }
}
