using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Data;
using Booking.Data.DataInterfaces;
using Booking.Data.Entities;

namespace Booking.Services
{
    public class AdvantageNavigationService : IAdvantageNavigationService
        {
            private readonly IAdvantageNavigationRepository _advantageNavigationRepository;
            private readonly IAdvantageRepository _advantageRepository;
            private readonly IRoomRepository _roomRepository;
            private readonly IMapper _mapper;

            public AdvantageNavigationService(IMapper mapper, IAdvantageNavigationRepository advantageNavigationRepository, IAdvantageRepository advantageRepository, IRoomRepository roomRepository)
            {
                _advantageNavigationRepository = advantageNavigationRepository;
                _roomRepository = roomRepository;
                _advantageRepository = advantageRepository;
                _mapper = mapper;
            }
            public async Task DeleteAdvantageNavigation(Guid id)
            {
                await _advantageNavigationRepository.Delete(id);
            }

            public async Task AddAdvantageNavigation(AdvantageNavigationModel advantageNavigation)
            {
                if (await _advantageRepository.GetById(advantageNavigation.AdvantageId) != null)
                {
                    if (await _roomRepository.GetById(advantageNavigation.RoomId) != null)
                    {
                        var AdvantageNavigationEntity =
                            _mapper.Map<AdvantageNavigationModel, AdvantageNavigationEntity>(advantageNavigation);
                        await _advantageNavigationRepository.Add(AdvantageNavigationEntity);
                    }
                    else throw new NotFoundException("No room found with entered id");
                }
                else throw new NotFoundException("No advantage found with entered id");

            }

            public async Task<AdvantageNavigationModel> GetAdvantageNavigation(Guid id)
            {
                var AdvantageNavigationEntity = await _advantageNavigationRepository.GetById(id);
                var AdvantageNavigationModel = _mapper.Map<AdvantageNavigationEntity, AdvantageNavigationModel>(AdvantageNavigationEntity);
                return AdvantageNavigationModel;
            }

            public async Task EditAdvantageNavigation(AdvantageNavigationModel advantageNavigation)
            {
                var AdvantageNavigationEntity = _mapper.Map<AdvantageNavigationModel, AdvantageNavigationEntity>(advantageNavigation);
                await _advantageNavigationRepository.Edit(AdvantageNavigationEntity);
            }

            public async Task<IEnumerable<AdvantageNavigationModel>> GetAdvantageNavigations()
            {
                var AdvantageNavigationEntities = await _advantageNavigationRepository.GetAll();
                var AdvantageNavigationModels = _mapper.Map<IEnumerable<AdvantageNavigationModel>>(AdvantageNavigationEntities);
                return AdvantageNavigationModels;
            }
        }
    }
