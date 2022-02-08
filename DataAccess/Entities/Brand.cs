using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Brand: EntityAuditableModel
    {
        public Brand()
        {
            Models = new HashSet<BrandModel>();
        }

        public string Name { get; set; } = string.Empty;
        public ICollection<BrandModel> Models { get; set; }
    }

    //[Keyless]
    public class BrandModel : EntityAuditableModel
    {
        //public virtual Category? Category { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public string ModelNumber { get; set; } = string.Empty;
        public ICollection<string>? Features { get; set; }
    }
}
