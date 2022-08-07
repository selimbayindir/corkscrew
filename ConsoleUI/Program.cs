// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;



ProductNameList();

static void ProductNameList()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    // ProductManager productManager = new ProductManager(new InMemoryProductDal());
    foreach (var item in productManager.GetByUnitPrice(18, 20))
    {
      Console.WriteLine(item.ProductName+item.CategoryId);
    }
}

