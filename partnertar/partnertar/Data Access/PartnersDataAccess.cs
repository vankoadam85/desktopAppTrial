using partnertar.Data_Access.Interfaces;
using partnertar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertar.Data_Access
{
    public class PartnersDataAccess : IPartnersDataAccess
    {
        public IEnumerable<Partner> GetAll()
        {
            throw new NotImplementedException();
        }

        public Partner GetByID(long ID)
        {
            throw new NotImplementedException();
        }
    }
}
