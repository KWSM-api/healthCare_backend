using application.Entitys.Constent;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    public class Appointment: BaseModel
    {
    
        public DateTime AppointmentDate { get; set; }
        public StatusAppointment Status { get; set; }
        public int DoctorId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
