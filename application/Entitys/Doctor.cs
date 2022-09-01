using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    internal class Doctor : Base
    {
        public string Image { get; set; }
        public int Experience { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int ClinicId { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public Clinic Clinic { get; set; }
        public Catgory Catgory { get; set; }
        public User User { get; set; }
        public ICollection<Attendance> Attendances { get; set; }


        public Doctor()
        {
            Attendances = new HashSet<Attendance>();
        }
    }
}
