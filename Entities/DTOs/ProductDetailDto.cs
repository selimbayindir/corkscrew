using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto :IDto
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
