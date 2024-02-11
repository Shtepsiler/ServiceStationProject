using MechanicPartWEB.GraphQl.Common.Exceptions;
using MechanicPartDAL;
using MechanicPartDAL.Entitys;
namespace MechanicPartWEB.GraphQl.Payloads.Mechanics
{
    public class LoginPayload : MechanicPayloadBase
    {
        public LoginPayload(UserError error)
   : base(new[] { error })
        {
        }

        public LoginPayload(Mechanic mechanic) : base(mechanic)
        {
        }

        public LoginPayload(IReadOnlyList<UserError> errors) : base(errors)
        {
        }
    }
}
