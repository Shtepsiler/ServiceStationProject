using MechanicPartWEB.GraphQl.Common.Exceptions;
using MechanicPartDAL;
using MechanicPartDAL.Entitys;
namespace MechanicPartWEB.GraphQl.Payloads.MechanicTasks
{
    public class ChangeMechanicsTaskPayload : MechanicTasksPayloadBase
    {
        public ChangeMechanicsTaskPayload(UserError error)
              : base(new[] { error })
        {
        }

        public ChangeMechanicsTaskPayload(MechanicsTasks task) : base(task)
        {
        }

        public ChangeMechanicsTaskPayload(IReadOnlyList<UserError> errors) : base(errors)
        {
        }
    }
}
