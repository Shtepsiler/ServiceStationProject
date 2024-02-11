using MechanicPartDAL;
using MechanicPartDAL.Entitys;
using MechanicPartWEB.GraphQl.Common.Exceptions;
using MechanicPartWEB.GraphQl.Common;
namespace MechanicPartWEB.GraphQl.Payloads.Mechanics
{
    public class MechanicPayloadBase : Payload
    {
        protected MechanicPayloadBase(Mechanic mechanic)
        {
            Mechanic = mechanic;
        }

        protected MechanicPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Mechanic? Mechanic { get; }
    }
}
