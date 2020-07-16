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
           var data= _brand.GetById( a => a.ID == entity.ID);
            _brand.Delete(data);
        }

        public ICollection<Brand> GetAll()
        {
            return _brand.GetAll();
        }

        public Brand GetById(int entityID)
        {
            return _brand.GetById(a => a.ID == entityID);
        }

        public void Insert(Brand entity)
        {
            _brand.Add(entity);
        }

        public void Update(Brand entity)
        {
            _brand.Update(entity);
        }
    }
}