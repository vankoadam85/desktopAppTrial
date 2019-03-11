using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertar.Models
{
    abstract class Partner
    {
        public string Name { get; set; }
        public string TaxID { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
