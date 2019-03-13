using partnertar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertar.Dtos
{
    class GetPartnersDto
    {
        public IEnumerable<Organisation> Organisations { get; set; }
        public IEnumerable<PrivatePerson> PrivatePersons { get; set; }
    }
}
