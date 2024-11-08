using Application.CQRS.Queries.Car.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var response = await _mediator.Send(new GetAllCarsQuery());
            return Ok(response);
        }
    }
}
