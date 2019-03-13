using partnertar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertar.ViewModels.Interfaces
{
    interface IPartnersViewModel
    {
        IEnumerable<Partner> Partners { get; set; }

        Task UpdateAsync();
    }
}
