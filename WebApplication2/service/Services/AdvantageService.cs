using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Data;

namespace Booking.Services
{
    public class AdvantageService : IAdvantageService
    {
        private readonly IAdvantageRepository _advantageRepository;
        private readonly IMapper _mapper;

        public AdvantageService(IAdvantageRepository advantageRepository, IMapper mapper)
        {
            _advantageRepository = advantageRepository;
            _mapper = mapper;
        }
        public async Task DeleteAdvantage(Guid id)
        {
           await _advantageRepository.Delete(id);
        }

        public async Task AddAdvantage(AdvantageModel advantage)
        {            
                var AdvantageEntity = _mapper.Map<AdvantageModel, AdvantageEntity>(advantage);
                await _advantageRepository.Add(AdvantageEntity);                   
            
        }

        public async Task<AdvantageModel> GetAdvantage(Guid id)
        {
            var AdvantageEntity = await _advantageRepository.GetById(id);
            var AdvantageModel = _mapper.Map<AdvantageEntity, AdvantageModel>(AdvantageEntity);
            return AdvantageModel;
        }

        public async Task EditAdvantage(AdvantageModel advantage)
        {
            var AdvantageEntity = _mapper.Map<AdvantageModel, AdvantageEntity>(advantage);
            await _advantageRepository.Edit(AdvantageEntity);
        }

        public async Task<IEnumerable<AdvantageModel>> GetAdvantages()
        {
            var AdvantageEntities = await _advantageRepository.GetAll();
            var AdvantageModels = _mapper.Map<IEnumerable<AdvantageModel>>(AdvantageEntities);
            return AdvantageModels;
        }
    }
}
