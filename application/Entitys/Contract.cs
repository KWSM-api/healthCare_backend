using application.Entitys.Constent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    public class Contract : BaseModel
    {

        public decimal HourSalary { get; set; }
        public int MonthlyWorkingHours { get; set; }
    }
}
