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
            var data = _order.GetById(a => a.ID == entity.ID);
            _order.Delete(data);
        }
        public ICollection<Order> GetAll()
        {
            return _order.GetAll();
        }

        public Order GetById(int entityID)
        {
            return _order.GetById(a => a.ID == entityID);
        }

        public void Insert(Order entity)
        {
            _order.Add(entity);
        }

        public void Update(Order entity)
        {
            _order.Update(entity);
        }
    }
}