﻿using Application.CQRS.Queries.Customer.GetAllCustomer.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerQuery : IRequest<IList<GetAllCustomerResDto>>
    {
        public int Number { get; set; }
    }
}
