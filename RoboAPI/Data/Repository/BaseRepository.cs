using Microsoft.EntityFrameworkCore;
using RoboAPI.Data.Context;
using RoboAPI.Domain.Entities;
using RoboAPI.Domain.Interfaces;
using System.Data;

namespace RoboAPI.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public async Task<bool> DeleteAsync(long id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result == null)
                    return false;
                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch { throw; }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dataset.AsNoTracking().ToListAsync();
            }
            catch { throw; }
        }

        public async Task<T> GetByIdAsync(long id)
        {
            try
            {
                return await _dataset.FirstOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch { throw; }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                item.DataCriacao = DateTime.UtcNow;
                item.DataAtualizacao = DateTime.UtcNow;
                _dataset.Add(item);
                await _context.SaveChangesAsync();
            }
            catch { throw; }

            return item;
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.FirstOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null) return null;

                item.DataCriacao = result.DataCriacao;
                item.DataAtualizacao = DateTime.UtcNow;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch { throw; }

            return item;
        }
    }
}
