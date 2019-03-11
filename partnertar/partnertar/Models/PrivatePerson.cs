using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertar.Models
{
    class PrivatePerson : Partner
    {
        public DateTime BirthDate { get; set; }
        public string BirthLocation { get; set; }
        public string MothersName { get; set; }
    }
}
