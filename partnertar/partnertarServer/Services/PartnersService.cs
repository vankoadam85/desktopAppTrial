using partnertarServer.Dtos;
using partnertarServer.Models;
using partnertarServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace partnertarServer.Services
{
    public class PartnersService : IPartnersService
    {
        public Task<GetPartnersDto> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Partner> GetByIDAsync(long ID)
        {
            throw new NotImplementedException();
        }
    }
}