using ClientPartDAL.Data;
using ClientPartDAL.Entities;
using ClientPartDAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPartDAL.Repositories
{
    public class ManagerRepository : GenericRepository<Manager>, IManagerRepository
    {
        public ManagerRepository(ServiceStationDContext databaseContext)
            : base(databaseContext)
        {
        }
    }
}
