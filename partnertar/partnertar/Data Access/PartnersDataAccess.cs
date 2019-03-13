using Newtonsoft.Json;
using partnertar.Data_Access.Interfaces;
using partnertar.Dtos;
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
            var requestUrl = new StringBuilder(_serverUrl)
                .Append("/api/partners");
            var response = await _client.GetAsync(requestUrl.ToString());
            if (response.IsSuccessStatusCode)
            {
                return await ResponseToPartnerCollectionAsync(response);
            }
            return null;
        }

        private async Task<IEnumerable<Partner>> ResponseToPartnerCollectionAsync(HttpResponseMessage response)
        {
            var partners = new List<Partner>();
            var deserializedResponse =  JsonConvert.DeserializeObject<GetPartnersDto>(await response.Content.ReadAsStringAsync());
            partners.AddRange(deserializedResponse.Organisations);
            partners.AddRange(deserializedResponse.PrivatePersons);
            return partners;
        }

        public async Task<Partner> GetByIDAsync(long ID)
        {
            var requestUrl = new StringBuilder(_serverUrl)
                .AppendFormat("/api/partners/{0}", ID);
            var response = await _client.GetAsync(requestUrl.ToString());
            throw new NotImplementedException();
        }
    }
}
