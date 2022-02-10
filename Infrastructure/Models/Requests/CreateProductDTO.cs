using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Requests
{
    public class CreateProductDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int? BrandModelId { get; set; }
        public ICollection<ProductFeature>? Features { get; set; }
        public ICollection<string>? SerialNumbers { get; set; }
    }
}
