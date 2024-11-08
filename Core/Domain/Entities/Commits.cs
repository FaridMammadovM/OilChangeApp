using Domain.Common;

namespace Domain.Entities
{
    public sealed class Commits : EntityBase
    {
        public string CommitMessage { get; set; }
        public int CustumerId { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        public Customers Customers { get; set; }

    }
}
