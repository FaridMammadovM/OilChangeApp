﻿using Application.Beheviors;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.OilChange.DeleteOilChange
{
    public sealed class DeleteOilChangeCommandHandler : IRequestHandler<DeleteOilChangeCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DeleteOilChangeCommandHandler(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(DeleteOilChangeCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            var model = await _unitOfWork.GetReadRepository<OilChanges>().GetAsync(car => car.Id == request.Id);
            model.IsDeleted = true;
            model.UpdatedBy = userId;
            await _unitOfWork.GetWriteRepository<OilChanges>().UpdateAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
