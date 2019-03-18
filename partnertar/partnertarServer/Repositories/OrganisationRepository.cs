using partnertarServer.Models;
using partnertarServer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace partnertarServer.Repositories
{
    public class PartnerRepository : IPartnerRepository
    {
        public Task<IEnumerable<Partner>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Partner> GetByIDAsync(long ID)
        {
            throw new NotImplementedException();
        }
    }
}