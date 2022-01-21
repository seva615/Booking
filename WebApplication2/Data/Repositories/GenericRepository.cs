using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Booking.Data
{
    public class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DataContext _context;
        internal DbSet<TEntity> _dbSet;

        public EFGenericRepository(DataContext context)
        {
            _context = context;
           _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public void Edit(TEntity item)
        {
            _dbSet.Attach(item);
            _context.Entry(item).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(TEntity item)    
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
    }
}

