using MediatR;

namespace Application.CQRS.Queries.Customer.Logout
{
    public class LogoutQuery : IRequest<string>
    {
        public string RefreshToken { get; set; }
    }
}
