using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        //List<Product> GetList();
        //List<Product> GetAllByCategoryId(int id);
        //List<Product> GetByUnitPrice(decimal min,decimal max);//control //test
        //List<Product> GetMyList();
        //List<ProductDetailDto> GetProductDtos();
        //IResult Add(Product product);
        
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min,decimal max);//control //test
        ///List<Product> GetMyList();
        IDataResult<List<ProductDetailDto>> GetProductDtos();
        IDataResult<Product> GetById(int id);
        IResult Add(Product product);


    }
}
