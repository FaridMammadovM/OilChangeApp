using Application.CQRS.Queries.Customer.GetAdminById.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Customer.GetAdminById
{
    public class GetAdminByIdQueryHandler : IRequestHandler<GetAdminByIdQuery, GetAdminByIdResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetAdminByIdQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetAdminByIdResDto> Handle(GetAdminByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>().GetAsync(c => c.IsDeleted == false && c.Username == request.Username);

            if (customer == null)
            {
                return null;
            }

            var branchDto = _mapper.Map<GetAdminByIdResDto, Customers>(customer);


            return branchDto;
        }
    }
}