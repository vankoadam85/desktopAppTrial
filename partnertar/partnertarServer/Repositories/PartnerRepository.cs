using partnertarServer.Data;
using partnertarServer.Models;
using partnertarServer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace partnertarServer.Repositories
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly PartnertarContext _context;

        public PartnerRepository(PartnertarContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Partner>> GetAllAsync()
        {
            return await _context.Partners.Include(p => p.Addresses).ToListAsync();
        }

        public Task<Partner> GetByIDAsync(long ID)
        {
            throw new NotImplementedException();
        }
    }
}