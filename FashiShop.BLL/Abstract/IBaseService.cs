using System.Collections.Generic;
using FashiShop.Core.Entity;

namespace FashiShop.BLL.Abstract
{
    public interface IBaseService<T> 
    where T:BaseEntity
    {
        void Insert(T entity);
        void Remove(T entity);
        void Update(T entity);
        T GetById(int entityID);
        ICollection<T> GetAll();  
    }
}