using Heysem.WebApiDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.DataAccess
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntitiyRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()

    {

        public void Add(TEntity entity)
        {

            using (var context = new TContext())
            {

                context.Add(entity);
                context.SaveChanges();
            }
           
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {

            using (var context = new TContext())
            {

                return context.Set<TEntity>().SingleOrDefault(filter);
            }
            

        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {

            using (var context = new TContext())
            {

                if (filter == null)
                {
                    return context.Set<TEntity>().ToList();
                }
                return context.Set<TEntity>().Where(filter).ToList();
            }
              

        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
