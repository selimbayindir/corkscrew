// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;



ProductNameList();

static void ProductNameList()
{
    ProductManager productManager = new ProductManager(new InMemoryProductDal());

    // ProductManager productManager = new ProductManager(new InMemoryProductDal());
    foreach (var item in productManager.GetAllByCategoryId(2)) // GetAllByCategoryId(2)  //GetByUnitPrice(50,100)
    {
        Console.WriteLine(item.ProductName);
    }


}

