using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Core.DTOs
{
    public class ProductAllPropertyDto : IDto
    {

        public int CategoryName { get; set; }
        public int BrandName { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public DateTime ModelYear { get; set; }
        public decimal Discount { get; set; }
        public string CategoryDescription { get; set; }
    }
}