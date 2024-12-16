using Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos;
using MediatR;

namespace Application.CQRS.Commands.CostumersCarsMatrix.Add
{
    public class AddCostumersCarsMatrixCommand : IRequest<Unit>
    {
        public AddCostumersCarsMatrixReqDto Request { get; set; }
    }
}
