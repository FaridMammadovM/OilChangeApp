﻿using Application.CQRS.Commands.Customer.AddCustomer;
using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
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
        public async Task<IActionResult> AddCustomer([FromBody] AddCustomerReqDto request)
        {
            AddCustomerCommand command = new AddCustomerCommand() { Request = request };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
