using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Car.GetAll
{
    public class GetAllCarsQuery : IRequest<IList<Cars>>
    {
    }
}
