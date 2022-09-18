using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("helloapi")]
       public string Get()
        {
            return "Merhaba";
        }
        [HttpGet("getmytempleproducts")]
        public List<Product> GetMyTempleProductsList()
        {
            return new List<Product>
            {
                new Product(){ProductId=1,ProductName="Elma"},
                new Product(){ProductId=2,ProductName="Armut"},
                new Product(){ProductId=3,ProductName="Muz"},
            };
        }

        /// <summary>
        /// 
        /// </summary>
        [HttpGet("getproducts")]
        public  IActionResult GetProducts()
        {
            /// IProductService productService = new ProductManager(new EfProductDal());
            var result =_productService.GetList();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            /// IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult GetAddedProducts(Product product)
        {
            var result = _productService.Add(product);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return  BadRequest(result);
        }








    }
}
