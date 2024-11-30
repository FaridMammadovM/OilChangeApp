using Domain.Common;

namespace Domain.Entities
{
    public sealed class Phones : EntityBase
    {
        public string Phone { get; set; }
        public int BranchId { get; set; }
        public Branchies Branchies { get; set; }
    }
}
