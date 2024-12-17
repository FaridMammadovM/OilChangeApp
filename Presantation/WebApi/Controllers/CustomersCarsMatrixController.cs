using Application.CQRS.Commands.CostumersCarsMatrix.Add;
using Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos;
using Application.CQRS.Commands.CostumersCarsMatrix.Delete;
using Application.CQRS.Commands.CostumersCarsMatrix.Update;
using Application.CQRS.Commands.CostumersCarsMatrix.Update.Dtos;
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
        public async Task<IActionResult> AddCostumersCarsMatrix([FromBody] AddCostumersCarsMatrixReqDto request)
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
                    return NotFound(new { success = false, message = "Müştəriyə uyğun maşın tapılmadı." });
                }

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateCustomersCarsMatrix([FromBody] UpdateCustomersCarsMatrixReqDto request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
                }

                UpdateCustomersCarsMatrixCommand command = new UpdateCustomersCarsMatrixCommand() { Request = request };
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

        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteCustomersCarsMatrix([FromQuery] int id)
        {
            try
            {
                var response = await _mediator.Send(new DeleteCostumersCarsMatrixCommand() { Id = id });
                if (response == null)
                {
                    return NotFound(new { success = false, message = "Silinəcək məlumat tapılmadı." });
                }

                return Ok(new { success = true, message = "Uğurla silindi.", data = response });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }
    }
}
