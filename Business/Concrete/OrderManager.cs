using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetAll()
        {
            return  _orderDal.GetAll();
        }

        public List<Order> GetByCustomerId(string id)
        {
            return _orderDal.GetAll(p=>p.CustomerId==id);
        }

        public Order GetById(int id)
        {
            return _orderDal.Get(p => p.OrderId == id);

        }
    }
}
