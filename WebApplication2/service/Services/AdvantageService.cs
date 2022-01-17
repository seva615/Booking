using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Booking.Data;

namespace Booking.Services
{
    public class AdvantageService : IAdvantageService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IAdvantageRepository _advantageRepository;
        private readonly IMapper _mapper;

        public AdvantageService(IRoomRepository roomRepository, IAdvantageRepository advantageRepository, IMapper mapper)
        {
            _advantageRepository = advantageRepository;
            _roomRepository = roomRepository;
            _mapper = mapper;
        }
        public void DeleteAdvantage(Guid id)
        {
            _advantageRepository.DeleteAdvantageEntity(id);
        }

        public void AddAdvantage(AdvantageModel advantage)
        {            
                var AdvantageEntity = _mapper.Map<AdvantageModel, AdvantageEntity>(advantage);
                _advantageRepository.AddAdvantageEntity(AdvantageEntity);                   
            
        }

        public AdvantageModel GetAdvantage(Guid id)
        {
            var AdvantageEntity = _advantageRepository.GetAdvantageEntity(id);
            var AdvantageModel = _mapper.Map<AdvantageEntity, AdvantageModel>(AdvantageEntity);
            return AdvantageModel;
        }

        public void EditAdvantage(AdvantageModel advantage)
        {
            var AdvantageEntity = _mapper.Map<AdvantageModel, AdvantageEntity>(advantage);
            _advantageRepository.EditAdvantageEntity(AdvantageEntity);
        }

        public IEnumerable<AdvantageModel> GetAdvantages()
        {
            var AdvantageEntities = _advantageRepository.GetAdvantageEntities();
            var AdvantageModels = _mapper.Map<IEnumerable<AdvantageModel>>(AdvantageEntities);
            return AdvantageModels;
        }
    }
}
