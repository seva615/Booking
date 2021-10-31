using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public interface IContryRepository
    {
        public void DeleteContryEntity(Guid id);
        public void AddContryEntity(ContryEntity contry);
        public void EditContryEntity(ContryEntity contry);
        public ContryEntity GetContryEntity(Guid id);
        public IEnumerable<ContryEntity> GetContryEntities();
    }
}
