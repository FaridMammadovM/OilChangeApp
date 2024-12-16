using Application.Beheviors;
using Application.CQRS.Commands.CostumersCarsMatrix.Update.Dtos;
using Application.CQRS.Rules;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.CostumersCarsMatrix.Update
{
    public sealed class UpdateCustomersCarsMatrixCommandHandler : IRequestHandler<UpdateCustomersCarsMatrixCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CostumersCarsMatrixRules _rules;
        private readonly ICostumMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UpdateCustomersCarsMatrixCommandHandler(IUnitOfWork unitOfWork, CostumersCarsMatrixRules rules, ICostumMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(UpdateCustomersCarsMatrixCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            IList<CustomersCarsMatrix> list = await _unitOfWork.GetReadRepository<CustomersCarsMatrix>().GetAllAsync(c => c.IsDeleted == false && c.Id == request.Request.Id);
            await _rules.MustNotBeSame(list, request.Request.CarNumber);

            CustomersCarsMatrix modelMap = _mapper.Map<CustomersCarsMatrix, UpdateCustomersCarsMatrixCommandReqDto>(request.Request);
            modelMap.InsertedBy = userId;

            await _unitOfWork.GetWriteRepository<CustomersCarsMatrix>().UpdateAsync(modelMap);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}