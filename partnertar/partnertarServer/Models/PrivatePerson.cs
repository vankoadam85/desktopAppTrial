using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertarServer.Models
{
    [Table("PrivatePersons")]
    public class PrivatePerson : Partner
    {
        public DateTime BirthDate { get; set; }
        public string BirthLocation { get; set; }
        public string MothersName { get; set; }
        public int TaxNumber { get; set; }
    }
}
