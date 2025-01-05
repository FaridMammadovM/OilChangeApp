using Application.CQRS.Queries.Notification;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public NotificationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> ThreeMonthNotification()
        {
            try
            {
                var response = await _mediator.Send(new NotificationQuery()
                {
                    Month = 3
                });
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Məlumat tapılmadı." });
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
        public async Task<IActionResult> SixMonthNotification()
        {
            try
            {
                var response = await _mediator.Send(new NotificationQuery()
                {
                    Month = 6
                });
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Məlumat tapılmadı." });
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
