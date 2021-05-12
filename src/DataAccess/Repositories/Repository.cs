using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.DataModels;

namespace DataAccess.Repositories
{
    public class Repository : IRepository
    {
        private readonly PersonalSiteDbContext _context;

        public Repository(PersonalSiteDbContext context)
        {
            _context = context;
        }

        public async Task<T> CreateAsync<T>(T model) where T : class, IEntity
        {
            var entry = await _context.AddAsync(model);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return null;
            }

            return entry.Entity;
        }

        public async Task<bool> DeleteAsync<T>(Guid id) where T : class, IEntity
        {
            var existing = await _context.Set<T>().FirstOrDefaultAsync(r => r.Id == id);

            if (existing is null)
            {
                return false;
            }

            _context.Remove(existing);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class, IEntity =>
            await _context.Set<T>().ToArrayAsync();

        public async Task<T> GetByIdAsync<T>(Guid id) where T : class, IEntity =>
            await _context.Set<T>().FirstOrDefaultAsync(r => r.Id == id);

        public async Task<T> UpdateAsync<T>(Guid id, T model) where T : class, IEntity
        {
            var old = await _context.Set<T>().FirstOrDefaultAsync(r => r.Id == id);

            if (old is null)
            {
                return old;
            }

            var updated = _context.Set<T>().Update(model);
            await _context.SaveChangesAsync();

            return updated.Entity;
        }
    }
}