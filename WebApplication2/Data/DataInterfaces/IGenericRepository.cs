using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity item);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity item);
        void Edit(TEntity item);
    }
}
