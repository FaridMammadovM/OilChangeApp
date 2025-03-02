using Application.Beheviors;
using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Commands.Customer.ChangePasswordWithAdmin
{
    public sealed class ChangePasswordWithAdminCommandHandler : IRequestHandler<ChangePasswordWithAdminCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtHelper _jwtHelper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly CustomerRules _customerRules;

        public ChangePasswordWithAdminCommandHandler(IUnitOfWork unitOfWork, CustomerRules customerRules,
            IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _jwtHelper = new JwtHelper(configuration);
            _customerRules = customerRules;
        }
        public async Task<Unit> Handle(ChangePasswordWithAdminCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            Customers customerAdmin = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(c => c.IsDeleted == false && c.Id == userId);
            //await _customerRules.ChangePasswordWithAdmin(customerAdmin.RoleId);
            Customers customer = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(c => c.IsDeleted == false && c.Id == request.Request.Id);
            customer.Password = _jwtHelper.HashPassword(request.Request.Password);
            customer.UpdatedBy = userId;
            await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
