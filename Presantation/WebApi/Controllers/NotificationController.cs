using Application.CQRS.Queries.Notification.GetAllNotificationByCustomer;
using Application.CQRS.Queries.Notification.GetAllNotificationByCustomer.Dto;
using Application.CQRS.Queries.Notification.GetNotificationById;
using Application.CQRS.Queries.Notification.Job;
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

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetAllNotificationByCustomer([FromQuery] GetAllNotificationByCustomerReqDto request)
        {
            try
            {
                GetAllNotificationByCustomerQuery query = new GetAllNotificationByCustomerQuery() { Request = request };
                var response = await _mediator.Send(query);
                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetNotificationById(int notificationId)
        {
            try
            {
                var response = await _mediator.Send(new GetNotificationByIdQuery() { NotificationId = notificationId });

                return Ok(new { success = true, data = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

    }
}
