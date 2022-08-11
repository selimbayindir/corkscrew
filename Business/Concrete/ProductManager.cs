﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
            {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min , decimal max)
        {
            var price= _productDal.GetAll(p=>p.UnitPrice >= min && p.UnitPrice <= max);

            return price.OrderByDescending(x=>x.UnitPrice).ToList(); ///MyChallege
        }

        public List<Product> GetList()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetMyList()
        {
            return _productDal.MyList();
        }
    }
}
