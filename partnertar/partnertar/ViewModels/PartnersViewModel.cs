using partnertar.Models;
using partnertar.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertar.ViewModels
{
    class PartnersViewModel : IPartnersViewModel
    {
        public IEnumerable<Partner> Partners { get; set; }
    }
}
