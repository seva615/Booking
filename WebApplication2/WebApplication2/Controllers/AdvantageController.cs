using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Booking.Services;
using AutoMapper;

namespace Booking.API
{
    public class AdvantageController : Controller
    {
        private readonly IAdvantageService _advantageService;
        private readonly IMapper _mapper;

        public AdvantageController(IAdvantageService advantageService, IMapper mapper)
        {
            _mapper = mapper;
            _advantageService = advantageService;
        }

        [HttpGet]
        [Route("getAdvantages")]
        public async Task<IEnumerable<AdvantageViewModel>> GetAdvantages()
        {
            var AdvantageModels = await _advantageService.GetAdvantages();
            var AdvantageViewModels = _mapper.Map<IEnumerable<AdvantageViewModel>>(AdvantageModels);
            return AdvantageViewModels;
        }

        [HttpGet]
        [Route("getAdvantage")]
        public async Task<AdvantageViewModel> GetAdvantage(Guid id)
        {
            var AdvantageModel = await _advantageService.GetAdvantage(id);
            var AdvantageViewModel = _mapper.Map<AdvantageModel, AdvantageViewModel>(AdvantageModel);
            return AdvantageViewModel;
        }

        [HttpPost]
        [Route("addAdvantage")]
        public async Task AddAdvantage(CreateAdvantageViewModel advantage)
        {
            var AdvantageModel = _mapper.Map<CreateAdvantageViewModel, AdvantageModel>(advantage);
            await _advantageService.AddAdvantage(AdvantageModel);
        }

        [HttpPut]
        [Route("editAdvantage")]
        public async Task EditAdvantage(AdvantageViewModel advantage)
        {
            var AdvantageModel = _mapper.Map<AdvantageViewModel, AdvantageModel>(advantage);
            await _advantageService.EditAdvantage(AdvantageModel);
        }

        [HttpDelete]
        [Route("deleteAdvantage")]
        public async Task DeleteAdvantage(Guid id)
        {
            await _advantageService.DeleteAdvantage(id);
        }
    }
}
