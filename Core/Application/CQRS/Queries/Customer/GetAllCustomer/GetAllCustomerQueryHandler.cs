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
            IList<Customers> customers = await _unitOfWork.GetReadRepository<Customers>()
                .GetAllAsync(c => c.IsDeleted == false && c.RoleId == 1,
            include: query => query
            .Include(c => c.CustomersCars));

            if (request.Request.CarNumber != null)
            {
                customers = customers
                    .Where(p => p.CustomersCars.Any(r => r.CarNumber == request.Request.CarNumber))
                    .ToList();
            }
            if (request.Request.Name != null)
            {
                customers = (IList<Customers>)customers.Where(p => p.Name.ToUpper() == request.Request.Name.ToUpper());
            }
            if (request.Request.Surname != null)
            {
                customers = (IList<Customers>)customers.Where(p => p.Surname.ToUpper() == request.Request.Surname.ToUpper());
            }
            if (request.Request.Phone != null)
            {
                customers = (IList<Customers>)customers.Where(p => p.Phone == request.Request.Phone);
            }


            return _mapper.Map<GetAllCustomerResDto, Customers>(customers);

        }
    }
}