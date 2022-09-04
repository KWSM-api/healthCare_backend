using application.Entitys.Constent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys
{
    public class Category : BaseModel
    {


        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }


        public Category()
        {
            Doctors = new HashSet<Doctor>();
        }
    }
}
