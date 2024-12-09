using Application.CQRS.Queries.CostumersCarsMatrix.GetAllCustomerCarsMatrix.Dtos;
using MediatR;

namespace Application.CQRS.Queries.CostumersCarsMatrix.GetAllCustomerCarsMatrix
{
    public class GetAllCustomerCarsMatrixQuery : IRequest<IList<GetAllCustomerCarsMatrixResDto>>
    {
    }
}
