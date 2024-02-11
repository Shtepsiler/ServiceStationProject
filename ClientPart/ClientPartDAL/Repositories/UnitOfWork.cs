using System.Threading.Tasks;
using ClientPartDAL.Data;
using ClientPartDAL.Entities;
using ClientPartDAL.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;

namespace ClientPartDAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        protected readonly ServiceStationDContext databaseContext;
        public UserManager<Client> _ClientManager { get; }
        public SignInManager<Client> _SignInManager { get; }
        public IJobRepository _JobRepository { get; }
        public IModelRepository _ModelRepository { get; }
        public IManagerRepository _ManagerRepository { get; }
        public ITokenRepository _TokenRepository { get; }
        public IMechanicRepository _MechanicRepository { get; }
        public async Task SaveChangesAsync()
        {
            await databaseContext.SaveChangesAsync();
        }

        public UnitOfWork(
            ServiceStationDContext databaseContext,
            UserManager<Client> clientManager,
            SignInManager<Client> signInManager,
            IJobRepository jobRepository,
            IModelRepository modelRepository,
            IManagerRepository managerRepository,
            ITokenRepository tokenRepository,
            IMechanicRepository mechanicRepository
          )
        {
            this.databaseContext = databaseContext;
            _ClientManager = clientManager;
            _SignInManager = signInManager;
            _JobRepository = jobRepository;
            _ModelRepository = modelRepository;
            _ManagerRepository = managerRepository;
            _TokenRepository = tokenRepository;
            _MechanicRepository = mechanicRepository;
        }
    }
}
