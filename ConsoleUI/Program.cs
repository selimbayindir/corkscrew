﻿// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;



//ProductNameList();

static void ProductNameList()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    // ProductManager productManager = new ProductManager(new InMemoryProductDal());
    foreach (var item in productManager.GetByUnitPrice(18, 55)) //GetList() , GetAllByCategoryId(1) , 
    {
        Console.WriteLine(item.ProductName + "============================>" + item.UnitPrice);
    }
}

//OrderGetAll();

static void OrderGetAll()
{
    OrderManager orderManager = new OrderManager(new EfOrderDal());
    foreach (var item in orderManager.GetAll())

    {
        Console.WriteLine(item.OrderId + item.CustomerId + item.OrderDate);
    }
}

//GetById(10248);

static void GetById(int fisno)
{
    OrderManager orderManager = new OrderManager(new EfOrderDal());

    var customer4 = orderManager.GetById(fisno);

    Console.WriteLine(customer4.OrderId + " " + customer4.OrderDate + " " + customer4.ShipCity);
}

GetByCustomerId();

static void GetByCustomerId()
{
    OrderManager orderManager = new OrderManager(new EfOrderDal());

    ///var customer4 = orderManager.GetByCustomerId("VINET");
    foreach (var item in orderManager.GetByCustomerId("VINET"))

    {
        Console.WriteLine(item.OrderId + item.CustomerId + item.OrderDate);
    }

}

