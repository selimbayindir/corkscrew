using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns
{
    public static class ValidationTool
    {
        public static void dw (IValidator validator,object entity)//ben buraya entity  dto ekleyebilirim object geçiyorum
        {

            var context = new ValidationContext<object>(entity);
            //ProductValidator productValidator = new ProductValidator(); IValidator bunu hallediyor
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            //var context = new ValidationContext<Product>(product);
            //ProductValidator productValidator = new ProductValidator();
            //var result = productValidator.Validate(context);
            //if (!result.IsValid)
            //{
            //    throw new ValidationException(result.Errors);
            //}
        }

    }
}
