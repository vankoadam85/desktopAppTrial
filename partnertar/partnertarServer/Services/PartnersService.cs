using partnertarServer.Dtos;
using partnertarServer.Models;
using partnertarServer.Repositories.Interfaces;
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
        private readonly IPartnerRepository _repository;

        public PartnersService(IPartnerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Partner>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public Task<Partner> GetByIDAsync(long ID)
        {
            throw new NotImplementedException();
        }
    }
}