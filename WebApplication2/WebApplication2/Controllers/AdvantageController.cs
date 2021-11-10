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
        public IEnumerable<AdvantageViewModel> GetAdvantages()
        {
            var AdvantageModels = _advantageService.GetAdvantages();
            var AdvantageViewModels = _mapper.Map<IEnumerable<AdvantageViewModel>>(AdvantageModels);
            return AdvantageViewModels;
        }

        [HttpGet]
        [Route("getAdvantage")]
        public AdvantageViewModel GetAdvantage(Guid id)
        {
            var AdvantageModel = _advantageService.GetAdvantage(id);
            var AdvantageViewModel = _mapper.Map<AdvantageModel, AdvantageViewModel>(AdvantageModel);
            return AdvantageViewModel;
        }

        [HttpPost]
        [Route("addAdvantage")]
        public void AddAdvantage(AdvantageViewModel advantage)
        {
            var AdvantageModel = _mapper.Map<AdvantageViewModel, AdvantageModel>(advantage);
            _advantageService.AddAdvantage(AdvantageModel);
        }
        [HttpPut]
        [Route("editAdvantage")]
        public void EditAdvantage(AdvantageViewModel advantage)
        {
            var AdvantageModel = _mapper.Map<AdvantageViewModel, AdvantageModel>(advantage);
            _advantageService.EditAdvantage(AdvantageModel);
        }

        [HttpDelete]
        [Route("deleteAdvantage")]
        public void DeleteAdvantage(Guid id)
        {
            _advantageService.DeleteAdvantage(id);
        }
    }
}
