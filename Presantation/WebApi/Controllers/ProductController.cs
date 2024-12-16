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
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var response = await _mediator.Send(new GetProductsQuery());
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Məhsul tapılmadı." });
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
        public async Task<IActionResult> AddProduct([FromBody] AddProductReqDto request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
                }

                AddProductCommand command = new AddProductCommand() { Request = request };
                var result = await _mediator.Send(command);

                if (result == null)
                {
                    return BadRequest(new { success = false, message = "Məhsul əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
                }

                return Ok(new { success = true, message = "Məhsul uğurla əlavə edildi." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductReqDto request)
        {
            try
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

                return Ok(new { success = true, message = "Məhsul uğurla əlavə edildi." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }


        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteProduct([FromQuery] int producId)
        {
            try
            {
                var response = await _mediator.Send(new DeleteProductCommand() { Id = producId });
                if (response == null)
                {
                    return NotFound(new { success = false, message = "Silinəcək məhsul tapılmadı." });
                }

                return Ok(new { success = true, message = "Məhsul uğurla silindi.", data = response });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }
    }
}
