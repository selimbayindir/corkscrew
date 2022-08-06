using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
               new(1,"Nescafe Express Vanilya",6,"10",18,101),
               new(2,"Nescafe Express Cafe Choco",5,"50",18,200),
               new(3,"Laptop",17,"10,",18,99),
               new(4,"Mouse",9,"100",180,199),
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetByCategory(int id)
        {
            var categoryIdList = _products.Where(p => p.CategoryId == id).ToList();

            return categoryIdList;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName= product.ProductName;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnitsInStock= product.UnitsInStock;
            productToUpdate.UnitsInStock= product.UnitsInStock;
        }


    }
}
