using Domain.Common;

namespace Domain.Entities
{
    public sealed class Commits : EntityBase
    {
        public string CommitMessage { get; set; }
        public int CustumerId { get; set; }
        public Customers Customers { get; set; }
        public bool IsRequest { get; set; } = false;

    }
}
