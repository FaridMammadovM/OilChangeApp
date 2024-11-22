using Application.CQRS.Queries.Car.GetAll;
using Application.CQRS.Queries.Parametric.Brancies;
using Application.CQRS.Queries.Parametric.GetColors;
using Application.CQRS.Queries.Parametric.GetFuelTypes;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> GetBranch()
        {
            try
            {
                var response = await _mediator.Send(new GetBranciesQuery());
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Filal tapılmadı." });
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
    }
}
}
