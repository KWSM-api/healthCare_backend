﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    internal class Contract : Base
    {
        public int Id { get; set; }
        public decimal HourSalary { get; set; }
        public int MonthlyWorkingHours { get; set; }
    }
}
