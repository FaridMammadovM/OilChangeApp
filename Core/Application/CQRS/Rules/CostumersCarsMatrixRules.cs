using Application.Bases;
using Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos;
using Application.CQRS.Exceptions.CustomersCarsMatrix;
using Domain.Entities;

namespace Application.CQRS.Rules
{
    public sealed class CostumersCarsMatrixRules : BaseRules
    {
        public Task MustNotBeSame(IList<CustomersCarsMatrix> model, string carNumber)
        {
            if (model.Any(x => x.CarNumber == carNumber))
                throw new CustomersCarsMatrixException();
            return Task.CompletedTask;
        }
    }
}
