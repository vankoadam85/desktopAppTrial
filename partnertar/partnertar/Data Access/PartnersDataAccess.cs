using partnertar.Data_Access.Interfaces;
using partnertar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace partnertar.Data_Access
{
    public class PartnersDataAccess : IPartnersDataAccess
    {
        private static readonly HttpClient _client = new HttpClient();
        private static readonly string _serverUrl = Environment.GetEnvironmentVariable("partnertarServerUrl");

        public async Task<IEnumerable<Partner>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Partner> GetByIDAsync(long ID)
        {
            throw new NotImplementedException();
        }
    }
}
