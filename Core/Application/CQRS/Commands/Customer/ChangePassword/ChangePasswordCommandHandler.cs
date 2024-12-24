﻿using Application.Beheviors;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Commands.Customer.ChangePassword
{
    public sealed class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtHelper _jwtHelper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ChangePasswordCommandHandler(IUnitOfWork unitOfWork,
            IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _jwtHelper = new JwtHelper(configuration);
        }
        public async Task<Unit> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            Customers customer = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(c => c.IsDeleted == false && c.Id == 1);
            customer.Password = _jwtHelper.HashPassword(request.Request.Password);
            customer.UpdatedBy = userId;
            await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
