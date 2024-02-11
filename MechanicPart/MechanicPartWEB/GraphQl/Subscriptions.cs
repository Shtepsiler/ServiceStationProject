using MechanicPartWEB.GraphQl.DataLoader;
using MechanicPartDAL;
using MechanicPartDAL.Entitys;
namespace MechanicPartWEB.GraphQl
{
    public class Subscriptions
    {
        [Subscribe]
        [Topic]
        public Task<Job> OnJobStatusUpdateAsync(
            [EventMessage] int jobId,
            JobByIdDataLoader lobById,
            CancellationToken cancellationToken) =>
            lobById.LoadAsync(jobId, cancellationToken);



        [Subscribe]
        [Topic]
        public Task<MechanicsTasks> OnTaskStatusUpdateAsync(
            [EventMessage] int taskid,
            MechanicTaskByIdDataLoader TaskById,
            CancellationToken cancellationToken) =>
            TaskById.LoadAsync(taskid, cancellationToken);







    }
}
