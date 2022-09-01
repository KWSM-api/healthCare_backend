using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    internal class Clinic : Base
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Iamge { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public ICollection<Doctor> Doctors { get; set; }

        public Clinic()
        {
            Doctors = new HashSet<Doctor>();
        }
    }
}
