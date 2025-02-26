using Application.CQRS.Commands.Product.AddProduct;
using Application.CQRS.Commands.Product.AddProduct.Dtos;
using Application.CQRS.Commands.Product.DeleteProduct;
using Application.CQRS.Commands.Product.UpdateProduct;
using Application.CQRS.Commands.Product.UpdateProduct.Dtos;
using Application.CQRS.Queries.Parametric.GetProducts;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetOils()
        {
            var response = await _mediator.Send(new GetProductsQuery() { CategoryId = 1 });
            if (response == null || !response.Any())
            {
                return Ok(new { success = false, message = "Məhsul tapılmadı." });
            }
            return Ok(new { success = true, data = response });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddOil([FromBody] AddProductReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            AddProductCommand command = new AddProductCommand() { Request = request, CategoryId = 1 };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Məhsul əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
            }
            return Ok(new { success = true, message = "Məhsul uğurla əlavə edildi." });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateOil([FromBody] UpdateProductReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            UpdateProductCommand command = new UpdateProductCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Məhsul əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Məhsul uğurla dəyişdirildi." });
        }


        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteOil([FromQuery] int producId)
        {
            var response = await _mediator.Send(new DeleteProductCommand() { Id = producId });
            if (response == null)
            {
                return NotFound(new { success = false, message = "Silinəcək məhsul tapılmadı." });
            }

            return Ok(new { success = true, message = "Məhsul uğurla silindi.", data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetAntifirizs()
        {
            var response = await _mediator.Send(new GetProductsQuery() { CategoryId = 2 });
            if (response == null || !response.Any())
            {
                return Ok(new { success = false, message = "Məhsul tapılmadı." });
            }
            return Ok(new { success = true, data = response });
        }
        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddAntifiriz([FromBody] AddProductReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            AddProductCommand command = new AddProductCommand() { Request = request, CategoryId = 2 };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Məhsul əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Məhsul uğurla əlavə edildi." });
        }
        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateAntifiriz([FromBody] UpdateProductReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            UpdateProductCommand command = new UpdateProductCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Məhsul dəyişdirilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Məhsul uğurla dəyişdirildi." });
        }

        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteAntifiriz([FromQuery] int producId)
        {
            var response = await _mediator.Send(new DeleteProductCommand() { Id = producId });
            if (response == null)
            {
                return NotFound(new { success = false, message = "Silinəcək məhsul tapılmadı." });
            }

            return Ok(new { success = true, message = "Məhsul uğurla silindi.", data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetLiquid()
        {
            var response = await _mediator.Send(new GetProductsQuery() { CategoryId = 3 });
            if (response == null || !response.Any())
            {
                return Ok(new { success = false, message = "Məhsul tapılmadı." });
            }

            return Ok(new { success = true, data = response });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddLiquid([FromBody] AddProductReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            AddProductCommand command = new AddProductCommand() { Request = request, CategoryId = 3 };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Məhsul əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Məhsul uğurla əlavə edildi." });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateLiquid([FromBody] UpdateProductReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            UpdateProductCommand command = new UpdateProductCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Məhsul dəyişdirilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Məhsul uğurla dəyişdirildi." });
        }

        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteLiquid([FromQuery] int producId)
        {
            var response = await _mediator.Send(new DeleteProductCommand() { Id = producId });
            if (response == null)
            {
                return NotFound(new { success = false, message = "Silinəcək məhsul tapılmadı." });
            }

            return Ok(new { success = true, message = "Məhsul uğurla silindi.", data = response });
        }
    }
}
