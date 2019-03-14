using partnertarServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertarServer.Dtos
{
    public class GetPartnersDto
    {
        public IEnumerable<Organisation> Organisations { get; set; }
        public IEnumerable<PrivatePerson> PrivatePersons { get; set; }
    }
}
