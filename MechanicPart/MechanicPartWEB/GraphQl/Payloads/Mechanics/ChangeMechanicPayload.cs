using MechanicPartWEB.GraphQl.Common.Exceptions;
using MechanicPartDAL;
using MechanicPartDAL.Entitys;
namespace MechanicPartWEB.GraphQl.Payloads.Mechanics
{
    public class ChangeMechanicPayload : MechanicPayloadBase
    {
        public ChangeMechanicPayload(UserError error)
    : base(new[] { error })
        {
        }

        public ChangeMechanicPayload(Mechanic mechanic) : base(mechanic)
        {
        }

        public ChangeMechanicPayload(IReadOnlyList<UserError> errors) : base(errors)
        {
        }
    }
}
