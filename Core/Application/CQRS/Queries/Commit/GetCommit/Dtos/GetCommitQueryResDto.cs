using Domain.Entities;

namespace Application.CQRS.Queries.Commit.GetCommit.Dtos
{
    public sealed class GetCommitQueryResDto
    {
        public int Id { get; set; }
        public string CommitMessage { get; set; }
        public bool IsRequest { get; set; }
        public DateTime InsertedDate { get; set; }
    }
}
