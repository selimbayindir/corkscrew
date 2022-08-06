using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public Product()
        {

        }
        public Product(int productId, string productName, int categoryId, string quantityPerUnit, decimal unitPrice, short unitsInStock)
        {
            ProductId = productId;
            ProductName = productName;
            CategoryId = categoryId;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
