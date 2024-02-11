using MechanicPartWEB.GraphQl.Common.Exceptions;
using MechanicPartDAL.Entitys;
namespace MechanicPartWEB.GraphQl.Payloads.MechanicTasks
{
    public class AddMechanicTaskPayload : MechanicTasksPayloadBase
    {
        public AddMechanicTaskPayload(UserError error)
              : base(new[] { error })
        {
        }

        public AddMechanicTaskPayload(MechanicsTasks task) : base(task)
        {
        }

        public AddMechanicTaskPayload(IReadOnlyList<UserError> errors) : base(errors)
        {
        }
    }
}
