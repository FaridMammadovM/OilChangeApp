using Application.CQRS.Queries.Customer.Login.Dto;
using MediatR;

namespace Application.CQRS.Queries.Customer.CheckToken
{
    public class CheckTokenQuery : IRequest<LoginResDto>
    {
        public string RefreshToken { get; set; }
    }
}
