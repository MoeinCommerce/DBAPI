using DatabaseApi.Models;
using DatabaseApi.Repositories.EntityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface IStorageRepository : IEntityBaseRepository<Storage>
    {
    }
}
