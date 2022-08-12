
using Core.DataAccess.EntityFramework;
using Core.DataAccess.EntityFramework.Repository;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepositoryBase<Product, NortwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetproductDetailDtos()
        {
            using (NortwindContext context =new NortwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock,

                             };
                return result.ToList();


            }
            //Join 
        }

        public List<Product> MyList()
        {
            throw new NotImplementedException();
        }
    }
}
