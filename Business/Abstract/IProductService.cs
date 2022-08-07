using Entities.Concrete;
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
        List<Product> GetList();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetAllByCategoryName(string name); //control 
        List<Product> GetByUnitPrice(decimal max,decimal min);//control
        List<Product> GetMyList();

    }
}
