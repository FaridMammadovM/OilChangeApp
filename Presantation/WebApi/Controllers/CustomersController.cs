using Application.CQRS.Commands.Customer.AddCustomer;
using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Queries.Customer.Login;
using Application.CQRS.Queries.Customer.Login.Dto;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddCustomer([FromBody] AddCustomerReqDto request)
        {
            try
            {
                var command = new AddCustomerCommand { Request = request };
                var result = await _mediator.Send(command);

                if (result != null)
                {
                    return Ok(new { success = true, message = "Müştəri uğurla əlavə edildi.", data = result });
                }

                return BadRequest(new { success = false, message = "Müştəri əlavə edilə bilmədi." });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized(new { success = false, message = "Giriş icazəsi yoxdur." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginReqDto request)
        {
            try
            {
                var query = new LoginQuery { Request = request };
                var result = await _mediator.Send(query);

                if (result != null)
                {
                    return Ok(new { success = true, message = "Giriş uğurla tamamlandı.", data = result });
                }


                return NotFound(new { success = false, message = "İstifadəçi tapılmadı." });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized(new { success = false, message = "Giriş məlumatları düzgün deyil." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }
    }
}
