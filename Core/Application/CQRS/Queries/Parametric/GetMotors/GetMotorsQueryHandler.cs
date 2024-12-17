using Application.CQRS.Queries.Parametric.GetMotors.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetMotors
{
    public sealed class GetMotorsQueryHandler : IRequestHandler<GetMotorsQuery, IList<GetMotorsResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetMotorsQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetMotorsResDto>> Handle(GetMotorsQuery request, CancellationToken cancellationToken)
        {
            var motors = await _unitOfWork.GetReadRepository<Motor>().GetAllAsync(car => car.IsDeleted == false);
            return _mapper.Map<GetMotorsResDto, Motor>(motors);
        }
    }
}

