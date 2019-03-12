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
        [Dependency]
        public IPartnersDataAccess DataAccess { get; set; }
        public List<Partner> Partners { get; set; }

        public PartnersViewModel()
        {
            Partners = (List<Partner>)GetPartners();
        }

        public IEnumerable<Partner> GetPartners()
        {
            return DataAccess.GetAll();
        }
    }
}
