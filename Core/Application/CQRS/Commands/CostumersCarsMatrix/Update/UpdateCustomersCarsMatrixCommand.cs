using Application.CQRS.Commands.CostumersCarsMatrix.Update.Dtos;
using MediatR;

namespace Application.CQRS.Commands.CostumersCarsMatrix.Update
{
    public class UpdateCustomersCarsMatrixCommand : IRequest<Unit>
    {
        public UpdateCustomersCarsMatrixCommandReqDto Request { get; set; }
    }
}
