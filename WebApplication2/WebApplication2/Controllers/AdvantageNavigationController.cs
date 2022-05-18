using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Services;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API
{
    public class AdvantageNavigationController
    {
        private readonly IAdvantageNavigationService _advantageNavigationService;
        private readonly IMapper _mapper;

        public AdvantageNavigationController(IAdvantageNavigationService advantageNavigationService, IMapper mapper)
        {
            _mapper = mapper;
            _advantageNavigationService = advantageNavigationService;
        }

        [HttpGet]
        [Route("getAdvantageNavigations")]
        public async Task<IEnumerable<AdvantageNavigationViewModel>> GetAdvantageNavigations()
        {
            var AdvantageNavigationModels = await _advantageNavigationService.GetAdvantageNavigations();
            var AdvantageNavigationViewModels = _mapper.Map<IEnumerable<AdvantageNavigationViewModel>>(AdvantageNavigationModels);
            return AdvantageNavigationViewModels;
        }

        [HttpGet]
        [Route("getAdvantageNavigation")]
        public async Task<AdvantageNavigationViewModel> GetAdvantageNavigation(Guid id)
        {
            var AdvantageNavigationModel = await _advantageNavigationService.GetAdvantageNavigation(id);
            var AdvantageNavigationViewModel = _mapper.Map<AdvantageNavigationModel, AdvantageNavigationViewModel>(AdvantageNavigationModel);
            return AdvantageNavigationViewModel;
        }

        [HttpPost]
        [Route("addAdvantageNavigation")]
        public async Task AddAdvantageNavigation(CreateAdvantageNavigationViewModel advantageNavigation)
        {
            var AdvantageNavigationModel = _mapper.Map<CreateAdvantageNavigationViewModel, AdvantageNavigationModel>(advantageNavigation);
            await _advantageNavigationService.AddAdvantageNavigation(AdvantageNavigationModel);
        }

        [HttpPut]
        [Route("editAdvantageNavigation")]
        public async Task EditAdvantageNavigation(AdvantageNavigationViewModel advantageNavigation)
        {
            var AdvantageNavigationModel = _mapper.Map<AdvantageNavigationViewModel, AdvantageNavigationModel>(advantageNavigation);
            await _advantageNavigationService.EditAdvantageNavigation(AdvantageNavigationModel);
        }

        [HttpDelete]
        [Route("deleteAdvantageNavigation")]
        public async Task DeleteAdvantageNavigation(Guid id)
        {
            await _advantageNavigationService.DeleteAdvantageNavigation(id);
        }
    }
}