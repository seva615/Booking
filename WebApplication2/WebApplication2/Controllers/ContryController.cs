using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Booking.Services;
using AutoMapper;

namespace Booking.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContryController : Controller
    {
        private readonly IContryService _contryService;
        private readonly IMapper _mapper;

        public ContryController(IContryService contryService, IMapper mapper)
        {
            _mapper = mapper;
            _contryService = contryService;
        }

        [HttpGet]
        [Route("getContries")]
        public IEnumerable<ContryViewModel> GetContries()
        {
            var ContryModels = _contryService.GetContries();
            var ContryViewModels = _mapper.Map<IEnumerable<ContryViewModel>>(ContryModels);
            return ContryViewModels;
        }

        [HttpGet]
        [Route("getContry")]
        public ContryViewModel GetContry(Guid id)
        {
            var ContryModel = _contryService.GetContry(id);
            var ContryViewModel = _mapper.Map<ContryModel, ContryViewModel>(ContryModel);
            return ContryViewModel;
        }

        [HttpPost]
        [Route("addContry")]
        public void AddContry(ContryViewModel contry)
        {
            var ContryModel = _mapper.Map<ContryViewModel, ContryModel>(contry);
            _contryService.AddContry(ContryModel);
        }
        [HttpPut]
        [Route("editContry")]
        public void EditContry(ContryViewModel contry)
        {
            var ContryModel = _mapper.Map<ContryViewModel, ContryModel>(contry);
            _contryService.EditContry(ContryModel);
        }

        [HttpDelete]
        [Route("deleteContry")]
        public void DeleteContry(Guid id)
        {
            _contryService.DeleteContry(id);
        }
    }
}
