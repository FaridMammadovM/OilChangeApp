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
            .Include(c => c.CustomersCars.Where(car => car.IsDeleted == false)));

            if (request.Request.Name != null && customers != null)
            {
                customers = customers
                    .Where(p => p.Name.ToUpper().Contains(request.Request.Name.ToUpper()))
                    .ToList();
            }
            if (request.Request.Surname != null && customers != null)
            {
                customers = customers
                    .Where(p => p.Surname.ToUpper().Contains(request.Request.Surname.ToUpper()))
                    .ToList();
            }
            if (request.Request.Phone != null && customers != null)
            {
                customers = customers
                    .Where(p => p.Phone.Contains(request.Request.Phone))
                    .ToList();
            }
            if (request.Request.CarNumber != null && customers != null)
            {
                customers = customers
        .Where(p => p.CustomersCars
            .Any(c => c.CarNumber.Contains(request.Request.CarNumber.ToUpper())))
        .ToList();
            }

            var customerDtos = customers.Select(c => new GetAllCustomerResDto
            {
                Id = c.Id,
                Name = c.Name,
                Surname = c.Surname,
                Phone = c.Phone,
                CustomersCars = c.CustomersCars.Select(car => new GetAllCustomerResListNumberDto
                {
                    CarNumber = car.CarNumber
                }).ToList()
            }).ToList();

            return customerDtos.OrderBy(c => c.Name)
                .ThenBy(c => c.Surname)
                .ToList();

        }
    }
}