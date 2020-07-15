using System.Collections.Generic;
using FashiShop.BLL.Abstract;
using FashiShop.DAL.Abstract;
using FashiShop.Model;
namespace FashiShop.BLL.Concrete
{
    public class OrderService : IOrderService
    {
        IOrderDAL _order;
        public OrderService(IOrderDAL order)
        {
            _order = order;
        }
        public void Remove(Order entity)
        {
            throw new System.NotImplementedException();
        }
        public ICollection<Order> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Order GetById(int entityID)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Order entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new System.NotImplementedException();
        }
    }
}