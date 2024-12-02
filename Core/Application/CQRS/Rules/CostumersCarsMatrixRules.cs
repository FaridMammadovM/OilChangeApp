using Application.Bases;
using Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos;
using Application.CQRS.Exceptions.CustomersCarsMatrix;
using Domain.Entities;

namespace Application.CQRS.Rules
{
    public sealed class CostumersCarsMatrixRules : BaseRules
    {
        public Task MustNotBeSame(IList<CustomersCarsMatrix> model, AddCostumersCarsMatrixReqDto request)
        {
            if (model.Any(x => x.CarNumber == request.CarNumber))
                throw new CustomersCarsMatrixException();
            return Task.CompletedTask;
        }
    }
}
