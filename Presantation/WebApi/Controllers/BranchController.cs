using Application.CQRS.Queries.Branch.Brancies;
using Application.CQRS.Queries.Branch.GetById;
using Application.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BranchController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetBranch()
        {
            var response = await _mediator.Send(new GetBranciesQuery());

            return Ok(new { success = true, data = response });
        }

        [HttpGet]
        [AtributteAuthenticator]
        public async Task<IActionResult> GetBranchById(int id)
        {
            var response = await _mediator.Send(new GetBranchByIdQuery() { Id = id });

            return Ok(new { success = true, data = response });
        }
    }
}
