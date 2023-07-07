using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.common
{
    public interface IRepositoryBase<T>
    { 
        void Create(T entity);
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void Delete(T entity);
    }
}
