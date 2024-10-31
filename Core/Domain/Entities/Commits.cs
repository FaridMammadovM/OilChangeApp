namespace Domain.Entities
{
    public sealed class Commits
    {
        public int Id { get; set; }
        public string CommitMessage { get; set; }
        public int CustumerId { get; set; }
        public Customers Customers { get; set; }
    }
}
