using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.OilChange.DeleteOilChange
{
    public sealed class DeleteOilChangeCommandHandler : IRequestHandler<DeleteOilChangeCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteOilChangeCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteOilChangeCommand request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<OilChanges>().GetAsync(car => car.Id == request.Id);
            model.IsDeleted = true;
            await _unitOfWork.GetWriteRepository<OilChanges>().UpdateAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
