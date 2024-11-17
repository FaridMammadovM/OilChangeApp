using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CostumersCarsMatrixController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CostumersCarsMatrixController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
