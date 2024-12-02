using Application.CQRS.Queries.CostumersCarsMatrix.GetCostumersCarsMatrixId.Dtos;
using MediatR;

namespace Application.CQRS.Queries.CostumersCarsMatrix.GetCostumersCarsMatrixId
{
    public class GetCostumersCarsMatrixIdQuery : IRequest<IList<GetCostumersCarsMatrixResDto>>
    {
        public string Phone { get; set; }
    }
}
