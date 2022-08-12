﻿
using Core.DataAccess.EntityFramework;
using Core.DataAccess.EntityFramework.Repository;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
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
        public List<Product> MyList()
        {
            throw new NotImplementedException();
        }
    }
}
