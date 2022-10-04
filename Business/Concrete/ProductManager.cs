using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Aspect.Autofac.AspectInterceptorSelector;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        //[LogAspect] --->AOP
        //[Validate]
        //[RemoveCache]
        //[Transaction ]
        //[Performance]
        [ValidationAspect(typeof(ProductValidator))] //Add Metedunu doğrula ProductValidator Kullanarak
        public IResult Add(Product product) //İMZAYA UYDUR
        {
            //if (product.ProductName.Length < 2)
            //{
            //    return new ErrorResult(Messages.ProductNameInvalid);
            //}

            //Fluent  Generic hale getiriyoruz.

            //var context = new ValidationContext<Product>(product);
            //ProductValidator productValidator = new ProductValidator();
            //var result = productValidator.Validate(context);
            //if (!result.IsValid)
            //{
            //    throw new ValidationException(result.Errors);
            //}
                             ///  ValidationTool.dw(new ProductValidator(), product); // =>[ValidationAspect(typeof(ProductValidator))]
            _productDal.Add(product);

            /// return new Result(true,"Urun Eklendi");
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(
                _productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(
                _productDal.Get(p => p.ProductId == id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            var price = _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);

            return new SuccessDataResult<List<Product>>(price.OrderByDescending(x => x.UnitPrice).ToList()); ///MyChallege
        }

        public IDataResult<List<Product>> GetList()
        {
            /// return _productDal.GetAll();
            ///  return new DataResult<List<Product>>(_productDal.GetAll(),true,"Urunler Listelendi");
            if (DateTime.Now.Hour == 10)
            {
                return new ErrorDataResult<List<Product>>(

                    _productDal.GetAll(), Messages.MaintenanceTime);

            }
            return new SuccessDataResult<List<Product>>(

                _productDal.GetAll(), Messages.ProductList);


        }

        public List<Product> GetMyList()
        {
            return _productDal.MyList();
        }

        public IDataResult<List<ProductDetailDto>> GetProductDtos()
        {
            if (DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<ProductDetailDto>>((Messages.MaintenanceTime));

            }
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetproductDetailDtos());
        }
    }
}
