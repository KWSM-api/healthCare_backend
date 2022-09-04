using application.Entitys.Constent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    public class Attendance : BaseModel
    {
      

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; }
    }
}
