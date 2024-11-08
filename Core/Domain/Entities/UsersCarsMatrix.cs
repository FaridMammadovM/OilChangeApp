using Domain.Common;

namespace Domain.Entities
{
    public sealed class UsersCarsMatrix : EntityBase
    {
        public int CarId { get; set; }
        public int CustumerId { get; set; }
        public string CarNumber { get; set; }
        public Cars Cars { get; set; }
        public Customers Customers { get; set; }

    }
}
