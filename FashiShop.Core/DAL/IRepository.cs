using System.Linq.Expressions;
using System;
using System.Collections;
using System.Collections.Generic;
using FashiShop.Core.Entity;

namespace FashiShop.Core.DAL
{
    public interface IRepository<TEntity> where TEntity:BaseEntity
    {
         void Add(TEntity entity);
         void Update(TEntity entity);
         void Delete(TEntity entity);
         ICollection<TEntity> GetAll(Expression<Func<TEntity,bool>>filter=null);
        /// <summary>
        /// Get metodu için içine lambda sorgusu yaılabilecek bir parametre oluşturmuş olduk
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
         TEntity GetById(Expression<Func<TEntity,bool>> filter);

    }
}