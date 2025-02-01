using Application.CQRS.Queries.Parametric.GetColors;
using Application.CQRS.Queries.Parametric.GetFilters;
using Application.CQRS.Queries.Parametric.GetFuelTypes;
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
            try
            {
                var response = await _mediator.Send(new GetFuelTypesQuery());

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }


        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetColors()
        {
            try
            {
                var response = await _mediator.Send(new GetColorsQuery());

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetServices()
        {
            try
            {
                var response = await _mediator.Send(new GetServicesQuery());

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }


        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetFilters()
        {
            try
            {
                var response = await _mediator.Send(new GetFiltersQuery());

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetSAEViscosities()
        {
            try
            {
                var response = await _mediator.Send(new GetSAEViscositiesQuery());

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetWinterViscosities()
        {
            try
            {
                var response = await _mediator.Send(new GetWinterViscositiesQuery() { ServiceType = 1 });

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetDOTs()
        {
            try
            {
                var response = await _mediator.Send(new GetWinterViscositiesQuery() { ServiceType = 2 });

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetMotors()
        {
            try
            {
                var response = await _mediator.Send(new GetMotorsQuery());

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

    }
}

