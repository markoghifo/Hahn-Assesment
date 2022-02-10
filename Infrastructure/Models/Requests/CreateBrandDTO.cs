using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Requests
{
    public class CreateBrandDTO
    {
        [Required]
        public string Name { get; set; }
        public ICollection<CreateBrandModel> Models { get; set; }
    }

    public class CreateBrandModel
    {
        [Required]
        public string ModelNumber { get; set; }
        public ICollection<string>? Features { get; set; }
    }
}
