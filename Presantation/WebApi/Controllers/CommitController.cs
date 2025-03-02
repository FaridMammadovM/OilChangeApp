using Application.CQRS.Commands.Commit.AddCommit;
using Application.CQRS.Commands.Commit.AddCommit.Dtos;
using Application.CQRS.Commands.Commit.ChangeCommitIsRead;
using Application.CQRS.Commands.Commit.ChangeCommitIsRead.Dtos;
using Application.CQRS.Commands.Commit.ResponseAdmin;
using Application.CQRS.Commands.Commit.ResponseAdmin.Dtos;
using Application.CQRS.Queries.Commit.GetAllCommit;
using Application.CQRS.Queries.Commit.GetCommit;
using Application.CQRS.Queries.Commit.GetCommit.Dtos;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommitController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CommitController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddCommit([FromBody] AddCommitReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            AddCommitCommand command = new AddCommitCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Müraciətiniz əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Müraciətiniz qeyda alındı" });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> ResponseCommit([FromBody] ResponseAdminReqDto request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
                }

                ResponseAdminCommand command = new ResponseAdminCommand() { Request = request };
                var result = await _mediator.Send(command);

                if (result == null)
                {
                    return BadRequest(new { success = false, message = "Commit əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
                }

                return Ok(new { success = true, message = "Commit uğurla əlavə edildi." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetAllCommit()
        {
            var response = await _mediator.Send(new GetAllCommitQuery());
            return Ok(new { success = true, data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetCommit([FromQuery] GetCommitQueryReqDto request)
        {
            var response = await _mediator.Send(new GetCommitQuery() { Request = request });
            return Ok(new { success = true, data = response });

        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> IsRead([FromBody] ChangeCommitIsReadReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            ChangeCommitIsReadCommand command = new ChangeCommitIsReadCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Məlumat dəyişdirilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Məlumat qeydə alındı" });
        }
        
    }
}
