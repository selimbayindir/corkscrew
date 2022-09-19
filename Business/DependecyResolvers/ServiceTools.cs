using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependecyResolvers
{
    public static class ServiceTools
    {
        /// <summary>
        /// IOC CONTAİNER ŞU ANDA KULLANILMIYOR
        /// </summary>
        /// <param name="services"></param>
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDal, EfOrderDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();


        }
    }
}
