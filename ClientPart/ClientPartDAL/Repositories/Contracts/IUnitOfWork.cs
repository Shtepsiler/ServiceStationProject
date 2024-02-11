using System.Threading.Tasks;
using ClientPartDAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace ClientPartDAL.Repositories.Contracts
{
    public interface IUnitOfWork
    {

        UserManager<Client> _ClientManager { get; }
        SignInManager<Client> _SignInManager { get; }
        IJobRepository _JobRepository { get; }
        IManagerRepository _ManagerRepository { get; }
        IModelRepository _ModelRepository { get; }
        ITokenRepository _TokenRepository { get; }
        IMechanicRepository _MechanicRepository { get; }
        Task SaveChangesAsync();
    }
}
