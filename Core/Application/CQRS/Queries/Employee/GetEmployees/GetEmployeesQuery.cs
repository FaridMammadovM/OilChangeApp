using Application.CQRS.Queries.Employee.GetEmployees.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Employee.GetEmployees
{
    public class GetEmployeesQuery : IRequest<IList<GetEmployeesDto>>
    {
    }
}
