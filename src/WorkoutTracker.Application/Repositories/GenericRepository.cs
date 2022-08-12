using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WorkoutTracker.Core.Interfaces;
using WorkoutTracker.Infrastructure.Data;

namespace WorkoutTracker.Application.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly WorkoutTrackerContext _context;
        public GenericRepository(WorkoutTrackerContext context) {
            _context = context;
        }
        public async Task<T?> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);
        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
     
        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression) => await _context.Set<T>().Where(expression).ToListAsync();
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

    }
}
