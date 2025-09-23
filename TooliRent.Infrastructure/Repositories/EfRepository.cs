using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TooliRent.Domain.Interfaces;
using TooliRent.Infrastructure.Persistence;

namespace TooliRent.Infrastructure.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _db;

        public EfRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            await Task.CompletedTask;
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAsync(Expression<Func<T, bool>>? predicate = null)
        {
            IQueryable<T> query = _db.Set<T>();
            if (predicate != null)
                query = query.Where(predicate);

            return await query.ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
            await Task.CompletedTask;
        }

        public Task<int> SaveChangesAsync()
        {
            return _db.SaveChangesAsync();
        }
    }
}

