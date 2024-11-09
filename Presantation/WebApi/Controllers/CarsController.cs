using Application.CQRS.Commands.Car.AddCar;
using Application.CQRS.Commands.Car.AddCar.Dtos;
using Application.CQRS.Queries.Car.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var response = await _mediator.Send(new GetAllCarsQuery());
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> AddCar(AddCarReqDto request)
        {
            AddCarCommand command = new AddCarCommand() { Request = request };
            await _mediator.Send(command);
            return Ok();
        }
    }
}
