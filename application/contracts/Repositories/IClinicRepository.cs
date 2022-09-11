using application.contracts.Repositories;
using application.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.contracts
{
    public interface IClinicRepository: ICreate<Clinic> , IUpdate<Clinic>, IDelete, IGetById<Clinic>, IGetAll<Clinic>
    {

    }
}
