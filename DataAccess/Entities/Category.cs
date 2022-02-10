using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Category : EntityAuditableModel
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<string>? Features { get; set; }
        //public ICollection<CategoryFeatureOptions>? Features { get; set; }
        public string? Description { get; set; }
    }

    //[Keyless]
    //public class CategoryFeatureOptions: EntityAuditableModel
    //{
    //    //public virtual ICollection<Category> Categories { get; set; }
    //    //public string Name { get; set; } = String.Empty;
    //    public ICollection<string>? Options { get; set; }
    //}
}
