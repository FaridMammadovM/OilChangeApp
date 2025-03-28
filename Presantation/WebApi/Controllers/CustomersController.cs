﻿using Application.CQRS.Commands.Customer.AddAdmin;
using Application.CQRS.Commands.Customer.AddAdmin.Dtos;
using Application.CQRS.Commands.Customer.AddCustomer;
using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Commands.Customer.ChangePassword;
using Application.CQRS.Commands.Customer.ChangePassword.Dtos;
using Application.CQRS.Commands.Customer.ChangePasswordWithAdmin;
using Application.CQRS.Commands.Customer.ChangePasswordWithAdmin.Dtos;
using Application.CQRS.Commands.Customer.CreateAccount;
using Application.CQRS.Commands.Customer.CreateAccount.Dtos;
using Application.CQRS.Commands.Customer.DeleteCustomer;
using Application.CQRS.Commands.Customer.UpdateAdmin;
using Application.CQRS.Commands.Customer.UpdateAdmin.Dtos;
using Application.CQRS.Commands.Customer.UpdateCustomer;
using Application.CQRS.Commands.Customer.UpdateCustomer.Dtos;
using Application.CQRS.Queries.Customer.AdminLogin;
using Application.CQRS.Queries.Customer.AdminLogin.Dtos;
using Application.CQRS.Queries.Customer.CheckToken;
using Application.CQRS.Queries.Customer.GetAdminById;
using Application.CQRS.Queries.Customer.GetAdmins;
using Application.CQRS.Queries.Customer.GetAllCustomer;
using Application.CQRS.Queries.Customer.GetAllCustomer.Dtos;
using Application.CQRS.Queries.Customer.GetCustomerById;
using Application.CQRS.Queries.Customer.Login;
using Application.CQRS.Queries.Customer.Login.Dto;
using Application.CQRS.Queries.Customer.Logout;
using Application.CQRS.Queries.Customer.ResendOtp;
using Application.CQRS.Queries.Customer.ResendOtp.Dtos;
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
        //[AtributteAuthenticator]
        public async Task<IActionResult> CreateAccount([FromBody] CreateAccountReqDto request)
        {
            var command = new CreateAccountCommand { Request = request };
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return Ok(new { success = true, message = "OTP göndərildi. Zəhmət olmasa, təsdiqləyin.", data = result });
            }

            return BadRequest(new { success = false, message = "İstifadəçi əlavə edilə bilmədi." });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddCustomer([FromBody] AddCustomerReqDto request)
        {
            var command = new AddCustomerCommand { Request = request };
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return Ok(new { success = true, message = "Müştəri uğurla əlavə edildi.", data = result });
            }

            return BadRequest(new { success = false, message = "Müştəri əlavə edilə bilmədi." });
        }


        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetCustomers([FromQuery] GetAllCustomerReqDto request)
        {
            var response = await _mediator.Send(new GetAllCustomerQuery() { Request = request });
            return Ok(new { success = true, data = response });
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginReqDto request)
        {
            var query = new LoginQuery { Request = request };
            var result = await _mediator.Send(query);

            if (result != null)
            {
                return Ok(new { success = true, message = "Giriş uğurla tamamlandı.", data = result });
            }

            return NotFound(new { success = false, message = "Nömrə və ya şifrə yanlışdır" });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetCustomerById(string phone)
        {
            var response = await _mediator.Send(new GetCustomerByIdQuery() { Phone = phone });
            return Ok(new { success = true, data = response });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordReqDto request)
        {
            var command = new ChangePasswordCommand { Request = request };
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return Ok(new { success = true, message = "Şifrə uğurla əlavə edildi.", data = result });
            }
            else
            {
                return BadRequest(new { success = false, message = "Şifrə əlavə edilə bilmədi." });
            }
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> ChangePasswordWithAdmin([FromBody] ChangePasswordWithAdminReqDto request)
        {
            var command = new ChangePasswordWithAdminCommand { Request = request };
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return Ok(new { success = true, message = "Şifrə uğurla əlavə edildi.", data = result });
            }
            else
            {
                return BadRequest(new { success = false, message = "Şifrə əlavə edilə bilmədi." });
            }
        }


        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateCustomer([FromBody] UpdateCustomerReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            UpdateCustomerCommand command = new UpdateCustomerCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Müştəri dəyişdirilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Müştəri uğurla dəyişdirildi." });
        }


        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteCustomer([FromQuery] string phone)
        {
            var response = await _mediator.Send(new DeleteCustomerCommand() { Phone = phone });
            if (response == null)
            {
                return NotFound(new { success = false, message = "Silinəcək müştəri tapılmadı." });
            }

            return Ok(new { success = true, message = "Müştəri uğurla silindi.", data = response });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddAdmin([FromBody] AddAdminReqDto request)
        {
            var command = new AddAdminCommand { Request = request };
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return Ok(new { success = true, message = "Admin uğurla əlavə edildi.", data = result });
            }

            return BadRequest(new { success = false, message = "Admin əlavə edilə bilmədi." });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateAdmin([FromBody] UpdateAdminReqDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            UpdateAdminCommand command = new UpdateAdminCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "Admin dəyişdirilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "Admin uğurla dəyişdirildi." });
        }

        [HttpPost]
        public async Task<IActionResult> VerifyOtp([FromBody] VerifyOtpReqDto request)
        {
            var query = new VerifyOtpQuery { Request = request };
            var result = await _mediator.Send(query);

            if (result != null)
            {
                return Ok(new { success = true, message = "Giriş uğurla tamamlandı.", data = result });
            }
            return Unauthorized(new { success = false, message = "OTP düzgün deyil və ya müddəti bitib." });
        }

        [HttpPost]
        public async Task<IActionResult> ResendOtp([FromBody] ResendOtpDto request)
        {
            var query = new ResendOtpQuery { Request = request };
            var result = await _mediator.Send(query);

            return Ok(new { success = true, message = "Giriş uğurla tamamlandı.", data = result });
        }

        [HttpPost]
        public async Task<IActionResult> CheckToken([FromBody] string refreshToken)
        {
            var query = new CheckTokenQuery { RefreshToken = refreshToken };
            var result = await _mediator.Send(query);

            if (result != null)
            {
                return Ok(new { success = true, message = "Uğurla tamamlandı.", data = result });
            }
            return NotFound(new { success = false, message = "Token tapılmadı." });
        }

        [HttpPost]
        public async Task<IActionResult> Logout([FromBody] string refreshToken)
        {
            var command = new LogoutQuery { RefreshToken = refreshToken };
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return Ok(new { success = true, message = "Uğurla tamamlandı.", data = result });
            }

            return BadRequest(new { success = false, message = "Uğursuz oldu." });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetAdmins()
        {
            var response = await _mediator.Send(new GetAdminsQuery());
            return Ok(new { success = true, data = response });
        }

        [HttpPost]
        public async Task<IActionResult> AdminLogin([FromBody] AdminLoginReqDto request)
        {
            var query = new AdminLoginQuery { Request = request };
            var result = await _mediator.Send(query);

            if (result != null)
            {
                return Ok(new { success = true, message = "Giriş uğurla tamamlandı.", data = result });
            }
            return NotFound(new { success = false, message = "Username və ya şifrə yanlışdır" });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetAdminByUsername(string username)
        {
            var response = await _mediator.Send(new GetAdminByIdQuery() { Username = username });
            return Ok(new { success = true, data = response });
        }
    }
}
