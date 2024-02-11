using ClientPartDAL.Entities;

namespace ClientPartDAL.Repositories.Contracts
{
    public interface IJobRepository : IGenericRepository<Job>
    {
        Task<IEnumerable<Job>> GetByClientIdAsync(int id);

    }

}
