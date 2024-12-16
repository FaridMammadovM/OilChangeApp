using MediatR;

namespace Application.CQRS.Commands.CostumersCarsMatrix.Delete
{
    public class DeleteCostumersCarsMatrixCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
