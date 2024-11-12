using Application.CQRS.Queries.Customer.Login.Dto;
using MediatR;

namespace Application.CQRS.Queries.Customer.Login
{
    public class LoginQuery : IRequest<LoginResDto>
    {
        public LoginReqDto Request { get; set; }
    }
}
