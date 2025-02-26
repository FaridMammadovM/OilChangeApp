using Application.CQRS.Commands.OilChange.AddOilChange;
using Application.CQRS.Commands.OilChange.AddOilChange.Dto;
using Application.CQRS.Commands.OilChange.DeleteOilChange;
using Application.CQRS.Commands.OilChange.UpdateOilChange;
using Application.CQRS.Commands.OilChange.UpdateOilChange.Dtos;
using Application.CQRS.Queries.OilChange.GetAllOilChanges;
using Application.CQRS.Queries.OilChange.GetAllOilChanges.Dtos;
using Application.CQRS.Queries.OilChange.GetByIdOilChanges;
using Application.CQRS.Queries.OilChange.GetOilChanges;
using Application.CQRS.Queries.OilChange.GetOilChanges.Dtos;
using Application.CQRS.Queries.OilChange.LastOilChanges;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OilChangeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OilChangeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddOilChange([FromBody] AddOilChangesReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            AddOilChangesCommand command = new AddOilChangesCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Xidmətlər əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Xidmətlər uğurla əlavə edildi." });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetAllOilChanges([FromQuery] GetAllOilChangesReqDto request)
        {
            GetAllOilChangesQuery query = new GetAllOilChangesQuery() { Request = request };
            var response = await _mediator.Send(query);
            return Ok(new { success = true, data = response });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateOilChange([FromBody] UpdateOilChangeReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            UpdateOilChangeCommand command = new UpdateOilChangeCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Xidmət dəyişdirilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Xidmət uğurla dəyişdirildi." });
        }

        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteOilChange([FromQuery] int id)
        {
            var response = await _mediator.Send(new DeleteOilChangeCommand() { Id = id });
            if (response == null)
            {
                return NotFound(new { success = false, message = "Silinəcək xidmət tapılmadı." });
            }
            return Ok(new { success = true, message = "Xidmət uğurla silindi.", data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> LastOilChange([FromQuery] string phone)
        {
            LastOilChangesQuery query = new LastOilChangesQuery() { Phone = phone };
            var response = await _mediator.Send(query);

            if (response == null || !response.Any())
            {
                return NotFound(new { success = false, message = "Müştəriyə uyğun xidmet tapılmadı." });
            }
            return Ok(new { success = true, data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetOilChangeById(int oilChangeId)
        {
            var response = await _mediator.Send(new GetByIdOilChangesQuery() { OilChangeId = oilChangeId });
            return Ok(new { success = true, data = response });
        }


        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetOilChanges([FromQuery] GetOilChangesReqDto request)
        {
            GetOilChangesQuery query = new GetOilChangesQuery() { Request = request };
            var response = await _mediator.Send(query);
            return Ok(new { success = true, data = response });

        }
    }
}
