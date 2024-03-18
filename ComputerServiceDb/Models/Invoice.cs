using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceDb.Models
{
    public class Invoice:BaseModel
    {
        public int ServiceRecordId { get; set; }
        public ServiceRecord ServiceRecord { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? TotalPrice { get; set; }

    }
}
