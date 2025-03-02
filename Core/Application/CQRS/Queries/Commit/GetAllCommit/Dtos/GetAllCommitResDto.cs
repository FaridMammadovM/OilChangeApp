namespace Application.CQRS.Queries.Commit.GetAllCommit.Dtos
{
    public class GetAllCommitResDto
    {
        public int Id { get; set; }
        public string CommitMessage { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Phone { get; set; }
        public bool IsRequest { get; set; }
        public bool IsRead { get; set; }
        public DateTime InsertedDate { get; set; }

    }
}
