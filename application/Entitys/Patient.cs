using application.Entitys.Constent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    public class Patient : BaseModel
    {

        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Appointment> Appointments { get; set; }


        public Patient()
        {
             Appointments = new HashSet<Appointment>();
        }
    }
}
