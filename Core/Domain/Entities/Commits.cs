using Domain.Common;

namespace Domain.Entities
{
    public sealed class Commits : EntityBase, IEntityBase
    {
        public string CommitMessage { get; set; }
        public int CustumerId { get; set; }
        public Customers Customers { get; set; }
    }
}
