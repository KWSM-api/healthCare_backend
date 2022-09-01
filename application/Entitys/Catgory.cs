using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    internal class Catgory: Base
    {
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }


        public Catgory()
        {
            Doctors = new HashSet<Doctor>();
        }
    }
}
