using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Neurotech.Application.Interfaces;
using Neurotech.Application.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//Just a comment

namespace Neurotech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeuroTechController : ControllerBase
    {
        private readonly INeurotechService _neurotechService;

        public NeuroTechController(INeurotechService neurotechService)
        {
            _neurotechService = neurotechService;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegisterViewModel model)
        {
            return Ok(await _neurotechService.Submit(model));
        }

    }
}
