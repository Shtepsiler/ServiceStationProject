using ClientPartDAL.Entities;

namespace ClientPartDAL.Repositories.Contracts
{
    public interface IModelRepository : IGenericRepository<Model>
    {
        Task<Model> GetModelByName(string name);
    }

}
