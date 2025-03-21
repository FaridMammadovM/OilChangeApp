﻿using Application.Beheviors;
using Application.CQRS.Rules;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Commands.Customer.UpdateAdmin
{
    public class UpdateAdminCommandHandler : IRequestHandler<UpdateAdminCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CustomerRules _customerRules;
        private readonly ICostumMapper _mapper;
        private readonly JwtHelper _jwtHelper;
        private readonly int _refreshTokenExpiration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UpdateAdminCommandHandler(ICostumMapper mapper, IUnitOfWork unitOfWork,
            CustomerRules customerRules, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _customerRules = customerRules;
            _mapper = mapper;
            _jwtHelper = new JwtHelper(configuration);
            _refreshTokenExpiration = int.Parse(configuration["JwtSettings:RefreshTokenExpiration"]);
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(UpdateAdminCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);
            var customer = await _unitOfWork.GetReadRepository<Customers>().GetAsync(c => c.IsDeleted == false && c.Id == request.Request.Id);

            IList<Customers> customersList = await _unitOfWork.GetReadRepository<Customers>()
                .GetAllAsync(c => c.IsDeleted == false && c.Id != request.Request.Id);

            await _customerRules.CustomerFindUpdateUsername(customersList.Where(c => c.RoleId == 2), request.Request);

            customer.Name = request.Request.Name;
            customer.Surname = request.Request.Surname;
            customer.Username = request.Request.Username;
            customer.RefreshToken = _jwtHelper.GenerateRefreshToken();
            customer.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_refreshTokenExpiration);
            customer.UpdatedBy = userId;

            await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}