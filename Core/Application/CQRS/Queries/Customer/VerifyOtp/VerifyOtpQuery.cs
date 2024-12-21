using Application.CQRS.Queries.Customer.Login.Dto;
using Application.CQRS.Queries.Customer.VerifyOtp.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Customer.VerifyOtp
{
    public class VerifyOtpQuery : IRequest<LoginResDto>
    {
        public VerifyOtpReqDto Request { get; set; }
    }
}
