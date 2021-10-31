using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data;
using AutoMapper;

namespace Booking.Services
{
    public class ContryService : IContryService
    {
        private readonly IContryRepository _contryRepository;
        private readonly IMapper _mapper;

        public ContryService(IContryRepository contryRepository, IMapper mapper)
        {
            _contryRepository = contryRepository;
            _mapper = mapper;
        }
        public void DeleteContry(Guid id)
        {
            _contryRepository.DeleteContryEntity(id);
        }

        public void AddContry(ContryModel contry)
        {
            var ContryEntity = _mapper.Map<ContryModel, ContryEntity>(contry);
            _contryRepository.AddContryEntity(ContryEntity);
        }

        public ContryModel GetContry(Guid id)
        {
            var ContryEntity = _contryRepository.GetContryEntity(id);
            var ContryModel = _mapper.Map<ContryEntity, ContryModel>(ContryEntity);
            return ContryModel;
        }

        public void EditContry(ContryModel contry)
        {
            var ContryEntity = _mapper.Map<ContryModel, ContryEntity>(contry);
            _contryRepository.EditContryEntity(ContryEntity);
        }

        public IEnumerable<ContryModel> GetContries()
        {

            var ContryEntities = _contryRepository.GetContryEntities();
            var ContryModels = _mapper.Map<IEnumerable<ContryModel>>(ContryEntities);
            return ContryModels;
        }
    }
}
