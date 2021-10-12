using HekaLojisticsApp.DataAccess.Abstract.Base;
using HekaLojisticsApp.Entities.Abtract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LinqKit;

namespace HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Repositories.Base
{
    public class EntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    {

        protected readonly DbContext _context;

        public EntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

      
        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return entity;
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return   _context.Set<TEntity>().Any(predicate);
        }

        public int Count(Expression<Func<TEntity, bool>> predicate = null)
        {
            return  (predicate == null ? _context.Set<TEntity>().Count() : _context.Set<TEntity>().Count(predicate));

        }

        public void Delete(TEntity entity)
        {
           _context.Set<TEntity>().Remove(entity); 
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            query = query.Where(predicate);

            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return   query.AsNoTracking().SingleOrDefault();
        }

        public IList<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return   query.AsNoTracking().ToList();
        }

        public IList<TEntity> GetAllV2(IList<Expression<Func<TEntity, bool>>> predicates, IList<Expression<Func<TEntity, object>>> includeProperties)

        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (predicates != null && predicates.Any())
            {
                foreach (var predicate in predicates)
                {
                    query = query.Where(predicate); // isActive==false && isDeleted==true
                }
            }

            if (includeProperties != null && includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return   query.AsNoTracking().ToList();
        }

        public IQueryable<TEntity> GetAsQueryable()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public TEntity GetV2(IList<Expression<Func<TEntity, bool>>> predicates, IList<Expression<Func<TEntity, object>>> includeProperties)
        {


            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (predicates != null && predicates.Any())
            {
                foreach (var predicate in predicates)
                {
                    query = query.Where(predicate); // isActive==false && isDeleted==true
                }
            }

            if (includeProperties != null && includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return   query.AsNoTracking().SingleOrDefault();
        }

        public IList<TEntity> SearchAsync(IList<Expression<Func<TEntity, bool>>> predicates, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (predicates.Any())
            {
                var predicateChain = PredicateBuilder.New<TEntity>();
                foreach (var predicate in predicates)
                {
                    // predicate1 && predicate2 && predicate3 && predicateN
                    // predicate1 || predicate2 || predicate3 || predicateN
                    predicateChain.Or(predicate);
                }

                query = query.Where(predicateChain);
            }

            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return   query.AsNoTracking().ToList();
        }

        public TEntity Update(TEntity entity)
        {
          _context.Set<TEntity>().Update(entity);
            return entity;
        }
    }
}
