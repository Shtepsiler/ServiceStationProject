using MechanicPartDAL.Entitys;
using MechanicPartWEB.GraphQl.Common.Exceptions;
using MechanicPartWEB.GraphQl.Common;
namespace MechanicPartWEB.GraphQl.Payloads.Jobs
{
    public class JobPayloadBase : Payload
    {
        protected JobPayloadBase(Job job)
        {
            Job = job;
        }

        protected JobPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Job? Job { get; }
    }
}
