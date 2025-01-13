using Application.CQRS.Queries.Customer.ResendOtp.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Customer.ResendOtp
{
    public class ResendOtpQuery : IRequest<Unit>
    {
        public ResendOtpDto Request { get; set; }
    }
}
