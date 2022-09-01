﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    internal class Attendance: Base
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Doctor DoctorId { get; set; }

        public Doctor Doctor { get; set; }
    }
}
