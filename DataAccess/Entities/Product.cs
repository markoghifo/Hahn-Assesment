using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Product : EntityAuditableModel
    {
        public Product()
        {
            Features = new HashSet<ProductFeatures>();
        }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int Quantity { get; set; }
        //public bool IsDeleted { get; set; }
        public bool IsAvailable { get; set; }
        public virtual BrandModel? Model { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public ICollection<ProductFeatures>? Features { get; set; }

        public int? ParentId { get; set; }
        public Product Parent { get; set; }


        public ICollection<Product> Variants { get; set; }
    }

    //[Keyless]
    public class ProductFeatures: EntityAuditableModel
    {
        public string Title { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
