using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FashiShop.Core.Entity;

namespace FashiShop.Core.DAL.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
    where TEntity : BaseEntity, new()
    where TContext : DbContext, new()
    {
        TContext context =EFSingletionContext<TContext>.Instance;
        public void Add(TEntity entity)
        {
            context.Entry(entity).State=EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Entry(entity).State=EntityState.Deleted;
            context.SaveChanges();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter==null)
            {
                return context.Set<TEntity>().ToList();
            }
            else
            {
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State=EntityState.Modified;
            context.SaveChanges();
        }
    }
}