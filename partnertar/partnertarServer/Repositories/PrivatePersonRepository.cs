using partnertarServer.Models;
using partnertarServer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace partnertarServer.Repositories
{
    public class PrivatePersonRepository : IPrivatePersonRepository
    {
        public Task<IEnumerable<PrivatePerson>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PrivatePerson> GetByIDAsync(long ID)
        {
            throw new NotImplementedException();
        }
    }
}