using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Requests
{
    public class CreateCategoryDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public ICollection<string>? Features { get; set; }
        //public ICollection<CategoryFeatureOptions>? Features { get; set; }
        public string? Description { get; set; }
    }
}
