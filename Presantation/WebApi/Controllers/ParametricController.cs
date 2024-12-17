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
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Mühərrik tapılmadı." });
                }

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
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Rəng tapılmadı." });
                }

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
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Xidmətlər tapılmadı." });
                }

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
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Filter tapılmadı." });
                }

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
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "SAE tapılmadı." });
                }

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
                var response = await _mediator.Send(new GetWinterViscositiesQuery());
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "W tapılmadı." });
                }

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
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Motor həcmi tapılmadı." });
                }

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

    }
}

