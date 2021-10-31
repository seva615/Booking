using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
   public interface IContryService
    {
        public void DeleteContry(Guid id);
        public void AddContry(ContryModel contry);
        public ContryModel GetContry(Guid id);
        public void EditContry(ContryModel contry);
        public IEnumerable<ContryModel> GetContries();
    }
}
