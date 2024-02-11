
using ClientPartBLL.DTO.Requests;
using ClientPartBLL.DTO.Responses;

namespace ClientPartBLL.Services.Interfaces
{
    public interface IJobService
    {
        Task DeleteByIdAsync(int id);
        Task UpdateAsync(int id, JobRequest job);
        Task PostAsync(JobRequest job);
        Task<JobResponse> GetByIdAsync(int id);
        Task<IEnumerable<JobResponse>> GetAllAsync();
        Task<IEnumerable<ClientsJobsResponse>> GetAllClientsJobsAsync(int clientId);
        Task PostNewJobAsync(NewJobRequest job);

    }
}
