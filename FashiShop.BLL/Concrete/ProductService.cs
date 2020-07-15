using System.Collections.Generic;
using FashiShop.BLL.Abstract;
using FashiShop.DAL.Abstract;
using FashiShop.Model;
namespace FashiShop.BLL.Concrete
{
    public class ProductService : IProductService
    {
        IProductDAL _product;
        public ProductService(IProductDAL product)
        {
            _product = product;
        }
        public void Remove(Product entity)
        {
            throw new System.NotImplementedException();
        }
        public ICollection<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int entityID)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}