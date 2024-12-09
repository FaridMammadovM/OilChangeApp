using Application.CQRS.Queries.CostumersCarsMatrix.GetAllCustomerCarsMatrix.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.CostumersCarsMatrix.GetAllCustomerCarsMatrix
{
    public sealed class GetAllCustomerCarsMatrixQueryHandler : IRequestHandler<GetAllCustomerCarsMatrixQuery, IList<GetAllCustomerCarsMatrixResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetAllCustomerCarsMatrixQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetAllCustomerCarsMatrixResDto>> Handle(GetAllCustomerCarsMatrixQuery request, CancellationToken cancellationToken)
        {
            var services = await _unitOfWork.GetReadRepository<CustomersCarsMatrix>().GetAllAsync(car => car.IsDeleted == false);
            return _mapper.Map<GetAllCustomerCarsMatrixResDto, CustomersCarsMatrix>(services);
        }
    }
}