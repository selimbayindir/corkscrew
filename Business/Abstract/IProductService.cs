using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService<T>
    {
        List<Product> Get();
        List<Product> GetAllByCategoryId(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtre vermesende olur

        //List<Product> GetByUnitPrice(decimal min, decimal max);

        //List<ProductDetailDto> GetProductDetails();
        //Product GetById(int productId);
        //IResult Add(Product product);

    }
}
