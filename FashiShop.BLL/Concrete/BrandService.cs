using System.Collections.Generic;
using FashiShop.BLL.Abstract;
using FashiShop.DAL.Abstract;
using FashiShop.Model;

namespace FashiShop.BLL.Concrete
{
    public class BrandService : IBrandService
    {
        IBrandDAL _brand;
        public BrandService(IBrandDAL brand)
        {
            _brand = brand;
        }
        public void Remove(Brand entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Brand> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Brand GetById(int entityID)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Brand entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Brand entity)
        {
            throw new System.NotImplementedException();
        }
    }
}