using Application.CQRS.Commands.Car.AddCar.Dtos;
using Application.CQRS.Commands.Car.AddCar;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos;
using Application.CQRS.Commands.CostumersCarsMatrix.Add;

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
                    return BadRequest(new { success = false, message = "Maşın əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
                }

                return Ok(new { success = true, message = "Maşın uğurla əlavə edildi." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }
    }
}
