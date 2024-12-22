﻿using Application.Beheviors;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Commands.Commit
{
    public sealed class AddCommitCommandHandler : IRequestHandler<AddCommitCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AddCommitCommandHandler(IUnitOfWork unitOfWork, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(AddCommitCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            Commits customers = new Commits
            {
                CustumerId = userId,
                CommitMessage = request.Request.CommitMessage,
                InsertedBy = userId
            };

            await _unitOfWork.GetWriteRepository<Commits>().AddAsync(customers);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}