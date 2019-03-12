using partnertar.Data_Access.Interfaces;
using partnertar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace partnertar.ViewModels
{
    public class PartnersViewModel
    {
        public IPartnersDataAccess DataAccess { get; set; }
        public IEnumerable<Partner> Partners { get; set; }

        public PartnersViewModel(IPartnersDataAccess dataAccess)
        {
            DataAccess = dataAccess;
            Partners = GetPartnersAsync().Result;
        }

        public async Task<IEnumerable<Partner>> GetPartnersAsync()
        {
            return await DataAccess.GetAllAsync();
        }
    }
}
