using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBlock4
{
    class Boss : Person
    {
        public Boss(SalaryRate rate) : base(rate) { }
        public override double hoursRateEployee => Rate.BossRate;

        public override string Department => "Boss";
    }
}
