using HekaLojisticsApp.Entities.Abtract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HekaLojisticsApp.DataAccess.Abstract.Base
{

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        T Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties); // var kullanici = repository.GetAsync(k=>k.Id==15);
        T GetV2(IList<Expression<Func<T, bool>>> predicates, IList<Expression<Func<T, object>>> includeProperties);
        // if(isActive==true) predicates.Add()

        IList<T> GetAll(Expression<Func<T, bool>> predicate = null,
            params Expression<Func<T, object>>[] includeProperties);
        IList<T> GetAllV2(IList<Expression<Func<T, bool>>> predicates, IList<Expression<Func<T, object>>> includeProperties);

        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);

        IList<T> SearchAsync(IList<Expression<Func<T, bool>>> predicates,
            params Expression<Func<T, object>>[] includeProperties);
        bool Any(Expression<Func<T, bool>> predicate);
        int Count(Expression<Func<T, bool>> predicate = null);

        IQueryable<T> GetAsQueryable();
    }


}
