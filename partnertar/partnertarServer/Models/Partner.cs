using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertarServer.Models
{
    public abstract class Partner
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string TaxID { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
