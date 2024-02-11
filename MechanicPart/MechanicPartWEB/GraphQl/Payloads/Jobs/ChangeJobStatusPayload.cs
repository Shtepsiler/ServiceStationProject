using MechanicPartWEB.GraphQl.Common.Exceptions;
using MechanicPartDAL.Entitys;
namespace MechanicPartWEB.GraphQl.Payloads.Jobs
{
    public class ChangeJobStatusPayload : JobPayloadBase
    {
        public ChangeJobStatusPayload(UserError error)
    : base(new[] { error })
        {
        }

        public ChangeJobStatusPayload(Job job) : base(job)
        {
        }

        public ChangeJobStatusPayload(IReadOnlyList<UserError> errors) : base(errors)
        {
        }
    }
}
