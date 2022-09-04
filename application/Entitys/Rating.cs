using application.Entitys.Constent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{

    public class Rating: BaseModel
    {
       
        public string Message { get; set; }
        public int Value { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
