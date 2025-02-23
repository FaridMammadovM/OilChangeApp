using Application.CQRS.Queries.Customer.GetAdmins.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.Customer.GetAdmins
{
    public class GetAdminsQueryHandler : IRequestHandler<GetAdminsQuery, IList<GetAdminsResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetAdminsQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetAdminsResDto>> Handle(GetAdminsQuery request, CancellationToken cancellationToken)
        {
            var customers = await _unitOfWork.GetReadRepository<Customers>()
                .GetAllAsync(c => c.IsDeleted == false && c.Id != 1 && c.RoleId == 2,
            include: query => query
            .Include(c => c.CustomersCars));

            return _mapper.Map<GetAdminsResDto, Customers>(customers);
        }
    }
}
