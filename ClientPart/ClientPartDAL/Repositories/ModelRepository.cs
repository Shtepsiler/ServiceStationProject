using ClientPartDAL.Data;
using ClientPartDAL.Entities;
using ClientPartDAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace ClientPartDAL.Repositories
{
    public class ModelRepository : GenericRepository<Model>, IModelRepository
    {
        public ModelRepository(ServiceStationDContext databaseContext)
            : base(databaseContext)
        {
        }


        public async Task<Model> GetModelByName(string name) => await table.Where(p => p.Name == name).FirstOrDefaultAsync();
    }
}
