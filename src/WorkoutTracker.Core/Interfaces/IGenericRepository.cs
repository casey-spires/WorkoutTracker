using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetByIdAsync(int id);
        IEnumerable<T> GetAllAsync();
        IEnumerable<T> FindAsync(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void AddAsync(T entity);
        void Remove(T entity);

    }
}
