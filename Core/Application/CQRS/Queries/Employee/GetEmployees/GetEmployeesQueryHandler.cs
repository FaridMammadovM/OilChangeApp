using Application.CQRS.Queries.Employee.GetEmployees.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Employee.GetEmployees
{
    public sealed class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, IList<GetEmployeesDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetEmployeesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetEmployeesDto>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<Employees>().GetAllAsync(c => c.IsDeleted == false);

            var mappedDtos = _mapper.Map<GetEmployeesDto, Employees>(model);

            foreach (var dto in mappedDtos)
            {
                dto.Fullname = $"{dto.Name} {dto.Surname}";
            }

            return mappedDtos.OrderBy(c => c.Name)
               .ThenBy(c => c.Surname)
               .ToList();
        }
    }
}