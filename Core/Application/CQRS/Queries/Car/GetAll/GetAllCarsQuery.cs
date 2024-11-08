using Application.CQRS.Queries.Car.GetAll.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Car.GetAll
{
    public class GetAllCarsQuery : IRequest<IList<GetAllCarsResDto>>
    {
    }
}
