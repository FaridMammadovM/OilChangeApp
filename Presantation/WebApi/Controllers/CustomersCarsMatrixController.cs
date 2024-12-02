using Application.CQRS.Commands.CostumersCarsMatrix.Add;
using Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos;
using Application.CQRS.Queries.CostumersCarsMatrix.GetCostumersCarsMatrixId;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersCarsMatrixController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomersCarsMatrixController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddCostumersCarsMatrixCommand([FromBody] AddCostumersCarsMatrixReqDto request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
                }

                AddCostumersCarsMatrixCommand command = new AddCostumersCarsMatrixCommand() { Request = request };
                var result = await _mediator.Send(command);

                if (result == null)
                {
                    return BadRequest(new { success = false, message = "Müştəriyэ uyğun maşın əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
                }

                return Ok(new { success = true, message = "Maşın uğurla əlavə edildi." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetCostumersCarsWithPhone(string phone)
        {
            try
            {
                GetCostumersCarsMatrixIdQuery query = new GetCostumersCarsMatrixIdQuery() { Phone = phone };
                var response = await _mediator.Send(query);

                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Müştəriyэ uyğun maşın tapılmadı." });
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
