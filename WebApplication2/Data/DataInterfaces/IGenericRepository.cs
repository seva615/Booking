using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Data
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity item);
        Task<TEntity> GetById(Guid id);
        Task<TEntity> GetByName(string name);
        Task<IEnumerable<TEntity>> GetAll();
        Task Delete(Guid id);
        Task Edit(TEntity item);
    }
}
