using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.contracts.Repositories
{
    public interface IRepository<Entity>
    {
        Entity Create(Entity obj);
        void Delete(int id);
        ICollection<Entity> GetAll();
        Entity GetById(int id);
        Entity Update(Entity obj);
    }
}
