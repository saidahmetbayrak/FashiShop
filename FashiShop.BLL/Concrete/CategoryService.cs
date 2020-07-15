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
            throw new System.NotImplementedException();
        }
        public ICollection<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Category GetById(int entityID)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}