using ClientPartBLL.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPartBLL.Services.Interfaces
{
    public interface IManagerService
    {
        Task<IEnumerable<ManagerResponse>> GetAllAsync();
        Task<ManagerResponse> GetByIdAsync(int id);

    }
}
