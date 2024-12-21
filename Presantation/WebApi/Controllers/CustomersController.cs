﻿using Application.CQRS.Commands.Customer.AddCustomer;
using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Commands.Customer.ChangePassword;
using Application.CQRS.Commands.Customer.ChangePassword.Dtos;
using Application.CQRS.Commands.Customer.ChangePasswordWithAdmin;
using Application.CQRS.Commands.Customer.ChangePasswordWithAdmin.Dtos;
using Application.CQRS.Commands.Customer.DeleteCustomer;
using Application.CQRS.Commands.Customer.UpdateCustomer;
using Application.CQRS.Commands.Customer.UpdateCustomer.Dtos;
using Application.CQRS.Queries.Customer.GetAllCustomer;
using Application.CQRS.Queries.Customer.GetCustomerById;
using Application.CQRS.Queries.Customer.Login;
using Application.CQRS.Queries.Customer.Login.Dto;
using Application.CQRS.Queries.Customer.VerifyOtp;
using Application.CQRS.Queries.Customer.VerifyOtp.Dtos;
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
                var command = new AddCustomerCommand { Request = request, IsOtp = false };
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


        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                var response = await _mediator.Send(new GetAllCustomerQuery());
                if (response == null || !response.Any())
                {
                    return NotFound(new { success = false, message = "Müştərilər tapılmadı." });
                }

                return Ok(new { success = true, data = response });
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

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetCustomerById(string phone)
        {
            try
            {
                var response = await _mediator.Send(new GetCustomerByIdQuery() { Phone = phone });
                if (response == null)
                {
                    return NotFound(new { success = false, message = "Müştəri tapılmadı." });
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
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordReqDto request)
        {
            try
            {
                var command = new ChangePasswordCommand { Request = request };
                var result = await _mediator.Send(command);

                if (result != null)
                {
                    return Ok(new { success = true, message = "Password uğurla əlavə edildi.", data = result });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Password əlavə edilə bilmədi." });
                }
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
        [AtributteAuthenticator]
        public async Task<IActionResult> ChangePasswordWithAdmin([FromBody] ChangePasswordWithAdminReqDto request)
        {
            try
            {
                var command = new ChangePasswordWithAdminCommand { Request = request };
                var result = await _mediator.Send(command);

                if (result != null)
                {
                    return Ok(new { success = true, message = "Password uğurla əlavə edildi.", data = result });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Password əlavə edilə bilmədi." });
                }
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
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateCustomer([FromBody] UpdateCustomerReqDto request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
                }

                UpdateCustomerCommand command = new UpdateCustomerCommand() { Request = request };
                var result = await _mediator.Send(command);

                if (result == null)
                {
                    return BadRequest(new { success = false, message = "Müştəri əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
                }

                return Ok(new { success = true, message = "Müştəri uğurla əlavə edildi." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }


        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteCustomer([FromQuery] string phone)
        {
            try
            {
                var response = await _mediator.Send(new DeleteCustomerCommand() { Phone = phone });
                if (response == null)
                {
                    return NotFound(new { success = false, message = "Silinəcək müştəri tapılmadı." });
                }

                return Ok(new { success = true, message = "Müştəri uğurla silindi.", data = response });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddAdmin([FromBody] AddCustomerReqDto request)
        {
            try
            {
                var command = new AddCustomerCommand { Request = request, IsOtp = true };
                var result = await _mediator.Send(command);

                if (result != null)
                {
                    return Ok(new { success = true, message = "Admin uğurla əlavə edildi.", data = result });
                }

                return BadRequest(new { success = false, message = "Admin əlavə edilə bilmədi." });
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
        public async Task<IActionResult> VerifyOtp([FromBody] VerifyOtpReqDto request)
        {
            try
            {
                var query = new VerifyOtpQuery { Request = request };
                var result = await _mediator.Send(query);

                if (result != null)
                {
                    return Ok(new { success = true, message = "Giriş uğurla tamamlandı.", data = result });
                }


                return NotFound(new { success = false, message = "OTP düzgün deyil və ya müddəti bitib." });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized(new { success = false, message = "OTP düzgün deyil və ya müddəti bitib." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Xəta baş verdi: {ex.Message}" });
            }
        }
    }
}
