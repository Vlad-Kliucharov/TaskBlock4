using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBlock4
{
    class Accountant : Person
    {
        public Accountant(SalaryRate rate) : base(rate) { }
        public override double hoursRateEployee => Rate.AcountantRate;

        public override string Department => "Accontant";
    }
}
