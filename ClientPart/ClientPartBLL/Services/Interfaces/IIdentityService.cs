using ClientPartBLL.DTO.Requests;
using ClientPartBLL.DTO.Responses;
using System.Threading.Tasks;

namespace ClientPartBLL.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<JwtResponse> SignInAsync(ClientSignInRequest request);

        Task<JwtResponse> SignUpAsync(ClientSignUpRequest request);


        //    Task SignUpWihtoutjvtAsync(ClientSignUpRequest request);
    }
}
