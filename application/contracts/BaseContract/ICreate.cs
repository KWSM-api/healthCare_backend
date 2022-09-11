using application.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.contracts.Repositories
{
    public interface ICreate<TEntity>
    {

      TEntity Create(TEntity obj);

    }
}
