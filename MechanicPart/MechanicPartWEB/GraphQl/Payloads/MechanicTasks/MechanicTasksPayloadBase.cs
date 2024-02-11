using MechanicPartDAL;
using MechanicPartDAL.Entitys;
using MechanicPartWEB.GraphQl.Common.Exceptions;
using MechanicPartWEB.GraphQl.Common;

namespace MechanicPartWEB.GraphQl.Payloads.MechanicTasks
{
    public class MechanicTasksPayloadBase : Payload
    {
        protected MechanicTasksPayloadBase(MechanicsTasks mechanicsTasks)

        {
            MechanicsTasks = mechanicsTasks;
        }

        protected MechanicTasksPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public MechanicsTasks? MechanicsTasks { get; }
    }
}
