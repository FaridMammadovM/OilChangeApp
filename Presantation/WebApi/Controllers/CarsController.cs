using Application.CQRS.Commands.Car.AddCar;
using Application.CQRS.Commands.Car.AddCar.Dtos;
using Application.CQRS.Commands.Car.DeleteCar;
using Application.CQRS.Commands.Car.UpdateCar;
using Application.CQRS.Commands.Car.UpdateCar.Dtos;
using Application.CQRS.Queries.Car.GetAll;
using Application.CQRS.Queries.Car.GetByİd;
using Application.JWT;
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

        /// <summary>
        /// Maşın siyahısı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetCars()
        {
            var response = await _mediator.Send(new GetAllCarsQuery());
            return Ok(new { success = true, data = response });
        }


        /// <summary>
        /// Maşın məlumatı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetCarsById([FromQuery] int carId)
        {
            var response = await _mediator.Send(new GeByIdCarQuery() { CarId = carId });
            return Ok(new { success = true, data = response });

        }

        /// <summary>
        /// Maşın əlavə etmək
        /// </summary>
        /// <remarks>
        /// Bu endpoint vasitəsilə yeni maşın əlavə edə bilərsiniz. 
        /// Gərəkli məlumatları düzgün daxil etdiyinizə əmin olun.
        /// </remarks>
        /// <param name="request">Yeni maşın məlumatları</param>
        /// <response code="200">Əlavə edildi</response>
        /// <response code="400">Məlumatlar düzgün deyil</response>
        /// <response code="500">Server xətası</response>

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddCar([FromBody] AddCarReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            AddCarCommand command = new AddCarCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Maşın əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Maşın uğurla əlavə edildi." });
        }

        /// <summary>
        /// Maşın məlumtların dəyişmək
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateCar([FromBody] UpdateCarReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            UpdateCarCommand command = new UpdateCarCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Maşın əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Maşın uğurla əlavə edildi." });
        }

        /// <summary>
        /// Maşının silinməsi
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteCar([FromQuery] int carId)
        {
            var response = await _mediator.Send(new DeleteCarCommand() { CarId = carId });
            if (response == null)
            {
                return NotFound(new { success = false, message = "Silinəcək maşın tapılmadı." });
            }

            return Ok(new { success = true, message = "Maşın uğurla silindi.", data = response });
        }
    }
}
