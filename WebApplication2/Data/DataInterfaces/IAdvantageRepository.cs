using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
   public interface IAdvantageRepository
    {
        public void DeleteAdvantageEntity(Guid id);
        public void AddAdvantageEntity(AdvantageEntity advantage);
        public void EditAdvantageEntity(AdvantageEntity advantage);
        public AdvantageEntity GetAdvantageEntity(Guid id);
        public IEnumerable<AdvantageEntity> GetAdvantageEntities();
    }
}
