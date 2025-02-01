namespace Application.CQRS.Queries.Commit.GetAllCommit.Dtos
{
    public class GetAllCommitResDto
    {
        public string CommitMessage { get; set; }
        public int CustumerId { get; set; }
        public bool IsRequest { get; set; }
        public DateTime InsertedDate { get; set; }

    }
}
