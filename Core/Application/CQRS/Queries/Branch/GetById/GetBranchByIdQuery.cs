using Application.CQRS.Queries.Branch.GetById.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Branch.GetById
{
    public class GetBranchByIdQuery : IRequest<GetBranchByIdResDto>
    {
        public int Id { get; set; }
    }
}
