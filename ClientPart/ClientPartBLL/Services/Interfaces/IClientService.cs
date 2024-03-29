﻿using ClientPartBLL.DTO.Requests;
using ClientPartBLL.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPartBLL.Services.Interfaces
{
    public interface IClientService
    {
        // Task AddPhoneNumber();


        Task<ClientResponse> GetClientByName(string name);
        Task RewokeRefreshToken(string clientname, string token);

        Task<JwtResponse> RenewAccesToken(string refreshtoken);

        Task UpdateAsync(string name, ClientRequest client);
        Task DeleteAsync(string name);




    }
}
