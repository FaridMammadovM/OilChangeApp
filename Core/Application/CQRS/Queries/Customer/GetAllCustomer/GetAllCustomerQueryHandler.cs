using Application.CQRS.Queries.Customer.GetAllCustomer.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
            var customers = await _unitOfWork.GetReadRepository<Customers>()
                .GetAllAsync(c => c.IsDeleted == false && c.RoleId == request.Request.Number,
            include: query => query
            .Include(c => c.CustomersCars));
             if (request.Request.CarNumber != null)
            {
                customers = customers
                    .Where(p => p.CustomersCars.Any(r => r.CarNumber == request.Request.CarNumber))
                    .ToList();
            }

            return _mapper.Map<GetAllCustomerResDto, Customers>(customers);

        }
    }
}