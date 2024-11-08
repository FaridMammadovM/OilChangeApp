using Application.CQRS.Queries.Car.GetAll.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.Car.GetAll
{
    public sealed class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IList<GetAllCarsResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetAllCarsQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetAllCarsResDto>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            var cars = await _unitOfWork.GetReadRepository<Cars>().GetAllAsync(include: x => x.Include(b => b.Colors));

            return _mapper.Map<GetAllCarsResDto, Cars>(cars);           
        }
    }
}
