using Application.CQRS.Queries.Car.GetByİd.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Car.GetByİd
{
    public class GeByIdCarQuery : IRequest<GeByIdCarDto>
    {
        public int CarId { get; set; }
    }
}
