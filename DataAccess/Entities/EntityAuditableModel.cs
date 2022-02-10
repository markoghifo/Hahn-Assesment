using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class EntityAuditableModel
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; } = "Test";
        public string? LastUpdatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DateDeleted { get; set; }
        public string? DeletedBy { get; set; }
    }
}
