using Application.CQRS.Queries.Car.GetAll.Dtos;
using Application.CQRS.Queries.Car.GetAll;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Application.CQRS.Queries.Customer.GetAllCustomer.Dtos;

namespace Application.CQRS.Queries.Customer.GetAllCustomer
{
    public sealed class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, IList<GetAllCustomerResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetAllCustomerQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetAllCustomerResDto>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            var customers = await _unitOfWork.GetReadRepository<Customers>().GetAllAsync(car => car.IsDeleted == false);
            return _mapper.Map<GetAllCustomerResDto, Customers>(customers);
        }
    }
}