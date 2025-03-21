﻿using Application.CQRS.Commands.Employee.AddEmployee;
using Application.CQRS.Commands.Employee.AddEmployee.Dtos;
using Application.CQRS.Commands.Employee.DeleteEmployee;
using Application.CQRS.Commands.Employee.UpdateEmployee;
using Application.CQRS.Commands.Employee.UpdateEmployee.Dtos;
using Application.CQRS.Queries.Employee.GetEmployees;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        //[AtributteAuthenticator]
        public async Task<IActionResult> GetEmployees()
        {
            var response = await _mediator.Send(new GetEmployeesQuery());
            return Ok(new { success = true, data = response });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> AddEmployee([FromBody] AddEmployeeDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            AddEmployeeCommand command = new AddEmployeeCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "İşçi əlavə edilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "İşçi uğurla əlavə edildi." });
        }

        [HttpPost]
        [AtributteAuthenticator]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeDto request)
        {
            if (request == null)
            {
                return BadRequest(new { success = false, message = "Məlumatlar tam deyil." });
            }

            UpdateEmployeeCommand command = new UpdateEmployeeCommand() { Request = request };
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(new { success = false, message = "İşçi dəyişdirilə bilmədi. Məlumatlar düzgün deyil." });
            }

            return Ok(new { success = true, message = "İşçi uğurla dəyişdirildi." });
        }


        [HttpDelete]
        [AtributteAuthenticator]
        public async Task<IActionResult> DeleteEmployee([FromQuery] int id)
        {
            var response = await _mediator.Send(new DeleteEmployeeCommand() { Id = id });
            if (response == null)
            {
                return NotFound(new { success = false, message = "Silinəcək İşçi tapılmadı." });
            }

            return Ok(new { success = true, message = "İşçi uğurla silindi.", data = response });
        }
    }
}
