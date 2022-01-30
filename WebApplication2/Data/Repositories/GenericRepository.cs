using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Booking.Data.DataInterfaces;
using System.Threading.Tasks;

namespace Booking.Data
{
    public abstract class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class , IEntity
    {
        private readonly DataContext _context;
        protected Microsoft.EntityFrameworkCore.DbSet<TEntity> _dbSet;

        protected IQueryable<TEntity> CollectionWithIncludes { get; set; }

        public EFGenericRepository(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await CollectionWithIncludes.ToListAsync();
        }
        
        public async Task<TEntity> GetById(Guid id)
        {
            return await CollectionWithIncludes.FirstOrDefaultAsync(entity => id == entity.Id);
        }

        public async Task<TEntity> GetByName(string name)
        {
            return await CollectionWithIncludes.FirstOrDefaultAsync(entity => name == entity);
        }

        public async Task Add(TEntity item)
        {
           await _dbSet.AddAsync(item);
           await _context.SaveChangesAsync();
        }
        public async Task Edit(TEntity item)
        {
             _dbSet.Attach(item);
             _context.Entry(item).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)    
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

