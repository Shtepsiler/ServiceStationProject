using ClientPartBLL.DTO.Requests;
using ClientPartBLL.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPartBLL.Services.Interfaces
{
    public interface IModelService
    {
        Task<IEnumerable<ModelResponse>> GetAllAsync();
        Task<ModelResponse> GetByIdAsync(int id);
        Task PostAsync(ModelRequest model);
        Task DeleteByIdAsync(int id);
        Task UpdateAsync(int id, ModelRequest model);


    }
}
