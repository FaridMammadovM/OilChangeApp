using Application.CQRS.Queries.CostumersCarsMatrix.GetCostumersCarsMatrixId.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.CostumersCarsMatrix.GetCostumersCarsMatrixId
{
    public sealed class GetCostumersCarsMatrixIdQueryHandler : IRequestHandler<GetCostumersCarsMatrixIdQuery, IList<GetCostumersCarsMatrixResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetCostumersCarsMatrixIdQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetCostumersCarsMatrixResDto>> Handle(GetCostumersCarsMatrixIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>()
        .GetAllAsync(c => c.Phone == request.Phone && c.IsDeleted == false,
                      include: query => query.Include(c => c.CustomersCars));

            if (customer == null || !customer.Any())
            {
                return new List<GetCostumersCarsMatrixResDto>();
            }

            var customerCarsMatrix = await _unitOfWork.GetReadRepository<CustomersCarsMatrix>()
                .GetAllAsync(c => c.CustomerId == customer.FirstOrDefault().Id && c.IsDeleted == false,
                             include: query => query.Include(c => c.Cars).Include(c => c.Customers));

            var result = customerCarsMatrix.Select(matrix => new GetCostumersCarsMatrixResDto
            {
                Id = matrix.Id,
                CustomerId = matrix.CustomerId,
                CarNumber = matrix.CarNumber,
                CarId = matrix.CarId,
                Model = matrix.Cars?.Model,
                Brand = matrix.Cars?.Brand,
                MotorId = matrix.MotorId,
                Year = matrix.Year,
                ColorsId = matrix.ColorsId,
                FuelTypeId = matrix.FuelTypeId,
                Description = matrix.Description
            }).ToList();

            return result;
        }
    }
}
