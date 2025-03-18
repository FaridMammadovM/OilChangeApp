using Application.CQRS.Commands.Customer.CreateAccount.Dtos;
using Application.CQRS.Queries.Customer.Login.Dto;
using MediatR;

namespace Application.CQRS.Commands.Customer.CreateAccount
{
    public class CreateAccountCommand : IRequest<LoginResDto>
    {
        public CreateAccountReqDto Request { get; set; }

    }
}

