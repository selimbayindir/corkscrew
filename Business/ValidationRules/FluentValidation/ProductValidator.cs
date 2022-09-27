using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(P => P.CategoryId == 1);//10 DAN BÜYÜK EŞİT OLMALI KLATEGORİ 1 DE 
            //Olmayan bir şeyler yazalım 
            //urunler a ile 
            RuleFor(P => P.ProductName).Must(StartWithA).WithMessage("Urunler A harfi ile başlamalı"); //StartWithA bunu biz yazacağız
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
            
        }
        //pRODUCT managerdayız
    }
}
