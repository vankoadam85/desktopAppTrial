using partnertarServer.Models;
using partnertarServer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace partnertarServer.Repositories
{
    public class OrganisationRepository : IOrganisationRepository
    {
        public Task<IEnumerable<Organisation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Organisation> GetByIDAsync(long ID)
        {
            throw new NotImplementedException();
        }
    }
}