using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Request : EntityAuditableModel
    {
        public string RequesterId { get; set; } = string.Empty;
        public string RequestNumber { get; set; } = string.Empty;
        public DateTime? RequiredDate { get; set; }
        public int CourierId { get; set; }
        public bool Fulfilled { get; set; }
        public DateTime? FulfilledDate { get; set; }
        public bool Canceled { get; set; }
        public DateTime? CancelDate { get; set; }
        public ICollection<RequestDetail> RequestDetails { get; set; }
    }
}
