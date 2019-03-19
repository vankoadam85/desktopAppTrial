using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertarServer.Models
{
    [Table("Organisations")]
    public class Organisation : Partner
    {
        public long Value { get; set; }
        public string TaxID { get; set; }
    }
}
