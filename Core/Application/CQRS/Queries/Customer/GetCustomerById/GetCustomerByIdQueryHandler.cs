﻿using Application.CQRS.Queries.Customer.GetCustomerById.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Customer.GetCustomerById
{
    public sealed class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetCustomerByIdQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetCustomerByIdResDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>().GetAsync(c => c.IsDeleted == false && c.Phone == request.Phone);

            if (customer == null)
            {
                return null;
            }

            var branchDto = _mapper.Map<GetCustomerByIdResDto, Customers>(customer);


            return branchDto;
        }
    }
}