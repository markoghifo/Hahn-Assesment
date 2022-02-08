using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class RequestDetail: EntityAuditableModel
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int RequestId { get; set; }
        public virtual Request Request { get; set; }
        public int Quantity { get; set; }
        public bool Fulfilled { get; set; }
        public DateTime? FulfilledDate { get; set; }
        public bool Shipped { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
