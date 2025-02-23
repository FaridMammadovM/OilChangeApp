using Application.CQRS.Queries.Customer.AdminLogin.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Customer.AdminLogin
{
    public class AdminLoginQuery : IRequest<AdminLoginResDto>
    {
        public AdminLoginReqDto Request { get; set; }
    }
}