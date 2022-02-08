using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Courier : EntityAuditableModel
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<CourierContact>? Contacts { get; set; }
    }

    //[Keyless]
    public class CourierContact : EntityAuditableModel
    {
        public int CourierId { get; set; }
        public virtual Courier Courier { get; set; }
        public ContactType Type { get; set; }
        public string Value { get; set; } = string.Empty;
    }

    public enum ContactType
    {
        Email, Phone
    }
}
