using Application.CQRS.Queries.Parametric.GetColors;
using Application.CQRS.Queries.Parametric.GetDOTs;
using Application.CQRS.Queries.Parametric.GetFilters;
using Application.CQRS.Queries.Parametric.GetFuelTypes;
using Application.CQRS.Queries.Parametric.GetG;
using Application.CQRS.Queries.Parametric.GetMotors;
using Application.CQRS.Queries.Parametric.GetSAEViscosities;
using Application.CQRS.Queries.Parametric.GetServices;
using Application.CQRS.Queries.Parametric.WinterViscosities;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ParametricController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ParametricController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetFuelTypes()
        {
            var response = await _mediator.Send(new GetFuelTypesQuery());
            return Ok(new { success = true, data = response });
        }


        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetColors()
        {
            var response = await _mediator.Send(new GetColorsQuery());
            return Ok(new { success = true, data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetServices()
        {
            var response = await _mediator.Send(new GetServicesQuery());
            return Ok(new { success = true, data = response });
        }


        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetFilters()
        {
            var response = await _mediator.Send(new GetFiltersQuery());
            return Ok(new { success = true, data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetSAEViscosities()
        {
            var response = await _mediator.Send(new GetSAEViscositiesQuery());
            return Ok(new { success = true, data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetWinterViscosities()
        {
            var response = await _mediator.Send(new GetWinterViscositiesQuery() { ServiceType = 1 });
            return Ok(new { success = true, data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetDOTs()
        {
            var response = await _mediator.Send(new GetDOTsQuery());
            return Ok(new { success = true, data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetMotors()
        {
            var response = await _mediator.Send(new GetMotorsQuery());
            return Ok(new { success = true, data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetG()
        {
            var response = await _mediator.Send(new GetGQuery());
            return Ok(new { success = true, data = response });
        }
    }
}

