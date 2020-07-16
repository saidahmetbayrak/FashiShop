using System.Collections.Generic;
using FashiShop.BLL.Abstract;
using FashiShop.DAL.Abstract;
using FashiShop.Model;

namespace FashiShop.BLL.Concrete
{
    public class CategoryService : ICategoryService
    {
        ICategoryDAL _category;
        public CategoryService(ICategoryDAL category)
        {
         _category = category;    
        }
        public void Remove(Category entity)
        {
            var data = _category.GetById(a => a.ID == entity.ID);
            _category.Delete(data);
        }
        public ICollection<Category> GetAll()
        {
            return _category.GetAll();
        }

        public Category GetById(int entityID)
        {
            return _category.GetById(a => a.ID == entityID);
        }

        public void Insert(Category entity)
        {
            _category.Add(entity);
        }

        public void Update(Category entity)
        {
            _category.Update(entity);
        }
    }
}