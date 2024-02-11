using ClientPartDAL.Entities;
using System.IdentityModel.Tokens.Jwt;

namespace ClientPartBLL.Factories.Interfaces
{
    public interface IJwtSecurityTokenFactory
    {
        JwtSecurityToken BuildToken(Client client);
    }
}
