using Application.Beheviors;
using Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos;
using Application.CQRS.Rules;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.CostumersCarsMatrix.Add
{
    public sealed class AddCostumersCarsMatrixCommandHandler : IRequestHandler<AddCostumersCarsMatrixCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CostumersCarsMatrixRules _rules;
        private readonly ICostumMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AddCostumersCarsMatrixCommandHandler(IUnitOfWork unitOfWork, CostumersCarsMatrixRules rules, ICostumMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(AddCostumersCarsMatrixCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            IList<CustomersCarsMatrix> list = await _unitOfWork.GetReadRepository<CustomersCarsMatrix>().GetAllAsync(c => c.IsDeleted == false);
            await _rules.MustNotBeSame(list, request.Request);
            CustomersCarsMatrix model = _mapper.Map<CustomersCarsMatrix, AddCostumersCarsMatrixReqDto>(request.Request);
            model.InsertedBy = userId;
            await _unitOfWork.GetWriteRepository<CustomersCarsMatrix>().AddAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}