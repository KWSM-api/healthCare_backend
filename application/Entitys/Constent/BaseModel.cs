using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Entitys.Constent
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
